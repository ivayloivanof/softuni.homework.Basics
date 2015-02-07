using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_13
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            Console.Write(@"Enter an integer: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write(@"Enter position of the bit: ");
            int p = int.Parse(Console.ReadLine());
            int movedN = (n >> p);
            Console.Write(@"Bit at position {0} == 1: ", p);
            if ((movedN & 1) == 1)
            {
                Console.WriteLine(check);
            }
            else
            {
                Console.WriteLine(!check);
            }
        }
    }
}
