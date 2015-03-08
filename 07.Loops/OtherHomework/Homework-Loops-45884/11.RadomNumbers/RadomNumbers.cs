using System;

class RadomNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter number");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter min number");
        int min = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter max number");
        int max = int.Parse(Console.ReadLine());
        Random rdm = new Random();

        for (int i = 0; i < n; i++)
        {
            int randomNumber = rdm.Next(min, max + 1);
            Console.Write("{0} ", randomNumber);
        }
        Console.WriteLine();
    }
}

