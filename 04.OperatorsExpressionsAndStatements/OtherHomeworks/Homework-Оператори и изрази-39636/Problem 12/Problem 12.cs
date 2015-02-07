using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(@"Enter an integer: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write(@"Enter position of the bit: ");
            int p = int.Parse(Console.ReadLine());
            int movedN = (n >> p);
            Console.Write(@"Bit at position {0}: ", p);
            Console.WriteLine(movedN & 1);
        }
    }
}
