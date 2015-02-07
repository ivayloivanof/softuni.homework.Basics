using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = true; 
            Console.Write(@"Enter x-coordinate of the point: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write(@"Enter y-coordinate of the point: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write(@"Inside?: ");
            if (x*x + y*y <= 4)
            {
                Console.WriteLine(check);
            }
            else
            {
                Console.WriteLine(!check);
            }
            Console.ReadLine();
        }
    }
}
