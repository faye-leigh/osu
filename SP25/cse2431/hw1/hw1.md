## HW 1

#### Question 1

What is the output of the following program? List ALL the
possible output(s)

1. Parent process runs first:

    ```start num is 99
    Parent's num is 110
    end num is 109
    Child's num is 130
    end num is 129
    ```

2. Child process runs first

    ```start num is 99
    Child's num is 130
    end num is 129
    Parent's num is 110
    end num is 109
    ```

3. Parent prints first then Child

    ```start num is 99
    Parent's num is 110
    Child's num is 130
    end num is 109
    end num is 129
    ```

4. Child prints first then Parent
    ```start num is 99
    Child's num is 130
    Parent's num is 110
    end num is 129
    end num is 109
    ```

#### Question 2

Which of the following scheduling algorithms could result in starvation? For those algorithms that might result in starvation, describe a situation in which starvation is likely to occur? (2 points)

1. First-come, first-served (FCFS)  
   FCFS does not typically result in starvation because each process will eventually get its turn to execute.

2. Shortest Job First (SJF)  
   SJF can result in starvation if there is a continuous stream of short jobs. In this case, longer jobs may never get scheduled because there are always shorter jobs arriving.

3. Round Robin  
   Round Robin does not typically result in starvation because each process gets an equal share of the CPU time in a cyclic order.

4. Basic MLFQ with first 4 rules  
   Basic MLFQ can result in starvation if a process is demoted to a lower-priority queue and there are always higher-priority processes available to run. The lower-priority process may never get CPU time.

**Job, Length, Arrival Time**  
J1, 85s, 0  
J2, 30, 10  
J3, 35, 10  
J4, 20, 80  
J5, 50, 85  
Time slice = 10s

**FIFO**

J1: completion 85, turnaround 85, response 0  
J2: completion 115, turnaround 115 - 10 = 105, response 85  
J3: completion 150, turnaround 150 - 10 = 140, response 115  
J4: completion 170, turnaround 170 - 80 = 90, response 150  
J5: completion 220, turnaround 220 - 85 = 135, response 170

**RR**

-   Round 1:
    -   J1 0-10, 75
-   Round 2:
    -   J1 10-20, 65
    -   J2 20-30, 20
    -   J3 30-40, 25
-   Round 3:
    -   J1 40-50, 65
    -   J2 50-60, 10
    -   J3 60-70, 15
-   Round 4:
    -   J1 70-80, 55
    -   J2 80-90, 0, completion 90
    -   J3 90-100, 5
    -   J4 100-110, 10
    -   J5 110-120, 40
-   Round 5:
    -   J1 120-130, 45
    -   J3 130-135, 0, completion 135
    -   J4 135-145, 0, completion 145
    -   J5 145-155, 30
-   Round 6:
    -   J1 155-165, 35
    -   J5 165-175, 20
-   Round 7:
    -   J1 175-185, 25
    -   J5 185-195, 10
-   Round 8:
    -   J1 205-215, 15
    -   J5 215-225, 0, completion 225
-   Round 9:
    -   J1 225-235, 5
-   Round 10:
    -   J1 235-240, 0, completion 240

J1: completion 85, turnaround 85, response 0  
J2: completion 115, turnaround 115 - 10 = 105, response 85  
J3: completion 150, turnaround 150 - 10 = 140, response 115  
J4: completion 170, turnaround 170 - 80 = 90, response 150  
J5: completion 220, turnaround 220 - 85 = 135, response 170

**Average Turnaround Time:** (220 + 70 + 115 + 55 + 120) / 5 = 116  
**Average Response Time:** (0 + 10 + 20 + 90 + 100) / 5 = 44

#### Question 3

#### Question 4
