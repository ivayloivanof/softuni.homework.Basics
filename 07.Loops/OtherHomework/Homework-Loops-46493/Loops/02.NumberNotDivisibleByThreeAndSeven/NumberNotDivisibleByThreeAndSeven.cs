using System;

public class NumberNotDivisibleByThreeAndSeven
{
    public static void Main()
    {
        int userInput = int.Parse(Console.ReadLine());

        for (int i = 1; i <= userInput; i++)
        {
            if (!(i % 3 == 0 || i % 7 == 0))
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine();
    }
}