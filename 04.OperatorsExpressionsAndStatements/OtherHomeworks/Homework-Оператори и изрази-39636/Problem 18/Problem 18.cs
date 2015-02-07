using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumEven = 0;
            int sumOdd = 0;
            Console.Write(@"Enter integer: ");
            short n = short.Parse(Console.ReadLine());
            if (n < 0 || n > 500)
            {
                Console.WriteLine("Invalid value for count of numbers!");
            }
            else
            {
                int[] numbers = new int[2 * n];
                Console.WriteLine("Write the integers below:");
                for (int i = 0; i < 2 * n; i++)
                {
                    numbers[i] = int.Parse(Console.ReadLine());
                    if (numbers[i] % 2 == 0)
                    {
                        sumEven = sumEven + numbers[i];
                    }
                    else
                    {
                        sumOdd = sumOdd + numbers[i];
                    }
                }
                if (sumOdd == sumEven)
                {
                    Console.WriteLine("Yes, sum = {0}", sumOdd);
                }
                else
                {
                    if (sumOdd > sumEven)
                    {
                        int diff = sumOdd - sumEven;
                        Console.WriteLine("No, diff = {0}", diff);
                    }
                    else
                    {
                        int diff = sumEven - sumOdd;
                        Console.WriteLine("No, diff = {0}", diff);
                    }
                }
            }
        }
    }
}
