using System;
class DivideBy7And5
{
    static void Main()
    {
        int devidentNum = 35;
        int dividerNumFirst = 5;
        int dividerNumSecond = 7;
        int result = devidentNum / dividerNumFirst / dividerNumSecond;
        Console.WriteLine(result);
        Console.WriteLine((result == 0) ? false : true);
        Console.ReadLine();
    }
}