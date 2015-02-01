using System;
class ExtractBit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int mask = 1 << 3;
        int result = number & mask;

        if (result == 0)
        {
            Console.WriteLine("Third bit is '0' " + Convert.ToString(number, 2).PadLeft(16, '0'));
        }
        else
        {
            Console.WriteLine("Third bit is '1' " + Convert.ToString(number, 2).PadLeft(16, '0'));
        }
        Console.ReadLine();
    }
}