using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_GravitationOnTheMoon
{
    class GravitationOnTheMoon
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter weight: ");
            double weight = double.Parse(Console.ReadLine());
           double weightOnMoon = weight * 17 / 100;
            Console.WriteLine("Weight on moon will be: " + weightOnMoon);
            Console.ReadLine();
        }
    }
}
