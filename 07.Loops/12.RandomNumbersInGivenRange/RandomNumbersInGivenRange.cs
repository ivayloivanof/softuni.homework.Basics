using System;
class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.Write("Input number for random: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Input min number: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Input max number: ");
        int max = int.Parse(Console.ReadLine());

        if (min <= max)
        {
            Random random = new Random();
            for (int i = 1; i <= n; i++)
            {
                int num = random.Next(min, max+1);
                Console.Write("{0} ", num);
            }
        }
        else
        {
            Console.WriteLine("min ≤ max");
        }
    }
}