﻿using System;

class BonusScore
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        if (number >= 1 && number < 4)
        {
            Console.WriteLine(number*10);
        }
        else if (number >= 4 && number < 7)
        {
            Console.WriteLine(number * 100);
        }
        else if (number >= 7 && number < 10)
        {
            Console.WriteLine(number * 1000);
        }
        else
        {
            Console.WriteLine("invalid score");
        }
    }
}
