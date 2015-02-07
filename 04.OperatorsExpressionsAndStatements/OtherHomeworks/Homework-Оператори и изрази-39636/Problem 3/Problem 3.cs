using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool divisible = true;
            Console.Write(@"Enter integer: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write(@"Divisible by 7 and 5?: ");
            if ( n%5 == 0 && n%7 == 0)
            {
                Console.WriteLine(divisible);
            }
            else
            {
                Console.WriteLine(!divisible);
            }
            Console.ReadLine();
        }
    }
}
