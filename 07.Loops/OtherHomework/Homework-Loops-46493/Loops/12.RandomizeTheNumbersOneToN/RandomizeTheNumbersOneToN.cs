using System;
using System.Collections.Generic;

public class RandomizeTheNumbersOneToN
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Random randomValue = new Random();
        List<int> randomUniqueValues = new List<int>();

        while (randomUniqueValues.Count != n)
        {
            int randomNumber = randomValue.Next(1, n + 1);

            if (!randomUniqueValues.Contains(randomNumber))
            {
                randomUniqueValues.Add(randomNumber);
                Console.Write("{0} ", randomNumber);
            }
        }

        Console.WriteLine();
    }
}