using System;

public class MinMaxSumAndAverageOfNNumbers
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double[] userNumbers = new double[n];
        double sum = 0;

        for (int i = 0; i < userNumbers.Length; i++)
        {
            userNumbers[i] = double.Parse(Console.ReadLine());
            sum += userNumbers[i];
        }
        Array.Sort(userNumbers);

        Console.WriteLine("min = {0:0.##}", userNumbers[0]);
        Console.WriteLine("max = {0:0.##}", userNumbers[n - 1]);
        Console.WriteLine("sum = {0:0.##}", sum);
        Console.WriteLine("avg = {0:0.##}", sum / n);
    }
}