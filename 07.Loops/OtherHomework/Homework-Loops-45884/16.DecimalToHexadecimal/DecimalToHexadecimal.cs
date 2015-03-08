using System;


class DecimalToHexadecimal
{
    static void Main()
    {
        Console.WriteLine("Please enter a integer number");
        string numStr = Console.ReadLine();
        long numDec = long.Parse(numStr);
        string numHexa = "";

        while (numDec>0)
        {
            string hexaValue = Convert.ToString(numDec % 16);
            numDec = numDec / 16;
            switch (hexaValue)
            {
                case "10": hexaValue = "A"; break;
                case "11": hexaValue = "B"; break;
                case "12": hexaValue = "C"; break;
                case "13": hexaValue = "D"; break;
                case "14": hexaValue = "E"; break;
                case "15": hexaValue = "F"; break;
            }
            numHexa = hexaValue + numHexa;
        }
        Console.WriteLine(numHexa);
    }
}

