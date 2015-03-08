using System;


class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Enter positive integer <20: ");
        int n = int.Parse(Console.ReadLine());
        int counter = 1;

        for (int j = 1; j <= n; j++)
        {
            for (int i = counter; i < n+counter; i++)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            counter += 1;
        }
    }

}