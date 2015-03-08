using System;
using System.Linq;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        Console.Write("Input hexadecimal number: ");
        string hexadecimal = Console.ReadLine();
        hexadecimal = new string(hexadecimal.Reverse().ToArray());
        int num;
        long decimalNumber = 0;
        
        for (int i = 0; i < hexadecimal.Length; i++)
        {
            switch (hexadecimal[i])
            {
                case 'A': num = 10; break;
                case 'B': num = 11; break;
                case 'C': num = 12; break;
                case 'D': num = 13; break;
                case 'E': num = 14; break;
                case 'F': num = 15; break;
                default:
                    num = int.Parse(hexadecimal[i].ToString());
                    break;
            }
            decimalNumber += num*((long) Math.Pow(16, i));
        }
        Console.WriteLine(decimalNumber);
    }
}