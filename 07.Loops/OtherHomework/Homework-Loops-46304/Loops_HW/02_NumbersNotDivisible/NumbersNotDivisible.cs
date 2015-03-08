using System;

class NumbersNotDivisible
{
    static void Main()
    {
        Console.WriteLine("Enter some number: ");
        int someNumber = int.Parse(Console.ReadLine());

        for (int i = 1; i <= someNumber; i++)
        {
            if (i % 3 == 0 || i % 7 == 0)
            {
                continue;
            }
            Console.Write("{0} ", i);
        }

        Console.WriteLine();

    }
}

