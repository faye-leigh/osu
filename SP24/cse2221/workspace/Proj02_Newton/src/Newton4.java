import components.simplereader.SimpleReader;
import components.simplereader.SimpleReader1L;
import components.simplewriter.SimpleWriter;
import components.simplewriter.SimpleWriter1L;

/**
 * CSE 2221 Project #2. Program for calculating the square root of a number to
 * within 0.01% relative error.
 *
 * @author Faye Leigh
 */
public final class Newton4 {

    /**
     * No argument constructor--private to prevent instantiation.
     */
    private Newton4() {
    }

    /**
     * Checks if input is close to zero.
     *
     * @param x
     *            number to be compared to number close to zero
     * @return true if input is close enough to zero, false if input is not zero
     */
    private static boolean isZero(double x) {
        final double eps = 1E-10;
        return x < eps;
    }

    /**
     * Computes estimate of square root of x to within relative error 0.01%.
     *
     * @param x
     *            positive number to compute square root of
     * @param error
     *            positive number that sets error threshold of calculations
     * @return estimate of square root
     */
    private static double sqrt(double x, double error) {
        double r = x;
        boolean flag = true;

        if (isZero(x)) { //If input is zero, skip calculation and return 0
            return 0.0;
        }
        while (flag) { //Compute square root of x until error is acceptable
            r = (r + x / r) / 2; //Newton iteration formula
            if (Math.abs(r * r - x) / x < error * error) { //Error calculation
                flag = false;
            }
        }
        return r;
    }

    /**
     * Main method.
     *
     * @param args
     *            the command line arguments
     */
    public static void main(String[] args) {
        SimpleReader in = new SimpleReader1L();
        SimpleWriter out = new SimpleWriter1L();

        final int digits = 4; //Number of decimal digits of output
        boolean flag = true;
        final double percent = 100.0;
        double input = 0.0, output = 0.0, error = 1.0;

        //Prompt to ask if user wishes to continue
        out.println("This program computes the square root "
                + "of any positive number. ");
        out.println("Would you like to continue? (y/n)");

        //Sets flag to false if user does not enter "y"
        String yn = in.nextLine();
        if (!yn.equals("y")) {
            flag = false;
        }
        if (flag) {
            out.println("Please enter the desired error threshold as a "
                    + "percentage (e.g. enter 0.01 for 0.01% error): ");
            error = in.nextDouble() / percent; //Convert % to decimal and store
        }

        /*
         * Until user declines, keep requesting numbers and outputting their
         * square roots
         */
        while (flag) {
            out.println("Enter a number: "); //Prompt for number
            input = in.nextDouble();
            if (input < 0) {
                flag = false;
            } else {
                output = sqrt(input, error); //Call method sqrt() to find sqrt of number
                out.print("The square root of " + input + " is ");
                out.print(output, digits, false);
                out.println();
            }
        }
        in.close();
        out.close();
    }
}