using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool odd = false;
            Console.Write(@"Enter value: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write(@"Odd?: ");
            if (n % 2 == 0)
            {
                Console.WriteLine(odd);
            }
            else
            {
                Console.WriteLine(!odd);
            }
        }
    }
}
