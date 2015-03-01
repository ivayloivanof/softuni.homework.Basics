using System;
class MinMaxSumAverageOfNNumbers
{
    static void Main()
    {
        Console.Write("Please insert integer number: ");
        int n = int.Parse(Console.ReadLine());
        int number;
        int sum = 0;
        int min = 0;
        int max = 0;
        double avg = 0.00;
        for (int i = 1; i <= n; i++)
        {
            number = int.Parse(Console.ReadLine());
            if (number >= max)
            {
                max = number;
            }
            
            if (number < min || i == 1)
            {
                min = number;
            }
            sum += number;
            avg = n/1.00;
        }
        Console.WriteLine("{0} {1} {2} {3:f2}", min, max, sum, (sum/avg));
    }
}