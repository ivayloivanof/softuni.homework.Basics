using System;



class CalculateFactorial
{
    static void Main()
    {
        Console.WriteLine("Please enter first nmber");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter second nmber");
        int k = int.Parse(Console.ReadLine());
        double nFactorial = 1;
        double kFactorial = 1;

        for (int i = 1; i <= n; i++)
        {
            if (i<=k)
            {
                kFactorial *= i;
            }
            nFactorial *= i;
        }
        Console.WriteLine("n!/k! is {0}",nFactorial/kFactorial);
    }
}

