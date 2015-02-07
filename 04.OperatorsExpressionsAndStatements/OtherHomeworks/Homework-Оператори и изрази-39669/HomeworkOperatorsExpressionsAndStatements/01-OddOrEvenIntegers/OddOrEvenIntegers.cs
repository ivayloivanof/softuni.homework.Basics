using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OddOrEvenIntegers
{
    class OddOrEvenIntegers
    {
        static void Main(string[] args)
        {
            int number=0;
           
            Console.WriteLine("Enter an integer: ");
            
           number = int.Parse(Console.ReadLine());
           bool isOdd = number % 2 != 0;
            if (number% 2 == 0)
            {

                Console.WriteLine("{0} {1} is even number",isOdd,number);
            }
            else
            {
                Console.WriteLine("{0} {1} is odd number",isOdd, number);
            }
        }
    }
}
