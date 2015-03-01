using System;

class Triangle
{
    static void Main(string[] args)
    {
        double aX = 2;
        double aY = 3;
        double bX = 0;
        double bY = -1;
        double cX = 4;
        double cY = -2;

        double slopeOne = (bY - aY) / (bX - aX);
        double slopeTwo = (cY - aY) / (cX - aX);

        if (slopeOne == slopeTwo)
        {
            //http://mathcentral.uregina.ca/QQ/database/QQ.09.07/s/betty1.html
            Console.WriteLine("No");
            double distance = ((bY - aY) * (bY - aY)) + ((bX - aX) * (bX - aX));
            double distanceFinal = Math.Sqrt(distance);
            Console.WriteLine("{0:0.00}", distanceFinal);
        }
        else
        {
            Console.WriteLine("Yes");
            double aXMinusBX = aX - bX;
            double aYMinusBY = aY - bY;
            double aXMinusCX = aX - cX;
            double aYMinusCY = aY - cY;
            double bXMinusCX = bX - cX;
            double bYMinusCY = bY - cY;
            double sqrtA = Math.Sqrt((aXMinusBX * aXMinusBX) + (aYMinusBY * aYMinusBY));
            double sqrtB = Math.Sqrt((aXMinusCX * aXMinusCX) + (aYMinusCY * aYMinusCY));
            double sqrtC = Math.Sqrt((bXMinusCX * bXMinusCX) + (bYMinusCY * bYMinusCY));
            double heron = (sqrtA + sqrtB + sqrtC) / 2;
            double area = Math.Sqrt(heron+(heron-sqrtA)+(heron-sqrtB)+(heron-sqrtC));
            Console.WriteLine(area);
        }
    }
}