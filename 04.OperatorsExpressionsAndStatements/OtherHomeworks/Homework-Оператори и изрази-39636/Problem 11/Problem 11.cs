using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(@"Enter an integer: ");
            int n = int.Parse(Console.ReadLine());
            int movedN = (n >> 3);
            Console.Write(@"Third bit is: ");
            Console.WriteLine(movedN & 1);
            Console.ReadLine();
        }
    }
}
