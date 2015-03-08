using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter some decimal number: ");
        long decimalNum = long.Parse(Console.ReadLine());
        string binary = "";
        long b;

        while (decimalNum != 0) 
       {
            b = decimalNum % 2;
            decimalNum = decimalNum / 2;
            if (b == 1)
            {
                binary += "1";
            }
            else
            {
                binary += "0";
            }
             
        }
       
        char[] binaryArray = binary.ToCharArray();
        string reverse = String.Empty;
        for (int i = binaryArray.Length - 1; i > -1; i--)
        {
            reverse += binaryArray[i];
        }

        Console.WriteLine(reverse);
    }
}
