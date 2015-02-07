using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyABitAGivenPosition
{
    class ModifyABitAGivenPosition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter unsigned integer: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter position: ");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value (0 or 1): ");
            int v = int.Parse(Console.ReadLine());
            
            if (v == 1)
            {
                int setOne = 1 << p;
                int foundBitOne = number | setOne;
                Console.WriteLine(foundBitOne);
            }
            else if (v == 0)
            {
                int setZero = ~(1 << p);
                int foundBitZero = number & setZero;
                Console.WriteLine(foundBitZero);
            }
            else
            {
                Console.WriteLine("Wrong value");
            }


        }
    }
}
