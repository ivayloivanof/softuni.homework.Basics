using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(@"Enter width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write(@"Enter height: ");
            double height = double.Parse(Console.ReadLine());
            Console.Write(@"Perimeter: ");
            double perimeter = 2 * width + 2 * height;
            Console.WriteLine(perimeter);
            Console.Write(@"Area: ");
            double area = width * height;
            Console.WriteLine(area);
            Console.ReadLine();
        }
    }
}
