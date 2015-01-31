using System;

namespace Problem04_Unicode_Character
{
    class Program
    {
        static void Main()
        {
            int character = 42;
            Console.WriteLine("The hexadecimal representation of code 42 is: {0:X}", character);
            string symbol = "\u002A";
        }

    }
}
