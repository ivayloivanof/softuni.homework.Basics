using System;
class ExtractBitFromInteger
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        int positionBit = num >> position;
        string bits = Convert.ToString(positionBit, 2).PadLeft(16, '0');
        string numBits = Convert.ToString(num, 2).PadLeft(16, '0');

        Console.WriteLine("Bit of " + position + " position = " + bits[15] + " | " + numBits);
        Console.ReadLine();
    }
}