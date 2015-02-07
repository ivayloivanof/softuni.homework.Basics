using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(@"Enter a positive integer less or equal to 100: ");
            bool check = false;
            int n = int.Parse(Console.ReadLine());
            if (n <=0 || n > 100)
            {
                Console.WriteLine("The given number is not a positive integer less or equal to 100!");
            }
            else if (n == 1)
            {
                Console.Write(@"Prime?: ");
                Console.WriteLine(check);
            }
            else if (n == 2)
            {
                Console.Write(@"Prime?: ");
                Console.WriteLine(!check);
            }
            else
            {
                Console.Write(@"Prime?: ");
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine(check);
                        break;
                    }
                    if (i == n - 1)
                    {
                        Console.WriteLine(!check);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
