using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12_NullValuesArithmetic
{
    class Program

           //Create a program that assigns null values to an integer and to a double variable. 
           //Try to print these variables at the console. 
           //Try to add some number or the null literal to these variables and print the result.

    {
        static void Main()
        {
            int? number1 = null;
            double? number2 = null;
            Console.WriteLine("Current value of \"integer\" value is --> {0}", number1);
            Console.WriteLine("Current value of \"double\" value is --> {0}", number2);
            number1 = 5;
            number2 = 25;
            Console.WriteLine("New value of \"integer\" is --> {0}", number1);
            Console.WriteLine("New value of \"double\" is --> {0}", number2);
        }
    }
}
