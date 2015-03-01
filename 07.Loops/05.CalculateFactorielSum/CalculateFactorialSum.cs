using System;
class CalculateFactorialSum
{
    static void Main()
    {
        Console.Write("Input number n =: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Input number x =: ");
        int x = int.Parse(Console.ReadLine());

        decimal sum = 1;
        long factorial = 1; 
        decimal square = 0;

        for (int i = 1; i <= n; i++)
        {
            factorial = GetFactorial(i);
            square = (decimal) Math.Pow(x, i);
            sum += factorial/square;
        }
        Console.WriteLine("{0:f5}", sum);
    }

    private static int GetFactorial(int number)
    {
        int factorial = 1;
        while (number >= 1)
            {
                factorial *= number;
                number--;
            } 
        return factorial; 
    }
}