using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(@"Enter an integer: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write(@"Enter position p: ");
            int p = int.Parse(Console.ReadLine());
            Console.Write(@"Enter value v: ");
            int v = int.Parse(Console.ReadLine());
            if (v != 1 && v != 0)
            {
                Console.WriteLine("Invalid value for v!");
            }
            else
            {
                Console.Write(@"Result: ");
                int index = 1 << p;
                if (v == 1)
                {
                    Console.WriteLine(n | (1 << p));
                }
                else
                {
                    if (((n >> p) & 1) == 1)
                    {
                        int mask = ~(1 << p);
                        Console.WriteLine(mask & n);
                    }
                    else
                    {
                        Console.WriteLine(Int32.MaxValue & n);
                    }
                }
            }
        }
    }
}
