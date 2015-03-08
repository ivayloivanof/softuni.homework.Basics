using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.Write("Please enter some positive integer: ");
        int someNumber = int.Parse(Console.ReadLine());

        if (someNumber < 0)
        {
            Console.WriteLine("Wrong number!");
            return;
        }
        else
        {
            for (int i = 1; i <= someNumber; i++)
            {
                Console.Write("{0} ", i);
            }
        }

        Console.WriteLine();
    }
}

