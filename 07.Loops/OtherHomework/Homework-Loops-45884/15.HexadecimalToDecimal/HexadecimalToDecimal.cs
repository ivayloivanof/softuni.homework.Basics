using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.WriteLine("Please enter a hexadecimal integer");
        string numStr = Console.ReadLine();    
        long numDec = 0;

        for (int i = 0; i < numStr.Length; i++)
        {
            char valueStr = numStr[i];
            int valueDec = 0;

            switch (valueStr)
            {
                case '0': valueDec = 0; break;
                case '1': valueDec = 1; break;
                case '2': valueDec = 2; break;
                case '3': valueDec = 3; break;
                case '4': valueDec = 4; break;
                case '5': valueDec = 5; break;
                case '6': valueDec = 6; break;
                case '7': valueDec = 7; break;
                case '8': valueDec = 8; break;
                case '9': valueDec = 9; break;
                case 'A': valueDec = 10; break;
                case 'B': valueDec = 11; break;
                case 'C': valueDec = 12; break;
                case 'D': valueDec = 13; break;
                case 'E': valueDec = 14; break;
                case 'F': valueDec = 15; break;
            }
            numDec += valueDec * (long)Math.Pow(16, numStr.Length - i-1);
        }
        Console.WriteLine(numDec);
    }
}

