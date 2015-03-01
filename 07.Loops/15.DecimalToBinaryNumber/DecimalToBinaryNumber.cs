using System;
class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.Write("Input number in decimal format: ");
        long n = long.Parse(Console.ReadLine());
        string num = "";
        while (n != 0)
        {
            int remain = (int)n % 2;
            n /= 2;
            num = remain + num;
        }
        Console.WriteLine(num);
    }
}
