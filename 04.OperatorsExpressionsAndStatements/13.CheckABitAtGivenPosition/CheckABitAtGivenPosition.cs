using System;
class CheckABitAtGivenPosition
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        int positionBit = num >> position;
        string bits = Convert.ToString(positionBit, 2).PadLeft(16, '0');
        string numBits = Convert.ToString(num, 2).PadLeft(16, '0');

        char charBit = bits[15];
        string stringBit = charBit.ToString();
        int bit = Convert.ToInt32(stringBit);

        Console.WriteLine("Position " + position + " | bit = " + bits[15] + " -> " + ((bit == 1) ? true : false) + " | " + numBits);
        Console.ReadLine();
    }
}