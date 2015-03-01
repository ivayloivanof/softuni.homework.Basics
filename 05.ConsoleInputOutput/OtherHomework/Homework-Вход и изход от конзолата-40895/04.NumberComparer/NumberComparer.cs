using System;
 
class NumberComparer
{
    static void Main()
    {
        Console.Write("Write number a = ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Write number b = ");
        float b = float.Parse(Console.ReadLine());

        Console.WriteLine("The greater one is: {0}", (a + b + Math.Abs(a - b)) / 2);

     }
}

