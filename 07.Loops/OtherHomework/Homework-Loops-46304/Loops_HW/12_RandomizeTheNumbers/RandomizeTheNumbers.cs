using System;

class RandomizeTheNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter some number n:");
        int n = int.Parse(Console.ReadLine());
        Random r = new Random();
        int[] numbers = new int[n];
        bool[] added = new bool[n];
        int j = new int();

        for (int i = 0; i < n; i++)
        {
            numbers[i] = i + 1;
        }

        for (var count = 0; count < n; count++)
        {
            do
            {
                j = r.Next(n);
            }
            while (added[j]);

            Console.Write("{0} ",numbers[j]);
            added[j] = true;

        }

    }
}
