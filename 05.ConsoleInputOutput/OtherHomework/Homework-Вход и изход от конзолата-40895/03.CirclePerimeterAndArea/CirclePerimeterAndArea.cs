using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter radius of a circle : ");
        double r = double.Parse(Console.ReadLine());
        double perimeterOfCircle = 2 * (Math.PI * r);
        double areaOfCircle = (r * r) * Math.PI;
        Console.WriteLine("Perimeter of the circle is = {0:F2}",perimeterOfCircle);
        Console.WriteLine("Area of the circle is = {0:F2}",areaOfCircle);
    }
}

