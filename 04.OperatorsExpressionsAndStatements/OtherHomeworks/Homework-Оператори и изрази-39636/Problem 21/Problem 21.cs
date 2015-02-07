using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(@"Enter the integer to be 'sieved': ");
            ulong toSieve = ulong.Parse(Console.ReadLine());
            Console.Write(@"Enter number of 'sieves' (N): ");
            int N = int.Parse(Console.ReadLine());
            if (N < 0 || N > 100)
            {
                Console.WriteLine("Invalid value for N!");
            }

            else
            {
                int count = 0;
                Console.WriteLine(@"On each of the next N lines write an integer representing a 'sieve': ");
                ulong[] sieves = new ulong[N];
                for (int i = 0; i < N; i++)
                {
                    sieves[i] = ulong.Parse (Console.ReadLine());
                }
                for (int i = 0; i < N; i++)
                {
                    toSieve = (~sieves[i]) & toSieve ;
                }
                double bits = Math.Log(toSieve, 2);
                while(toSieve!=0)
                {
                    if ((toSieve & 1) == 1)
                    {
                        count++;
                    }
                    toSieve >>= 1;
                }
                Console.WriteLine(@"Count of bits containing 1: {0}", count);
            }
        }
    }
}
