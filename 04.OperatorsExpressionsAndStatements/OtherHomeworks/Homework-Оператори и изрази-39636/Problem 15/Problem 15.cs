using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(@"Enter an unsigned integer: ");
            uint n = uint.Parse(Console.ReadLine());
            uint movedN1 = n >> 3;
            uint p = 7;
            uint movedN2 = n >> 24;
            uint firstChange = 7 & movedN1;
            uint secondChange = 7 & movedN2;
            uint changedN = ((~(p<<3))&n)&((~(p<<24)));
            uint movedChange1 = secondChange << 3;
            uint movedChange2 = firstChange << 24;
            uint changedN1 = changedN | movedChange1;
            uint changedN2 = changedN1 | movedChange2;
            Console.WriteLine(@"Result: {0}", changedN2);
        }
    }
}
