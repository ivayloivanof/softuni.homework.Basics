using System;


class Randomize
{
    static void Main()
    {
        Console.WriteLine("Please enter number");
        int n = int.Parse(Console.ReadLine());
        Random rdm = new Random();

        for (int i = 0; i < n; i++)
        {
            int randomNumber = rdm.Next(1, n + 1);
            Console.Write("{0} ",randomNumber);
        }
        Console.WriteLine();
    }
}
