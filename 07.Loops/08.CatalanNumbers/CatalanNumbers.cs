using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Input number n: ");
        int n = int.Parse(Console.ReadLine());

        if (n > 1 && n < 100)
        {
            BigInteger fact2N = 1;
            BigInteger factNPlus1 = 1;
            BigInteger factN = 1;
            for (int i = 1; i <= (n * 2); i++)
            {
                fact2N *= i;
                if (i <= n)
                {
                    factN *= i;
                }
                if (i <= n + 1)
                {
                    factNPlus1 *= i;
                }
            }
            Console.WriteLine(fact2N / (factNPlus1 * factN));
        }
        else if (n == 0)
        {
            Console.WriteLine(1);
        }
    }
}