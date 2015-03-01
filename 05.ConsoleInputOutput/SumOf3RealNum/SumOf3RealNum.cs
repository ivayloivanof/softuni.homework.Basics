using System;
    class SumOf3RealNum
    {
        static void Main()
        {
            try
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());

                double sum = a + b + c;
                Console.WriteLine("{0}", sum);
            }
            catch (FormatException)
            {
                Console.WriteLine("This is not number!");
            }
            Console.ReadLine();
        }
    }