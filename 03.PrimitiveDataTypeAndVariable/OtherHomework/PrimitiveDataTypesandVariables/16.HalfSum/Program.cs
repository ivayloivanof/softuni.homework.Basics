using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.HalfSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int sumOne = 0;
            int sumTwo = 0;

            for (int i = 0; i < input; i++)
            {
                int numOne = int.Parse(Console.ReadLine());
                sumOne += numOne;

            }

            for (int i = 0; i < input; i++)
            {
                int numTwo = int.Parse(Console.ReadLine());
                sumTwo += numTwo;

            }

            if (sumOne == sumTwo)
            {
                Console.WriteLine("Yes, sum=" + sumOne);
            }
            else
            {
                if (sumOne > sumTwo)
                {
                    int caseOne = sumOne - sumTwo;
                    Console.WriteLine("No, diff=" + caseOne);
                }
                else
                {
                    int caseTwo = sumTwo - sumOne;
                    Console.WriteLine("No, diff=" + caseTwo);
                }

            }
        }
    }
}
