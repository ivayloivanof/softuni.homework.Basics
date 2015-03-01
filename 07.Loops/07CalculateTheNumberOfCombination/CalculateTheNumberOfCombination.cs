using System;
using System.Numerics;

class CalculateTheNumberOfCombination
{
    static void Main()
    {
        Console.Write("Input number n =: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Input number k =: ");
        int k = int.Parse(Console.ReadLine());

        BigInteger sum = 1;
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        BigInteger factorialNK = 1;

        if (1 < k && k < n && n < 100)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i <= k)
                {
                    factorialK *= i;
                }
                factorialN *= i;
            }
            long nMinusK = (n - k);
            while (nMinusK >=1)
            {
                factorialNK *= nMinusK;
                nMinusK--;
            }
            sum = factorialN/(factorialK*factorialNK);
            Console.WriteLine(sum);
        }
        else
        {
            Console.WriteLine("Must be (1 < k < n < 100)");
        }
    }
}