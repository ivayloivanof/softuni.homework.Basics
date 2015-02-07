using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(@"Enter x-coordinate of the point: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write(@"Enter y-coordinate of the point: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write(@"Inside the circle & outside the rectangle: ");
            if (y > 1 && (x - 1) * (x - 1) + (y - 1) * (y - 1) <= 2.25)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
