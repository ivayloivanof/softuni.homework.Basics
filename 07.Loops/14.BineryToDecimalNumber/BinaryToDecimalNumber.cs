using System;
using System.Linq;

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.Write("Input number in binary format (01010101): ");
        string n = Console.ReadLine();
        n = new string(n.Reverse().ToArray());
        long num = 0;

        for (int i = 0; i < n.Length; i++)
        {
            double position = Math.Pow(2, i);
            if (i == 0 && n[i] == '1')
            {
                num += 1;
            } 
            else if (n[i] == '1')
            {
                num += (long) position;
            }
        }
        Console.WriteLine(num);
    }
}