using System;

class ReadThreeIntegers
    {
    static void Main()
        {
        int firstInt, secondInt, thirdInt;
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

        do //Checking the input for the third int number from the console
            {
            Console.Write("Enter an INT number to check: ");
            check = Int32.TryParse(Console.ReadLine(), out thirdInt); //If the entered string is not an int number than check will be false and the loop will go on

            if (!check)  //Printing error message if the input is wrong
                {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("\nWrong input. You must enter a valid INT number\n");
                Console.BackgroundColor = ConsoleColor.Black;
                }

            }

        while (!check);

        Console.WriteLine("First integer is {0}", firstInt);
        Console.WriteLine("Second integer is {0}", secondInt);
        Console.WriteLine("Third integer is {0}", thirdInt);
        Console.WriteLine("The sum of {0}, {1} and {2} is: {0} + {1} + {2} = {3}", firstInt, secondInt, thirdInt, firstInt + secondInt + thirdInt);
        }
    }

