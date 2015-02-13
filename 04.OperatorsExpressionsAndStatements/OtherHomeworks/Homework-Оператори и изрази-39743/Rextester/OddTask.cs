using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rextester
{
    class OddTask
    {
        static void Main()
        {
          for (int i = -20; i <= 20; i++)
            {

                if (IsOdd(i))
                {
                    Console.WriteLine(i + "     True");
                }
                else
                {
                    Console.WriteLine(i + "      False");
                }
            }

        }
        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
        public static bool IsEven(int value)
        {
            return value % 2 == 0;
        }
   }
}

