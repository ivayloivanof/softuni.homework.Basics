using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            int sum=0;
            Console.WriteLine("Enter four digits number: ");
            int number = int.Parse(Console.ReadLine());

            int digit4 = number % 10;
            int digit3 = (number / 10) % 10;
            int digit2 = (number / 100) % 10;
            int digit1 = (number / 1000) % 10;
            Console.WriteLine(digit1 + digit2 + digit3 + digit4);
            Console.WriteLine("{0}{1}{2}{3}", digit4, digit3, digit2, digit1);
            Console.WriteLine("{0}{1}{2}{3}",digit4,digit1,digit2, digit3);
            Console.WriteLine("{0}{1}{2}{3}", digit1, digit3, digit2, digit4);

        }
    }
}
