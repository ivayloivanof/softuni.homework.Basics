using System;

class ExchangeIfGreater
{
    static void Main(string[] args)
    {
        double first = double.Parse(Console.ReadLine());
        double second = double.Parse(Console.ReadLine());

        if (first > second)
        {
            double temp = second;
            second = first;
            first = temp;
        }
        Console.WriteLine("{0} {1}", first, second);
    }
}

