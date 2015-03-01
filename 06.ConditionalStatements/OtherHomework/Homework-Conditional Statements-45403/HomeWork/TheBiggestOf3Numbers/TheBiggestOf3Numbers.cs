using System;

class TheBiggestOf3Numbers
{
    static void Main(string[] args)
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());

        double result;
        if (firstNumber > secondNumber)
        {
            if (firstNumber > thirdNumber)
            {
                result = firstNumber;
            }
            else
            {
                result = thirdNumber;
            }
        }
        else
        {
            if (secondNumber > thirdNumber)
            {
                result = secondNumber;
            }
            else
            {
                result = thirdNumber;
            }
        }
        Console.WriteLine(result);
    }
}