using System;

class SumOf3Numbers
{
    static void Main()
    {
        Console.Write("Enter first number with \",\" if it has: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Enter second number with \",\" if it has: ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Enter third number with \",\" if it has: ");
        float c = float.Parse(Console.ReadLine());
        Console.WriteLine("The sum of your numbers is : {0} ",(a+b+c));
    }
}

