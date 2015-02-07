using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int newStep = 6;
            Console.Write(@"Enter a value for n: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 1 || n > 100)
            {
                Console.WriteLine("Invalid value for n!");
            }
            else
            {
                Console.Write(@"Enter a value for the step: ");
                int step = int.Parse(Console.ReadLine());
                if (step < 1 || step > 20)
                {
                    Console.WriteLine("Invalid step value!");
                }
                else
                {
                    Console.WriteLine(@"On each of the next n lines enter a byte:");
                    int[] numbers = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        numbers[i] = int.Parse(Console.ReadLine());
                    }
                    for (int i = 0; i < n; i++)
                    {
                    Again:
                        numbers[i] = numbers[i] | (1 << newStep);
                        newStep = newStep - step;
                        if (newStep >= 0)
                        {
                            goto Again;
                        }
                        else
                        {
                            newStep = 8 + newStep;
                        }
                        Console.WriteLine(numbers[i]);
                    }
                    
                }
            }
        }
    }
}
