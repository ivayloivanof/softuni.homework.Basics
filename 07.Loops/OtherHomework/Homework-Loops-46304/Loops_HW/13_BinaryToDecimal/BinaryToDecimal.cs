using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter some binary number: ");
        string binary = Console.ReadLine();
        long decimalNum = 0;

            for (int i = binary.Length-1, j=0; i >= 0; i--, j++)
            {
                if (binary[j] == '1')
                    decimalNum += (long)Math.Pow(2, i); 
            }
       

        Console.WriteLine(decimalNum);
    }
}

