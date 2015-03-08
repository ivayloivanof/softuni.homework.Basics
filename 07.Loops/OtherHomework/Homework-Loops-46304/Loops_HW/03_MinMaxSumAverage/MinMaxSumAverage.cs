using System;

class MinMaxSumAverage
{
    static void Main()
    {
        Console.Write("Enter some number: ");
        int n = int.Parse(Console.ReadLine());
        int number;
        int min = int.MaxValue;
        int max = int.MinValue;
        int sum=0;
        double average;

        Console.WriteLine("Enter {0} numbers:", n);
        for (int i = 1; i <= n; i++)
        {
            int.TryParse(Console.ReadLine(), out number);
            if (number < min)
            {
                min = number;
            };
            if (number > max)
            { 
                max = number;
            };
            sum += number;
        }
        average = (double)sum / (double)n;

        Console.WriteLine("min = {0}", min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:0.00}", average);

    }
}

