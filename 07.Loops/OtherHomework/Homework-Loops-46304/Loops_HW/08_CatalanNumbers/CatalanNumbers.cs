using System;
using System.IO;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter some integer: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger catalanN = 1;
        BigInteger nFaktorial = 1;
        BigInteger n2Faktorial = 1;

        for (int i = 1, j=1;  i <= (2*n); i++, j++)
        {
            n2Faktorial *= i;
            if (j <= n)
            {
                nFaktorial *= j;
            }
        }

        catalanN = n2Faktorial / (nFaktorial * nFaktorial * (n + 1));
        Console.WriteLine("The Catalan Number is: {0}", catalanN);
    }
}
