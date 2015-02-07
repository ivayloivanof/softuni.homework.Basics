using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(@"Enter an unsingned integer: ");
            uint n = uint.Parse(Console.ReadLine());
            Console.Write(@"Enter a value for p: ");
            int p = int.Parse(Console.ReadLine());
            Console.Write(@"Enter a value for q: ");
            int q = int.Parse(Console.ReadLine());
            Console.Write(@"Enter the step: ");
            int step = int.Parse(Console.ReadLine());
            int diff = p - q;
            if (diff < 0 )
            {
                diff= q-p;
            }
            if (diff < step)
            {
                Console.WriteLine("Overlapping");
            }
            else
            {
                if (p + step > 32 || q + step > 32)
                {
                    Console.WriteLine("Out of range!");
                }
                else
                {
                    uint sieve =1;
                    for (int i = 1; i < step; i++)
                    {
                        sieve <<= 1;
                        sieve = sieve | 1;
                    }
                    uint movedN1 = n >> p;
                    uint movedN2 = n >> q;
                    uint firstChange = sieve & movedN1;
                    uint secondChange = sieve & movedN2;
                    uint changedN = ((~(sieve << p)) & n) & ((~(sieve << q)));
                    uint movedChange1 = secondChange << p;
                    uint movedChange2 = firstChange << q;
                    uint changedN1 = changedN | movedChange1;
                    uint changedN2 = changedN1 | movedChange2;
                    Console.WriteLine("Result: {0}", changedN2);
                }
            }
        }
    }
}
