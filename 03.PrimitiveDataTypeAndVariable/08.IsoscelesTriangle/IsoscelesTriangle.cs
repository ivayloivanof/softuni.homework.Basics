using System;
class IsoscelesTriangle
{
    static void Main(string[] args)
    {
        char symbol = '\u00a9';
        Console.WriteLine("    " + symbol);
        Console.WriteLine("   " + symbol + " " + symbol);
        Console.WriteLine("  " + symbol + "   " + symbol);
        Console.WriteLine(" " + symbol + "     " + symbol);
        Console.WriteLine(symbol + "" + symbol + "" + symbol + "" + symbol + "" + symbol + "" + symbol + "" + symbol + "" + symbol + "" + symbol);
        Console.ReadLine();
    }
}