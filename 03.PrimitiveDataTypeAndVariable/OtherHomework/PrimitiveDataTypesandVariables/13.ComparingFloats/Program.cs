using System;

class Program
{
    static void Main(string[] args)
    {

        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());

        decimal eps = 0.000001M;


        if (a > b && ((a - b) > eps ||(a - b) < eps   ))
        {
            decimal sum = a - b;
            if (sum > eps)
            {
                Console.WriteLine("The difference of {0} is too big > eps", sum);
            }
            else
            {
                Console.WriteLine("The difference {0} < eps", sum);
            }
        }
        if (b > a && ((b - a) > eps || (b - a) < eps ))
        {
            decimal sum = b - a;
            if (sum > eps)
            {
                Console.WriteLine("The difference of {0} is too big (> eps)", sum);
            }
            else
            {
                Console.WriteLine("The difference {0} < eps", sum);
            }
        }

        //if (sum == eps)
        //{
        //    Console.WriteLine("Border case. The difference 0.000001 == eps. We consider the numbers are different.");
        //}
        //if (sum > eps)
        //{
        //    Console.WriteLine("The difference of {0} is too big (> eps)", sum);
        //}
        //else 
        //{
        //    Console.WriteLine("The difference {0} < eps", sum);
        //}


    }
}

