using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Trapezoids
{
    class Trapezoids
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  base A");
            double aBase = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter base B");
            double bBase = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height");
            double height = double.Parse(Console.ReadLine());
            double area = (aBase + bBase)/2 * height;
            Console.WriteLine("Area is: "+area);

        }
    }
}
