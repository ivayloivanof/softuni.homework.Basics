using System;

class ExchangeIfGreather
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        if (a>b)
        {
            double c;
            c = a;
            a = b;
            b = c;
        }
        Console.WriteLine("{0} {1}",a,b);
    }
}

