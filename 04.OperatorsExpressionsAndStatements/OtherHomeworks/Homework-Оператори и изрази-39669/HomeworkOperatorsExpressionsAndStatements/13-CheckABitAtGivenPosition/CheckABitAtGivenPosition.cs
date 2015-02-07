using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_CheckABitAtGivenPosition
{
    class CheckABitAtGivenPosition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter unsigned integer: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter position: ");
            int p = int.Parse(Console.ReadLine());
            int temp = number >> p;
            int bit = temp & 1;
            bool isOne = bit == 1;
            Console.WriteLine(isOne);
        }
    }
}
