using System;
class SortTreeNumbersWithNestedIfs
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if ((a >= b) && (a >= c))
        {
            if (b >= c)
            {
                Console.WriteLine("{0} {1} {2}", a, b, c);
            }
            else if (b <= c)
            {
                Console.WriteLine("{0} {1} {2}", a, c, b);
            }
        }
        else if ((b >= a) && (b >= c))
        {
            if (a >= c)
            {
                Console.WriteLine("{0} {1} {2}", b, a, c);
            }
            else if (a <= c)
            {
                Console.WriteLine("{0} {1} {2}", b, c, a);
            }
        }
        else if ((c >= a) && (c >= b))
        {
            if (a >= b)
            {
                Console.WriteLine("{0} {1} {2}", c, a, b);
            }
            else if (a <= b)
            {
                Console.WriteLine("{0} {1} {2}", c, b, a);
            }
        }
        Console.ReadLine();
    }
}

