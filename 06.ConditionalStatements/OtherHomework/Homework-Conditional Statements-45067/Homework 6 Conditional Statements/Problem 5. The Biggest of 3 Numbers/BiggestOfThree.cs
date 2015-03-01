using System;

class BiggestOfThree
{
    static void Main()
    {
        Console.WriteLine("Input three real numbers:");
        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());
        double thirdNum = double.Parse(Console.ReadLine());

        if (firstNum <= secondNum && firstNum <= thirdNum)
        {
            if (secondNum < thirdNum)
            {
                Console.WriteLine(thirdNum);
            }
            else
            {
                Console.WriteLine(secondNum);
            }
        }
        else
        {
            Console.WriteLine(firstNum);
        }

    }
}