using System;
    class NumbersFrom1ToN
    {
        static void Main()
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                int i;
                for (i = 1; i<=n; i++)
                {
                    Console.WriteLine(i);
                }
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("This is not integer number!");
                Console.ReadLine();
            }
        }
    }