using System;
class RandomizeTheNumber
{
    static void Main()
    {
        Console.Write("Input number for random: ");
        int n = int.Parse(Console.ReadLine());

        Random random = new Random();
        for (int i = 1; i <= n; i++)
        {
            int num = random.Next(1, n+1);
            Console.Write("{0} ", num);
        }
    }
}