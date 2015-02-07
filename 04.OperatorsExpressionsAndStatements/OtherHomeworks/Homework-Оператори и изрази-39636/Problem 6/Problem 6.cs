using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(@"Enter a four-digit number: ");
            int n = int.Parse(Console.ReadLine());
            int firstDigit = n % 10;
            int secondDigit = n / 10 % 10;
            int thirdDigit = n / 100 % 10;
            int fourthDigit = n / 1000 % 10;
            if (n < 1000 || n > 9999)
            {
                Console.WriteLine("The number you've entered is not four-digit!");
            }
            else
            {
                Console.Write(@"The sum of the digits is: ");
                Console.WriteLine(firstDigit + secondDigit + thirdDigit + fourthDigit);
                Console.Write(@"Reversed: ");
                Console.WriteLine(firstDigit * 1000 + secondDigit * 100 + thirdDigit * 10 + fourthDigit);
                Console.Write(@"Last digit in front: ");
                Console.WriteLine(firstDigit * 1000 + fourthDigit * 100 + thirdDigit * 10 + secondDigit);
                Console.Write(@"Second and third digits exchanged: ");
                Console.WriteLine(fourthDigit * 1000 + secondDigit * 100 + thirdDigit * 10 + firstDigit);
            }
            Console.ReadLine();
        }
    }
}
