using System;

class RandomNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter some number n, and two values min and max:");
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        Random r = new Random();

        for (int i = 1; i <= n; i++)
        {
            int rInt = r.Next(min, max);
            Console.Write("{0} ", rInt);
        }
    }
}
