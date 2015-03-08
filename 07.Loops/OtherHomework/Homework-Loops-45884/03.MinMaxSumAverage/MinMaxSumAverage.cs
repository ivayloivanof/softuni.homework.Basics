using System;



class MinMaxSumAverage
{
    static void Main()
    {
        Console.WriteLine("Please enter a possitive integer number");
        int n = int.Parse(Console.ReadLine());
        int minValue = int.MaxValue;
        int maxValue = int.MinValue;
        double sum = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Please enter number");
            int number = int.Parse(Console.ReadLine());
            if (number<minValue)
            {
                minValue = number;
            }
            if (number>maxValue)
            {
                maxValue = number;
            }
            sum += number;
        }
        Console.WriteLine("min = {0}",minValue);
        Console.WriteLine("max = {0}",maxValue);
        Console.WriteLine("sum = {0}",sum);
        Console.WriteLine("avg = {0:F2}",sum/n);
    }
}

