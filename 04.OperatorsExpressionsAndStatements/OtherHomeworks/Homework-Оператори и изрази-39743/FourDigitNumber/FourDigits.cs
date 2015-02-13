using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigitNumber
{
    class FourDigits
    {
        public static int SumDigit(string Number)
        {
            int Sum = 0;
            for (int i = 0; i < 4; i++)
            {
                Sum = Sum + (int)Char.GetNumericValue((Number[i])); 
            }

            return Sum;
        }

        public static string ReverseNumber(string Number)
        {
            char[] charArray = Number.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public static string SwapSecondAndThird(string Number)
        {
            char[] array = Number.ToCharArray();
            char temp = array[1]; 
            array[1] = array[2]; 
            array[2] = temp; 
            return new string(array); 
        }
        
        static void Main()
        {
            Console.WriteLine("Enter the number:  ");
            string fourDigitNumber = Console.ReadLine();
            Console.WriteLine("Sum of digits: " + SumDigit(fourDigitNumber));
            Console.WriteLine("Reversed : " + ReverseNumber(fourDigitNumber));
            Console.WriteLine("Swapped: " + SwapSecondAndThird(fourDigitNumber));
        }
    }
}
