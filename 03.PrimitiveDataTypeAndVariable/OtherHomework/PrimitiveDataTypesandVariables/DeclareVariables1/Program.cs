using System;


    class Program
    {
        static void Main()
        {
            //Declare five variables choosing for each of them the most appropriate of the 
            //types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 
            //52130, -115, 4825932, 97, -10000. Choose a large enough type for each number to ensure it will fit in it. 
            //Try to compile the code. Submit the source code of your Visual Studio project as part of your homework submission.

            ushort firtsNum = 52130;
            sbyte secondNum = -115;
            int thirdNum = 4825932;
            byte fourthNum = 97;
            short fifthNum = -10000;

            Console.WriteLine("The Numbers are: {0}, {1}, {2}, {3}, {4} ", firtsNum, secondNum, thirdNum, fourthNum, fifthNum );

        }
    }

