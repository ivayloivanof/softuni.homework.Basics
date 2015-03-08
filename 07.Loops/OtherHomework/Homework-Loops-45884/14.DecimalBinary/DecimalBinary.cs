using System;



class DecimalBinary
{
    static void Main()
    {
        Console.WriteLine("Please enter decimal number");
        string numStr = Console.ReadLine();
        long numDec = long.Parse(numStr);
        string numBinary ="" ;

        while (numDec>0)
        {
            string byteValue = Convert.ToString(numDec % 2);
            numDec = numDec / 2;
            numBinary = byteValue+numBinary; 
        }
        Console.WriteLine(numBinary);
    }
}

