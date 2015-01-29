using System;
class CompreringFloats
{
    static void Main()
    {
        decimal a = 8.654331m;
        decimal b = 8.654321m;
        decimal sum = (decimal)(a - b);
        decimal eps = 0.000001m;
        Console.WriteLine((a - b));

        if ( sum < eps)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
        Console.ReadLine();
    }
}
