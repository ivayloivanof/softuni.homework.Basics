using System;
class ThirdDigit7
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int thirdNum = ( num / 100) % 10;
        Console.WriteLine(thirdNum == 7 ? true : false);
        Console.ReadLine();
    }
}