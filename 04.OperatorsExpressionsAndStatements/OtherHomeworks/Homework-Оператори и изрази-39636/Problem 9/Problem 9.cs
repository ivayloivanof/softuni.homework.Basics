using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(@"Enter value for side a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write(@"Enter value for side b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write(@"Enter value for the height(h): ");
            double height = double.Parse(Console.ReadLine());
            Console.Write(@"Area: ");
            Console.WriteLine((a + b) * height / 2);
        }
    }
}
