using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Poin_in_a_Circle
{
    class PoinInACircle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x value:");
            double xValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y value:");
            double yValue = double.Parse(Console.ReadLine());
            bool ifInside = Math.Abs(xValue * xValue + yValue * yValue) <= 4;
            Console.WriteLine(ifInside);
        }
    }
}
