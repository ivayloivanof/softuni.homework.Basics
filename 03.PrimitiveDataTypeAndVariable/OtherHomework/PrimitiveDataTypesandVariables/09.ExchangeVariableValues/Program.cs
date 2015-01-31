using System;


class Program
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int c = 14;

        Console.WriteLine("a = {0}, b = {1}", a,b);
        c = a;
        a = b;
        b = c;
        
        Console.WriteLine("a = {0}, b = {1}", a,b);
    }
}

