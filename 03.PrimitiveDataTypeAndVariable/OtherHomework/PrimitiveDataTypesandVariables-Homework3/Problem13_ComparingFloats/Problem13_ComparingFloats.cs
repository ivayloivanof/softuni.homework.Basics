using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem13_ComparingFloats
{
    class Program
    //Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. 
    //Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic. 
    //Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps. Examples:

                    //     Number a	    Number b	             Equal (with precision eps=0.000001)	                Explanation
    //
    // 1-   5.3	         6.01	                              false	                                The difference of 0.71 is too big (> eps)
    // 2-   5.00000001	 5.00000003	                          true	                                The difference 0.00000002 < eps
    // 3-   5.00000005	 5.00000001                           true                                  The difference 0.00000004 < eps
    // 4-  -0.0000007	 0.00000007	                          true	                                The difference 0.00000077 < eps
    // 5-  -4.999999  	-4.999998	                          false	                                Border case. The difference 0.000001 == eps. We consider the numbers are different.
    // 6-   4.999999	 4.999998	                          false	                                Border case. The difference 0.000001 == eps. We consider the numbers are different.
    {
        /*Write a program that safely compares floating-point numbers with precision eps = 0.000001. Note that we cannot directly 
         * compare two floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic. Therefore, we 
         * assume two numbers are equal if they are more closely to each other than a fixed constant eps.*/
        static void Main(string[] args)
        {
            //This is the input.
            float firstA = 5.3f;
            float firstB = 6.01f;
            double secondA = 5.00000001;
            double secondB = 5.00000003;
            double thirdA = 5.00000003;
            double thirdB = 5.00000001;
            decimal fourthA = -0.0000007m;
            decimal fourthB = 0.00000007m;
            double fifthA = -4.999999;
            double fifthB = -4.999998;
            double sixthA =  4.999999;
            double sixthB =  4.999998;

            //This is the output
            Console.WriteLine("First pair: {0} and {1}\nSecond pair: {2} and {3}\nThird pair: {4} and {5}\nFourth pair: {6} and {7} \nFifth pair {6} and {7}\nSixth pair{8} and {9}", 
            firstA, firstB, secondA, secondB, thirdA, thirdB, fourthA, fourthB, fifthA, fifthB, sixthA, sixthB);
            
            Console.WriteLine();
            //I use separate method named CompareNumbers and type casting where it's needed instead of writing the same code four times.
            CompareNumbers((decimal)firstA, (decimal)firstB);
            CompareNumbers((decimal)secondA, (decimal)secondB);
            //I use the method for the third pair even though decimal numbers don't have comparison abnormalities and actually I 
            //don't need it for them.
            CompareNumbers((decimal)thirdA, (decimal)thirdB);
            CompareNumbers((decimal)fourthA, (decimal)fourthB);
            CompareNumbers((decimal)fifthA, (decimal)fifthB);
            CompareNumbers((decimal)sixthA, (decimal)sixthB);
            //Example: (decimal)firstA - Explicit conversion between different data types(http://msdn.microsoft.com/en-us/library/ms173105.aspx)
            Console.ReadLine();
        }

        //Separate method
        private static void CompareNumbers(decimal numberA, decimal numberB)
        {
            //This is the code that actually do the job. 
            //If you don't use separate method you need to write it four times - with every pair of numbers.
            if (Math.Abs(numberA - numberB) < 0.000001m)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}