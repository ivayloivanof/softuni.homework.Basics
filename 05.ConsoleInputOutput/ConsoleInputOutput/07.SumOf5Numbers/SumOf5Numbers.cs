using System;
    class SumOf5Numbers
    {
        static void Main()
        {
            

            try
            {
                double num0 = double.Parse(Console.ReadLine());
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());
                double num3 = double.Parse(Console.ReadLine());
                double num4 = double.Parse(Console.ReadLine());

                double sumNum = num0 + num1 + num2 + num3 + num4;

                Console.WriteLine("|{0} {1} {2} {3} {4} |{5} |", num0, num1, num2, num3, num4, sumNum);
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("This is not number!");
                Console.ReadLine();
            }
        }
    }