using System;




class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter number");
        int n = int.Parse(Console.ReadLine());
        double nFactorial = 1;
        double n2Factorial = 1;
        double nPlus1Factorial = 1;

        for (int i = 1; i <= 2*n; i++)
        {
            if (i<=(n+1))
            {
                nPlus1Factorial *= i;
            }
            if (i<=n)
            {
                nFactorial *= i;
            }
            n2Factorial *= i;
        }
        Console.WriteLine("Catalan number is {0}",n2Factorial/(nPlus1Factorial*nFactorial));
    }
}

