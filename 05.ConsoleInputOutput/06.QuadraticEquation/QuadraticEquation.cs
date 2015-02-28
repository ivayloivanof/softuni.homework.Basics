using System;
    class QuadraticEquation
    {
        static void Main()
        {
            try
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());

                if (a != 0)
                {
                    double discrim = (b*b) - (4*a*c);
                    if (discrim == 0)
                    {
                        double x = -b/(2*a);
                        Console.WriteLine("x = " + x);
                        Console.ReadLine();
                    }
                    else if (discrim < 0)
                    {
                        Console.WriteLine("Equation no real roots");
                        Console.ReadLine();
                    }
                    else
                    {
                        double x1 = (-b-Math.Sqrt(discrim))/(2*a);
                        double x2 = (-b+Math.Sqrt(discrim))/(2*a);
                        Console.WriteLine("x1 = {0}; x2 = {1}", x1, x2);
                        Console.ReadLine();
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("This is not number!");
                Console.ReadLine();
            }
        }
    }