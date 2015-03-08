using System;
using System.Numerics;

public class TrailingZeroesInN
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;

        for (int i = n; i > 1; i--)
        {
            factorial *= i;
        }

        string factorialString = factorial.ToString();
        int counter = 0;

        for (int i = factorialString.Length - 1; i > 0; i--)
        {
            if (factorialString[i] == '0')
            {
                counter++;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine(counter);
    }
}