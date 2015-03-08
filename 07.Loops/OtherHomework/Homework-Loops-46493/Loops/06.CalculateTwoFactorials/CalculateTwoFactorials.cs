using System;

public class CalculateTwoFactorials
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int sumOfTheDividend = 1;
        int sumOfTheDivisor = 1;

        while (n != 0)
        {
            sumOfTheDividend *= n;
            n--;

            if (k > 0)
            {
                sumOfTheDivisor *= k;
                k--;
            }
        }

        Console.WriteLine(sumOfTheDividend / sumOfTheDivisor);
    }
}