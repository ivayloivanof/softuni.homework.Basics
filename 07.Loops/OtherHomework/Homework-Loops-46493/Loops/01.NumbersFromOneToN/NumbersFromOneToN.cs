using System;

public class NumbersFromOneToN
{
    public static void Main()
    {
        int userInputNumber = int.Parse(Console.ReadLine());

        for (int i = 1; i <= userInputNumber; i++)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();
    }
}