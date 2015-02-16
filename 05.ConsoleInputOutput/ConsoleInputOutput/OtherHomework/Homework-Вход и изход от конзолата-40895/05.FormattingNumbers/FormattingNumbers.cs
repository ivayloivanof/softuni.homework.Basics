using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.WriteLine("Give us some numbers");

        Console.Write("Integer number a = ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Floating-point number b = ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Floating-point number c = ");
        double c = double.Parse(Console.ReadLine());

        Console.Write("|{0,-10:X}|", a);
        Console.Write(Convert.ToString(a, 2).PadLeft(10, '0') + "|");

        Console.Write("{0,10:0.00}|", b);

        Console.Write("{0,-10:0.000}|", c);
        
    }
}

