using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Input two digits:");
        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());

        double temp = firstNum - secondNum;

        if (temp > 0)
        {
            Console.WriteLine("{0} {1}", secondNum, firstNum);
        }
        else
        {
            Console.WriteLine("{0} {1}", firstNum, secondNum);
        }

    }
}
