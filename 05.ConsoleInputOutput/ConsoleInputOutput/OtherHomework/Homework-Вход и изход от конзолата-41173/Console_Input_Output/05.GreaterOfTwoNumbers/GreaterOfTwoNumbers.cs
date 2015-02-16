using System;

class GreaterOfTwoNumbers
    {
    static void Main()
        {
        int firstInt, secondInt;
        bool check;

        do //Checking the input for the first int number from the console
            {
            Console.Write("Enter an INT number to check: ");
            check = Int32.TryParse(Console.ReadLine(), out firstInt); //If the entered string is not an int number than check will be false and the loop will go on

            if (!check)  //Printing error message if the input is wrong
                {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("\nWrong input. You must enter a valid INT number\n");
                Console.BackgroundColor = ConsoleColor.Black;
                }

            }

        while (!check);

        do //Checking the input for the second int number from the console
            {
            Console.Write("Enter an INT number to check: ");
            check = Int32.TryParse(Console.ReadLine(), out secondInt); //If the entered string is not an int number than check will be false and the loop will go on

            if (!check)  //Printing error message if the input is wrong
                {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("\nWrong input. You must enter a valid INT number\n");
                Console.BackgroundColor = ConsoleColor.Black;
                }

            }

        while (!check);

        //Printing the bigger number

        Console.WriteLine("The bigger number is {0}", Math.Max(firstInt, secondInt));
        }
    }

