using System;

    class Program
    {
        static void Main()
        {
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            double greater = a > b ? a : b;
            Console.WriteLine(greater);
        }
    }

