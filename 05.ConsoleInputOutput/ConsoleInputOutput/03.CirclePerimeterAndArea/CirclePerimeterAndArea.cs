using System;
using System.Globalization;
using System.Threading;

class CirclePerimeterAndArea
    {
        static void Main()
        {
            try
            {
                double r = double.Parse(Console.ReadLine());
                double pi = Math.PI;
                double perimeter = (2*pi)*r;
                double area = pi*(r*r);

                Console.WriteLine("{0:f2}", perimeter);
                Console.WriteLine("{0:f2}", area);
            }
            catch (FormatException)
            {
                Console.WriteLine("This is not valid number!");
            }
            Console.ReadLine();
        }
    }