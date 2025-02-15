
import static org.junit.Assert.assertEquals;

import org.junit.Test;

import components.map.Map;
import components.map.Map.Pair;

/**
 * JUnit test fixture for {@code Map<String, String>}'s constructor and kernel
 * methods.
 *
 * @author Put your name here
 *
 */
public abstract class MapTest {

    /**
     * Invokes the appropriate {@code Map} constructor for the implementation
     * under test and returns the result.
     *
     * @return the new map
     * @ensures constructorTest = {}
     */
    protected abstract Map<String, String> constructorTest();

    /**
     * Invokes the appropriate {@code Map} constructor for the reference
     * implementation and returns the result.
     *
     * @return the new map
     * @ensures constructorRef = {}
     */
    protected abstract Map<String, String> constructorRef();

    /**
     *
     * Creates and returns a {@code Map<String, String>} of the implementation
     * under test type with the given entries.
     *
     * @param args
     *            the (key, value) pairs for the map
     * @return the constructed map
     * @requires <pre>
     * [args.length is even]  and
     * [the 'key' entries in args are unique]
     * </pre>
     * @ensures createFromArgsTest = [pairs in args]
     */
    private Map<String, String> createFromArgsTest(String... args) {
        assert args.length % 2 == 0 : "Violation of: args.length is even";
        Map<String, String> map = this.constructorTest();
        for (int i = 0; i < args.length; i += 2) {
            assert !map.hasKey(args[i]) : ""
                    + "Violation of: the 'key' entries in args are unique";
            map.add(args[i], args[i + 1]);
        }
        return map;
    }

    /**
     * Creates and returns a {@code Map<String, String>} of the reference
     * implementation type with the given entries.
     *
     * @param args
     *            the (key, value) pairs for the map
     * @return the constructed map
     * @requires <pre>
     * [args.length is even]  and
     * [the 'key' entries in args are unique]
     * </pre>
     * @ensures createFromArgsRef = [pairs in args]
     */
    private Map<String, String> createFromArgsRef(String... args) {
        assert args.length % 2 == 0 : "Violation of: args.length is even";
        Map<String, String> map = this.constructorRef();
        for (int i = 0; i < args.length; i += 2) {
            assert !map.hasKey(args[i]) : ""
                    + "Violation of: the 'key' entries in args are unique";
            map.add(args[i], args[i + 1]);
        }
        return map;
    }

    /**
     * Test for no-argument constructor compared to reference constructor.
     */
    @Test
    public final void testNoArgConstructor() {
        /*
         * Set up variables and call method under test
         */
        Map<String, String> m = this.constructorTest();
        Map<String, String> mExpected = this.constructorRef();
        /*
         * Assert that values of variables match expectations
         */
        assertEquals(mExpected, m);
    }

    /**
     * Test for add method on empty map.
     */
    @Test
    public final void testAddOnEmpty() {
        /*
         * Set up variables
         */
        Map<String, String> m = this.constructorTest();
        Map<String, String> mExpected = this.createFromArgsRef("a", "1");
        /*
         * Call method under test
         */
        m.add("a", "1");
        /*
         * Assert that values of variables match expectations
         */
        assertEquals(mExpected, m);
    }

    /**
     * Test for add method on non empty map.
     */
    @Test
    public final void testAddOnNonEmpty() {
        /*
         * Set up variables
         */
        Map<String, String> m = this.createFromArgsTest("a", "1", "b", "2");
        Map<String, String> mExpected = this.createFromArgsRef("a", "1", "b",
                "2", "c", "3");
        /*
         * Call method under test
         */
        m.add("c", "3");
        /*
         * Assert that values of variables match expectations
         */
        assertEquals(mExpected, m);
    }

    /**
     * Test for remove method on map containing single entry leaving empty map.
     */
    @Test
    public final void testRemoveToEmpty() {
        /*
         * Set up variables
         */
        Map<String, String> m = this.createFromArgsTest("a", "1");
        Map<String, String> mExpected = this.constructorRef();
        /*
         * Call method under test
         */
        Pair<String, String> p = m.remove("a");
        /*
         * Assert that values of variables match expectations
         */
        assertEquals(mExpected, m);
        assertEquals("a", p.key());
        assertEquals("1", p.value());
    }

    /**
     * Test for remove method on map containing multiple entries leaving non
     * empty map.
     */
    @Test
    public final void testRemoveToNonEmpty() {
        /*
         * Set up variables
         */
        Map<String, String> m = this.createFromArgsTest("a", "1", "b", "2");
        Map<String, String> mExpected = this.createFromArgsRef("a", "1");
        /*
         * Call method under test
         */
        Pair<String, String> p = m.remove("b");
        /*
         * Assert that values of variables match expectations
         */
        assertEquals(mExpected, m);
        assertEquals("b", p.key());
        assertEquals("2", p.value());
    }

    /**
     * Test for removeAny method on map containing single entry leaving empty
     * map.
     */
    @Test
    public final void testRemoveAnyToEmpty() {
        /*
         * Set up variables
         */
        Map<String, String> m = this.createFromArgsTest("a", "1");
        Map<String, String> mExpected = this.constructorRef();
        /*
         * Call method under test
         */
        Pair<String, String> p = m.removeAny();
        /*
         * Assert that values of variables match expectations
         */
        assertEquals(mExpected, m);
        assertEquals("a", p.key());
        assertEquals("1", p.value());
    }

    /**
     * Test for removeAny method on map containing multiple entries leaving non
     * empty map.
     */
    @Test
    public final void testRemoveAnyToNonEmpty() {
        /*
         * Set up variables
         */
        Map<String, String> m = this.createFromArgsTest("a", "1", "b", "2");
        Map<String, String> mExpected = this.createFromArgsRef("a", "1", "b",
                "2");
        /*
         * Call method under test
         */
        Pair<String, String> p = m.removeAny();
        Pair<String, String> pExpected = mExpected.remove(p.key());
        /*
         * Assert that values of variables match expectations
         */
        assertEquals(mExpected, m);
        assertEquals(pExpected, p);
    }

    /**
     * Test for removeAny method on map containing single pair leaving empty
     * map.
     */
    @Test
    public final void testValueOnSingleEntry() {
        /*
         * Set up variables
         */
        Map<String, String> m = this.createFromArgsTest("a", "1");
        Map<String, String> mExpected = this.createFromArgsRef("a", "1");
        /*
         * Call method under test
         */
        String s = m.value("a");
        String sExpected = "1";
        /*
         * Assert that values of variables match expectations
         */
        assertEquals(mExpected, m);
        assertEquals(sExpected, s);
    }

    /**
     * Test for removeAny method on map containing single pair leaving empty
     * map.
     */
    @Test
    public final void testValueOnMultipleEntries() {
        /*
         * Set up variables
         */
        Map<String, String> m = this.createFromArgsTest("a", "1", "b", "2", "c",
                "3");
        Map<String, String> mExpected = this.createFromArgsRef("a", "1", "b",
                "2", "c", "3");
        /*
         * Call method under test
         */
        String s = m.value("b");
        String sExpected = "2";
        /*
         * Assert that values of variables match expectations
         */
        assertEquals(mExpected, m);
        assertEquals(sExpected, s);
    }

    /**
     * Test for hasKey method on empty map.
     */
    @Test
    public final void testHasKeyOnEmpty() {
        /*
         * Set up variables
         */
        Map<String, String> m = this.constructorTest();
        Map<String, String> mExpected = this.constructorRef();
        /*
         * Call method under test and assert that values of variables match
         * expectations
         */
        assertEquals(mExpected, m);
        assertEquals(false, m.hasKey("a"));
    }

    /**
     * Test for hasKey method on non map with key not in map.
     */
    @Test
    public final void testHasKeyOnSingleEntryFalse() {
        /*
         * Set up variables
         */
        Map<String, String> m = this.createFromArgsTest("a", "1");
        Map<String, String> mExpected = this.createFromArgsRef("a", "1");
        /*
         * Call method under test and assert that values of variables match
         * expectations
         */
        assertEquals(mExpected, m);
        assertEquals(false, m.hasKey("b"));
    }

    /**
     * Test for hasKey method on non map with key not in map.
     */
    @Test
    public final void testHasKeyOnSingleEntryTrue() {
        /*
         * Set up variables
         */
        Map<String, String> m = this.createFromArgsTest("a", "1");
        Map<String, String> mExpected = this.createFromArgsRef("a", "1");
        /*
         * Call method under test and assert that values of variables match
         * expectations
         */
        assertEquals(mExpected, m);
        assertEquals(true, m.hasKey("a"));
    }

    /**
     * Test for hasKey method on non map with key not in map.
     */
    @Test
    public final void testHasKeyOnMultipleEntriesFalse() {
        /*
         * Set up variables
         */
        Map<String, String> m = this.createFromArgsTest("a", "1", "b", "2", "c",
                "3");
        Map<String, String> mExpected = this.createFromArgsRef("a", "1", "b",
                "2", "c", "3");
        /*
         * Call method under test and assert that values of variables match
         * expectations
         */
        assertEquals(mExpected, m);
        assertEquals(false, m.hasKey("d"));
    }

    /**
     * Test for hasKey method on non map with key not in map.
     */
    @Test
    public final void testHasKeyOnMultipleEntriesTrue() {
        /*
         * Set up variables
         */
        Map<String, String> m = this.createFromArgsTest("a", "1", "b", "2", "c",
                "3");
        Map<String, String> mExpected = this.createFromArgsRef("a", "1", "b",
                "2", "c", "3");
        /*
         * Call method under test and assert that values of variables match
         * expectations
         */
        assertEquals(mExpected, m);
        assertEquals(true, m.hasKey("c"));
    }

    /**
     * Test for size method on empty map.
     */
    @Test
    public final void testSizeOnEmpty() {
        /*
         * Set up variables
         */
        Map<String, String> m = this.constructorTest();
        Map<String, String> mExpected = this.constructorRef();
        /*
         * Call method under test
         */
        int i = m.size();
        int iExpected = 0;
        /*
         * Assert that values of variables match expectations
         */
        assertEquals(mExpected, m);
        assertEquals(iExpected, i);
    }

    /**
     * Test for size method on empty map.
     */
    @Test
    public final void testSizeOnNonEmpty() {
        /*
         * Set up variables
         */
        Map<String, String> m = this.createFromArgsTest("a", "1", "b", "2");
        Map<String, String> mExpected = this.createFromArgsRef("a", "1", "b",
                "2");
        /*
         * Call method under test
         */
        int i = m.size();
        int iExpected = 2;
        /*
         * Assert that values of variables match expectations
         */
        assertEquals(mExpected, m);
        assertEquals(iExpected, i);
    }

}
