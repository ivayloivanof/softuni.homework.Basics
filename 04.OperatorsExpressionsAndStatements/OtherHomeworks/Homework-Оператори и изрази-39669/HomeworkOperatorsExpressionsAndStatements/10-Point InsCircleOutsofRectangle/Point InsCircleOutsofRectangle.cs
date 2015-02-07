using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Point_InsCircleOutsofRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.Write("Enter x value : ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter y value : ");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine();
            
            if (((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= (1.5* 1.5))
            {
                Console.WriteLine(((x > 5) || (x < -1) || (y > 1) || (y < -1)) ? "yes" : "no");
               
            }
            else
            {
                Console.WriteLine("no");
               
            }
        }
    }
}
