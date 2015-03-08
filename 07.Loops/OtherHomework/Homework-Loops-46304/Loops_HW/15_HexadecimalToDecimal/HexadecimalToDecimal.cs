using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Enter some hexadecimal number: ");
        string hexadecimal = Console.ReadLine();
        long decimalNum = 0;
        int letterToNum = new int();

        for (int i = hexadecimal.Length - 1, j = 0; i >= 0; i--, j++)
        {
            switch (Char.ToUpper(hexadecimal[j]))
            {
                case 'A':
                    letterToNum = 10;
                    break;
                case 'B':
                    letterToNum = 11;
                    break;
                case 'C':
                    letterToNum = 12;
                    break;
                case 'D':
                    letterToNum = 13;
                    break;
                case 'E':
                    letterToNum = 14;
                    break;
                case 'F':
                    letterToNum = 15;
                    break;
                default:
                    letterToNum = (int)Char.GetNumericValue(hexadecimal[j]);
                    break;
            }


            decimalNum += letterToNum*(long)Math.Pow(16, i);
        }
        Console.WriteLine(decimalNum);
    }
}

