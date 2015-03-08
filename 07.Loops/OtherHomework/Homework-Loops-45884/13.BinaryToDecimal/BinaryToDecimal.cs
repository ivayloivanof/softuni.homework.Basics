using System;
using System.Numerics;



class BinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine("Please enter binary number");
        string binaryStr = Console.ReadLine();
        BigInteger binary = BigInteger.Parse(binaryStr);
        long numDec = 0;


        for (int i = 0; i < binaryStr.Length; i++)
        {
            byte byteValue = (byte)(binary % 10);
            binary = binary / 10;
            numDec += byteValue * (long)Math.Pow(2, i);
        }
        Console.WriteLine(numDec);
    }
}

