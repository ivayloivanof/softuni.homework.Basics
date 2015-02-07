using System;
    class NumberComprarer
    {
        static void Main()
        {
            
            try
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());

                Console.WriteLine((a > b) ? a : b);
            }
            catch (FormatException)
            {
                Console.WriteLine("This is not valid number!");
            }
            Console.ReadLine();
        }
    }
