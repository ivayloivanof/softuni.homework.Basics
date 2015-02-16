using System;


    class CirclePerimeterAndArea
    {
        static void Main()
        {
            Console.Write("r=");
            double r = double.Parse(Console.ReadLine());
            double p = 2 * (Math.PI) * r;
            double s = Math.PI * (r * r);
            Console.WriteLine("Perimeter is: {0}", Math.Round(p, 2));
            Console.WriteLine("Area is: {0}", Math.Round(s, 2));
        }
    }

