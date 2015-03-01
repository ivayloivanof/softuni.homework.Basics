using System;

class SortNumbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a>=b)
        {
            if (b>=c)
            {
                Console.WriteLine("{0} {1} {2}",a,b,c);                
            }
            if (b<c)
            {
                if (c>a)
                {
                    Console.WriteLine("{0} {1} {2}",c,a,b);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}",a,c,b);
                }
            }
        }
        if (a<b)
        {
            if (b<c)
            {
                Console.WriteLine("{0} {1} {2}",c,b,a);
            }
            if (b>c)
            {
                if (a>c)
                {
                    Console.WriteLine("{0} {1} {2}",b,a,c);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}",b,c,a);
                }
            }
        }
    }
}

