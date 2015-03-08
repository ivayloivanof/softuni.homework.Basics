using System;
class CalculateGCD
{
    static void Main()
    {
        Console.WriteLine("Input 2 number:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int tmpNum = a%b;
        
        while (b != 0)
        {
            tmpNum = a % b;
            a = b;
            b = tmpNum;
        }
        Console.WriteLine(a);
    }
}