using System;
class ExchangeVariableValues
{
    static void Main()
    {
        sbyte a = 5;
        sbyte b = 10;

        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);

        b = (sbyte)(a + b);
        a = (sbyte)(b - a);
        b = (sbyte)(b - a);

        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);

        Console.ReadLine();

    }
}
