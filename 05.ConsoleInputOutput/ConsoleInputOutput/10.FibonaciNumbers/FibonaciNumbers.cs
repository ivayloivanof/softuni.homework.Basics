using System;
    class FibonaciNumbers
    {
        static void Main()
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                int i;
                if (n == 1)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    int first = 0;
                    int second = 1;
                    Console.Write(first + " ");
                    Console.Write(second + " ");
                    int third = 0;
                    for (i = 2; i < n; i++)
                    {
                        third = first + second;
                        Console.Write(third + " ");
                        first = second;
                        second = third;
                    } 
                }
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("This is not number!");
                Console.ReadLine();
            }
        }
    }