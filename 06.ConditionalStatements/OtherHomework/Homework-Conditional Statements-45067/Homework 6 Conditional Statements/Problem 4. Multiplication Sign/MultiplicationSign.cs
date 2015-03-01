using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Input three real numbers:");
        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());
        double thirdNum = double.Parse(Console.ReadLine());

        if (firstNum != 0 && secondNum != 0 && thirdNum != 0)
        {

            if (firstNum < 0)
            {
                if (secondNum < 0 && thirdNum < 0)
                {
                    Console.WriteLine("-");
                }
                else
                {
                    Console.WriteLine("+");
                }
            }

            else
            {
                if (secondNum > 0 && thirdNum > 0)
                {
                    Console.WriteLine("+");
                }
                else
                {
                    Console.WriteLine("-");
                }
            }
        }
        else
        {
            Console.WriteLine("0");
        }

    }
}       