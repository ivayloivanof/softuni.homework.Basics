using System;
using System.Linq;

    class SumOfFiveNumbers
    {
        static void Main()
        {
            Console.Write("Please, write 5 numbers separated by a space: ");
            var numbers = Console.ReadLine().Split().Take(5);
            Double[] digits = numbers.Select(d => Convert.ToDouble(d)).ToArray();
            double sum = digits.Sum();

            Console.WriteLine("The sum is: " + sum);
        }
    }
