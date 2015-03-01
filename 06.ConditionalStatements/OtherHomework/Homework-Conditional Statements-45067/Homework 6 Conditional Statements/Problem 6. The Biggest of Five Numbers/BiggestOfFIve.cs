using System;

class BiggestOfFIve
{
    static void Main()
    {
        Console.WriteLine("Input five real numbers:");
        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());
        double thirdNum = double.Parse(Console.ReadLine());
        double fourthNum = double.Parse(Console.ReadLine());
        double fifthNum = double.Parse(Console.ReadLine());


        if (firstNum >= secondNum && firstNum >= thirdNum && firstNum >= fourthNum && firstNum >= fifthNum)
        {
            Console.WriteLine(firstNum);
        }
        else if (secondNum >= thirdNum && secondNum >= fourthNum && secondNum >= fifthNum)
        {
            Console.WriteLine(secondNum);
        }
        else if (thirdNum >= fourthNum && thirdNum >= fifthNum)
        {
            Console.WriteLine(thirdNum);
        }
        else if (fourthNum >= fifthNum)
        {
            Console.WriteLine(fourthNum);
        }
        else
        {
            Console.WriteLine(fifthNum);
        }

    }
}