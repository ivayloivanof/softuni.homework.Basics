using System;

    class NumbersInterval
    {
        static void Main()
        {
            Console.Write("Start= ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Stop= ");
            int b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write(i);
                    if (i < b - 2)
                    {
                        Console.Write(",");
                    }
                }

            }
        }
    }

