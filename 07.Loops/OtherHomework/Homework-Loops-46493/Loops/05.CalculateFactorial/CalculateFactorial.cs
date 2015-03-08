using System;

public class CalculateFactorial
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        double sum = 1;

        for (int i = 1; i <= n; i++)
        {
            sum += CalcFactorial(i) / Math.Pow(x, i);
        }

        Console.WriteLine("{0:0.00000}", sum);
    }

    private static double CalcFactorial(int factorialNumber)
    {
        double factorial = 1;

        for (int i = 1; i < factorialNumber; factorialNumber--)
        {
            factorial *= factorialNumber;
        }

        return factorial;
    }
}