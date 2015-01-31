using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.NullValuesArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that assigns null values to an integer and to a double variable. 
            //Try to print these variables at the console. Try to add some number or the null literal 
            //to these variables and print the result.

            

        
            int? someInt = null;
            double? someDouble = null;
            Console.WriteLine("Null value: " + someInt);
            Console.WriteLine("Null value: " + someDouble);

            someInt += 8;
            someDouble += 14.3;
            Console.WriteLine("Number + null value: " + someInt);
            Console.WriteLine("Number + null value: " + someDouble);

            someInt = 8;
            someDouble = 14.8;
            Console.WriteLine("Number value: " + someInt);
            Console.WriteLine("Number value: " + someDouble);

        }
    }
}
