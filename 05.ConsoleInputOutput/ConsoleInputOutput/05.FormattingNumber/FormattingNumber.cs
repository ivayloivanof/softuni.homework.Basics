using System;
    class FormattingNumber
    {
        static void Main()
        {
            try
            {
                int a = int.Parse(Console.ReadLine());  //(0 ≤ a ≤ 500)
                string aToBinary = Convert.ToString(a, 2).PadLeft(8, '0');
                float b = float.Parse(Console.ReadLine());
                float c = float.Parse(Console.ReadLine());
                if (a >= 0 && a <= 500)
                {
                    Console.WriteLine("|{0,-10:x}|{3}|{1,10:f2}|{2,-10:f3}|", a, b, c, aToBinary);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("First integer must be 0 <= int <= 500");
                    Console.ReadLine();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("This is not valid integer or float number!");
                Console.ReadLine();
            }

        }
    }