using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter coefficient for a: ");
        double coefA = double.Parse(Console.ReadLine());
        Console.Write("Enter coefficient for b: ");
        double coefB = double.Parse(Console.ReadLine());
        Console.Write("Enter coefficient for c: ");
        double coefC = double.Parse(Console.ReadLine());
        double determinant = (coefB * coefB) - (4 * coefA * coefC);

        if (determinant < 0)
        {
            Console.WriteLine("No real roots");
        }
        else  if (determinant > 0)
        {
            Console.WriteLine("Root X1 = {0}", (-coefB - Math.Sqrt(determinant)) / (2 * coefA));
            Console.WriteLine("Root X2 = {0}", (-coefB + Math.Sqrt(determinant)) / (2 * coefA));
        }
        else
        {
            Console.WriteLine("Root X1 = X2 = {0}", (-coefB / (2 * coefA)));
        }
           
        }	
}


