using System;
using System.Numerics;

class CalculateCombinations
{
    static void Main()
    {
        Console.WriteLine("Enter n and k, where k<n<100: ");
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger nFaktorial = 1;
        BigInteger kFaktorial = 1;
        BigInteger nkFaktorial = 1;
        BigInteger combination = 1;

        for (int i = 1, j = 1; i <= n; i++, j++)
        {
            nFaktorial *= i;
            if (j <= k)
            {
                kFaktorial *= j;
            }
        }

        for (int i =1; i<=(n-k); i++)
        {
        nkFaktorial *= i;
        }

        combination = nFaktorial/(kFaktorial*nkFaktorial);
        Console.WriteLine(combination);
    }
}



