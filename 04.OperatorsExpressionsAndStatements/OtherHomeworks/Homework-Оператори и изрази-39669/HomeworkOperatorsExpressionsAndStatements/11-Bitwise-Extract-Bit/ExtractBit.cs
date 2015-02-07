using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Bitwise_Extract_Bit
{
    class ExtractBit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter unsigned integer: ");
            int number = int.Parse(Console.ReadLine());
       
            int temp = number >> 3;
            int bit = temp & 1;
           
            Console.WriteLine(bit);
        }
    }
}
