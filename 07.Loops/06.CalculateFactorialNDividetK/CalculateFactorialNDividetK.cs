using System;
class CalculateFactorialNDividetK
{
    static void Main()
    {

        Console.Write("Input number n =: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Input number k =: ");
        int k = int.Parse(Console.ReadLine());

        int sum = 1;
        int factorialN = 1;
        int factorialK = 1;

        if (1 < k && k < n && n < 100)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i <= k)
                {
                    factorialK *= i;
                }
                factorialN *= i;
            }
            sum = factorialN/factorialK;
            Console.WriteLine(sum);
        }
        else
        {
            Console.WriteLine("Must be (1 < k < n < 100)");
        }
    }
}