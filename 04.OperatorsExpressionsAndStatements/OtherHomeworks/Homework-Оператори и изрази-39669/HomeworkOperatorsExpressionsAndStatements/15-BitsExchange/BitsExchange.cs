using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_BitsExchange
{
    class BitsExchange
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter unsigned integer :");
            uint number = uint.Parse(Console.ReadLine());
            uint firstBit = (number >>3) &7;
            uint secondBit= (number >> 24) & 7;
            uint firstmask = 7 << 3;
            uint secondMask = 7 << 24;
            number = number & ~firstmask | (secondBit << 3);
            number = number & ~secondMask | (firstBit << 24);








            Console.WriteLine(number);
        }
    }
}
