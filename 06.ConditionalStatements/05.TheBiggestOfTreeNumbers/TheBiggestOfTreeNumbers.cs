using System;
class TheBiggestOfTreeNumbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a > b)
        {
            if (a > c)
            {
                Console.WriteLine(a);
            }
            else if (a <= c)
            {
                Console.WriteLine(c);
            }
        }
        else if (a <= b)
        {
            if (b > c)
            {
                Console.WriteLine(b);
            }
            else if (b <= c)
            {
                Console.WriteLine(c);
            }
        }
        Console.ReadLine();
    }
}
