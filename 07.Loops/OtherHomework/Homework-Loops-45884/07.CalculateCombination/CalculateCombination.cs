using System;



class CalculateCombination
{
    static void Main()
    {
        Console.WriteLine("Please enter number");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter number");
        int k = int.Parse(Console.ReadLine());
        double nFactorial = 1;
        double kFactorial = 1;
        double nkFactorial = 1;

        for (int i = 1; i <= n; i++)
        {
            if (i<=(n-k))
            {
                nkFactorial *= i;
            }
            if (i <= k)
            {
                kFactorial *= i;
            }
            nFactorial *= i;
        }
        Console.WriteLine("sum is {0}", nFactorial / (kFactorial*nkFactorial));
    }
}
