using System;
using System.Linq;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        Console.Write("Input decimal integer number: ");
        long decimalNumber = long.Parse(Console.ReadLine());
        string remainder;
        string hexadecimal = "";
        while (decimalNumber > 0)
        {
            remainder = Convert.ToString(decimalNumber % 16);
            switch (remainder)
            {
                case "10": remainder = "A"; break;
                case "11": remainder = "B"; break;
                case "12": remainder = "C"; break;
                case "13": remainder = "D"; break;
                case "14": remainder = "E"; break;
                case "15": remainder = "F"; break;
                default:
                    break;
            }
            hexadecimal += remainder;
            decimalNumber = decimalNumber/16;
        }

        hexadecimal = new string(hexadecimal.Reverse().ToArray());
        Console.WriteLine(hexadecimal);
    }
}