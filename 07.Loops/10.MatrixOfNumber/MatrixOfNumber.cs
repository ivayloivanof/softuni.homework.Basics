using System;
class MatrixOfNumber
{
    static void Main()
    {
        Console.Write("Input number n: ");
        int n = int.Parse(Console.ReadLine());

        if(1 <= n && n <= 20)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= (i + (n-1)); j++)
                {
                    Console.Write("{0} ", j);
                }
                Console.WriteLine();
            }
        }
    }
}