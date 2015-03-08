using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter some decimal number: ");
        long decimalNum = long.Parse(Console.ReadLine());
        string hexadecimal = "";
        long h;

        while (decimalNum != 0)
        {
            h = decimalNum % 16;
            decimalNum = decimalNum / 16;

            switch (h)
            {
                case 10:
                    hexadecimal += "A";
                    break;
                case 11:
                    hexadecimal += "B";
                    break;
                case 12:
                    hexadecimal += "C";
                    break;
                case 13:
                    hexadecimal += "D";
                    break;
                case 14:
                    hexadecimal += "E";
                    break;
                case 15:
                    hexadecimal += "F";
                    break;
                default:
                    hexadecimal += h;
                    break;
            }
        }

        char[] hexadecimalArray = hexadecimal.ToCharArray();
        string reverse = String.Empty;
        for (int i = hexadecimalArray.Length - 1; i > -1; i--)
        {
            reverse += hexadecimalArray[i];
        }

        Console.WriteLine(reverse);
    }
}

