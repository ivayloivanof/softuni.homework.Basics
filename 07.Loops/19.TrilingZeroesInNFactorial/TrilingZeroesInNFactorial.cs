using System;
using System.Linq;
using System.Numerics;

class TrilingZeroesInNFactorial
{
    static void Main()
    {
        Console.Write("Input integer number: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;
        int zeroes = 0;

        while (n>1)
        {
            factorial *= n;
            n--;
        }

        string factorialZero = Convert.ToString(factorial);
        factorialZero = new string(factorialZero.Reverse().ToArray());

        for (int i = 0; i < factorialZero.Length; i++)
        {
            if (factorialZero[i] == '0')
            {
                zeroes++;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine(factorial);
        Console.WriteLine(zeroes);
    }
}