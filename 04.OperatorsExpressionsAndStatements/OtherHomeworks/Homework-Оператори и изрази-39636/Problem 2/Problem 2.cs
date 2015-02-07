using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(@"Enter weight: ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write(@"Weight on the Moon: ");
            double weightOnMoon = 0.17 * weight;
            Console.WriteLine(weightOnMoon);
            Console.ReadLine();
        }
    }
}
