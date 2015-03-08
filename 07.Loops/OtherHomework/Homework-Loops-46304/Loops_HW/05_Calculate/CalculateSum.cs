using System;

class CalculateSum
{
    static void Main()
    {
        Console.WriteLine("Please enter n and x:");
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        double sum = 1;
        int faktorial = 1;
        double powerOfX = 1;

        for (int i = 1; i <= n; i++)
        {
            faktorial *= i;
            powerOfX = Math.Pow(x, i);
            sum += (faktorial / powerOfX); 
        }

        Console.WriteLine("{0:F5}",sum);
    }
}

