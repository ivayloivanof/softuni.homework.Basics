using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ThirdDigitIs7
{
    class ThirdDigitIs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert an integer: ");
            string number = Console.ReadLine();
            
            int intNumber = int.Parse(number);
            if (intNumber>99&&intNumber<-99)
            {
                bool digit = number[number.Length - 3] == 7;
                Console.WriteLine(digit);
            }
            else
            {
                Console.WriteLine("false");
            }
            

        }
    }
}
