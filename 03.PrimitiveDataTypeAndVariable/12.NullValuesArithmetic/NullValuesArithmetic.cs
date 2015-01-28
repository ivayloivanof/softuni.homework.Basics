using System;
class NullValuesArithmetic
{
    static void Main()
    {
        int? valNullInt = new Int32();
        double? valNullDouble = new Double();

        Console.WriteLine(valNullInt);
        Console.WriteLine(valNullDouble);

        valNullInt = null;
        valNullDouble = null;

        Console.WriteLine(valNullInt);
        Console.WriteLine(valNullDouble);
        Console.ReadLine();
    }
}