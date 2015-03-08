using System;

class MatrixNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter number");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int k = 0; k < n; k++)
            {
                Console.Write("{0:00} ", i + k);
            }
            Console.WriteLine();
        }
    }
}

