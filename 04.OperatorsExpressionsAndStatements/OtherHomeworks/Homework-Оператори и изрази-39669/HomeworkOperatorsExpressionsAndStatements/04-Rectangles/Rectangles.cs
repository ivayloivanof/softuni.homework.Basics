using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter width: ");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height");
            double height = double.Parse(Console.ReadLine());
            double perimeter = weight * 2 + height * 2;
            double area = weight *  height;
            Console.WriteLine("Perimeter is: {0};  Area is: {1} ",perimeter,area);

        }
    }
}
