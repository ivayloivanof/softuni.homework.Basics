using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thirdDigit
{
    class SevenDigit
    {
        public static bool IsThirdSeven(string number)
        {
            return number.Length >= 3 && number.Substring(number.Length - 3)[0] == '7';
        }

        static void Main()
        {
            Console.WriteLine("Enter a number:  ");
            string number = Console.ReadLine();
            Console.WriteLine(IsThirdSeven(number));
        }
    }
}
