using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = false;
            Console.Write(@"Enter number: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write(@"Third digit 7?: ");
            int thirdDigit = n / 100 % 10;
            if (n < 700)
            {
                Console.WriteLine(check);
            }
            else
            {
                if (thirdDigit != 7)
                {
                    Console.WriteLine(check);
                }
                else
                {
                    Console.WriteLine(!check);
                }
            }
            Console.ReadLine();
        }
    }
}
