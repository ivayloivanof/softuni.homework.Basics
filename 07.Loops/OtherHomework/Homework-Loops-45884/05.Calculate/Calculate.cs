using System;



class Calculate
{
    static void Main()
    {
        Console.WriteLine("Please enter first integer number");
        double n = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter second second integer number");
        double x = double.Parse(Console.ReadLine());
        double sum = 1;
        double nFactorial = 1;

        for (int i = 1; i <= n; i++)
        {
            nFactorial *= i;
            sum += nFactorial / Math.Pow(x,i);
        }
        Console.WriteLine("Sum is {0:f5}", sum);
    }
}
