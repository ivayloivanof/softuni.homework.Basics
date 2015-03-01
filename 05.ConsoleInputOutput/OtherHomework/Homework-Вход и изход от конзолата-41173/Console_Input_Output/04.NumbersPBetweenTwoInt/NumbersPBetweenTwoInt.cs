using System;

class NumbersPBetweenTwoInt
    {
    static void Main()
        {
        //Declaring variables
        uint tempNum1, tempNum2, firstNum, secondNum;
        int pCounter = 0;
        bool check;

        do
            {
            do //Checking the input from the console for the first number
                {
                Console.Write("Enter the first positive INT number: ");
                check = uint.TryParse(Console.ReadLine(), out tempNum1);

                if (!check)  //Printing error message if the input is wrong
                    {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nWrong input. You must enter a valid positive INT number\n");
                    Console.BackgroundColor = ConsoleColor.Black;
                    }

                }

            while (!check);

            do //Checking the input from the console for the first number
                {
                Console.Write("Enter the second positive INT number: ");
                check = uint.TryParse(Console.ReadLine(), out tempNum2);

                if (!check)  //Printing error message if the input is wrong
                    {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nWrong input. You must enter a valid positive INT number\n");
                    Console.BackgroundColor = ConsoleColor.Black;
                    }

                }

            while (!check);
            if (tempNum1 == tempNum2)
                {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("\nYou entered equal numbers. Please enter two numbers again\n");
                Console.BackgroundColor = ConsoleColor.Black;
                }
            }
        while (tempNum1 == tempNum2);

        //Numbers alignemnt

        if (tempNum2 > tempNum1)
            {
            firstNum = tempNum1;
            secondNum = tempNum2;
            }
        else
            {
            firstNum = tempNum2;
            secondNum = tempNum1;
            }
        //Checking if there are numbers that can be devidet to 5 with reminder 0

        while (firstNum <= secondNum)
            {
            if (firstNum % 5 == 0)
                pCounter++;
            firstNum++;
            }

        //Printing the result

        Console.WriteLine("The count of numbers that can be devidet to 5 without reminder is: " + pCounter);
        }
    }

