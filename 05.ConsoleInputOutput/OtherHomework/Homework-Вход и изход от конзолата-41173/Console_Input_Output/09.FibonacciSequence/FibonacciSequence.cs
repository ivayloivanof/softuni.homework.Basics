using System;

class FibonacciSequence
    {
    static void Main()
        {
        //Declaring variables

        decimal a = 0;
        decimal b = 1;
        decimal c = a + b;
        int count = 0;

        //Printing first numbers

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);

        //Calculating and printing the numbers

        while (count < 97)
            {
            a = b;
            b = c;
            c = a + b;
            Console.WriteLine(c);
            count++;
            }
        }
    }

