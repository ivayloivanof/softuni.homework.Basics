using System;

class MultiplicationSign
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());

        if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
        {
            Console.WriteLine("0");
        }
        if (firstNumber > 0)
        {
            if (secondNumber > 0)
            {
                if (thirdNumber > 0)
                {
                    Console.WriteLine("+");
                }
                else
                {
                    Console.WriteLine("-");
                }
            }
            if (secondNumber < 0)
            {
                if (thirdNumber < 0)
                {
                    Console.WriteLine("+");
                }
                else
                {
                    Console.WriteLine("-");
                }
            }
        }
        if (firstNumber < 0)
        {
            if (secondNumber < 0)
            {
                if (thirdNumber < 0)
                {
                    Console.WriteLine("-");
                }
                else
                {
                    Console.WriteLine("+");
                }
            }
            if (secondNumber > 0)
            {
                if (thirdNumber > 0)
                {
                    Console.WriteLine("-");

                }
                else
                {
                    Console.WriteLine("+");
                }
            }
        }
    }
}

