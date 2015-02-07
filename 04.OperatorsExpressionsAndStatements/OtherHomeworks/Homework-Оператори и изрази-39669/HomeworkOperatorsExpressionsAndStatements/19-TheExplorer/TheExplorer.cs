using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_TheExplorer
{
    class TheExplorer
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int innDash = 1;
            int outDash = width / 2 - 1;
            int temp = -1;
            int temp2 = 2;
            Console.WriteLine(new string('-', width / 2) + '*' + new string('-', width / 2));
            for (int i = 1; i <= width - 2; i++)
            {
                Console.WriteLine(new string('-', outDash) + '*' + new string('-', innDash) + '*' + new string('-', outDash));

                if (innDash == width - 2)
                {
                    temp *= -1;
                    temp2 *= -1;
                }
                outDash += temp;
                innDash += temp2;
            }
            Console.WriteLine(new string('-', width / 2) + '*' + new string('-', width / 2));




        }
    }
}
