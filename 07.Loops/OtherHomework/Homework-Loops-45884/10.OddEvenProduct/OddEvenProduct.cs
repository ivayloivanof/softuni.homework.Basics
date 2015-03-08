using System;



class OddEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Please enter sequence of numbers");
        string sequenceNumbers = Console.ReadLine();
        string[] numbersString = sequenceNumbers.Split(' ');
        int productOdd = 1;
        int productEven = 1;

        for (int i = 0; i < numbersString.Length; i++)
        {
            if (i%2==0||i==0)
            {
                int oddNumber = int.Parse(numbersString[i]);
                productOdd *= oddNumber;
            }
            else
            {
                int evenNumber = int.Parse(numbersString[i]);
                productEven *= evenNumber;
            }
        }
        if (productOdd==productEven)
        {
            Console.WriteLine("Yes, product = {0}",productEven);
        }
        else
        {
            Console.WriteLine("No , odd product = {0}, even product = {1}",productOdd,productEven);
        }

    }
}

