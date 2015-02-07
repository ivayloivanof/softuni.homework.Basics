using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter positive iteger: ");
            int nunber = int.Parse(Console.ReadLine());

            if (nunber != 0 && nunber > 0)
            {


                for (int i = 1; i < Math.Sqrt(nunber); i++)
                {
                    if (nunber % i == 0)
                    {
                        Console.WriteLine("true");
                        break;
                    }

                }

            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
