using System;


class DigitAsWord
{
    static void Main()
    {
        Console.WriteLine("Please, enter a number from 1 to 9.");
        string number = Console.ReadLine();
        int num;
        bool isNumber = int.TryParse(number,out num);
        while (!isNumber || num > 9||num<1)
        {
           Console.WriteLine("Not a digit from 1 to 9. Please, enter a new number");
           number = Console.ReadLine();
           isNumber = int.TryParse(number, out num);
        }
        switch (num)
        {
            case 1: Console.WriteLine("one"); break;
            case 2: Console.WriteLine("two"); break;
            case 3: Console.WriteLine("three"); break;
            case 4: Console.WriteLine("four"); break;
            case 5: Console.WriteLine("five"); break;
            case 6: Console.WriteLine("six"); break;
            case 7: Console.WriteLine("seven"); break;
            case 8: Console.WriteLine("eight"); break;
            case 9: Console.WriteLine("nine"); break;
        }
    }
}

