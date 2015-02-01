using System;
class FourDigitNumber
{
    static void Main()
    {
        int fourNum = int.Parse(Console.ReadLine());

        //fourth digit
        int firstDigitNum = fourNum % 10;

        //third digit
        int secondDigitNum = (fourNum / 10) % 10;

        //second digit
        int thirdDigitNum = (fourNum / 100) % 10;

        //first digit
        int fourthDigitNum = (fourNum / 1000) % 10;

        Console.WriteLine("FourDigitNumber " + fourNum);
        Console.WriteLine("Sum of all digits " + (firstDigitNum + secondDigitNum + thirdDigitNum + fourthDigitNum));
        Console.WriteLine("Reversed {0}{1}{2}{3}", firstDigitNum, secondDigitNum, thirdDigitNum, fourthDigitNum);
        Console.WriteLine("Last digit in front {0}{1}{2}{3}", firstDigitNum, fourthDigitNum, thirdDigitNum, secondDigitNum);
        Console.WriteLine("Second and third digits exchanged {0}{1}{2}{3}", fourthDigitNum, secondDigitNum, thirdDigitNum, firstDigitNum);
        Console.ReadLine();
    }
}