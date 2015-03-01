using System;

class BonusScore
{
    static void Main()
    {
        double num = double.Parse(Console.ReadLine());
        while (num == 0 || num > 9)
        {
            Console.WriteLine("Invalid score. Please, enter a new number:");
            num = double.Parse(Console.ReadLine());     
        }
        if (num>=1&&num<=3)
        {
            num *= 10;
            Console.WriteLine(num);
        }
        else if (num>=4&&num<=6)
        {
            num *= 100;
            Console.WriteLine(num);
        }
        else if (num>=7&&num<=9)
        {
            num *= 1000;
            Console.WriteLine(num);
        }
    }
}

