using System;

class PrintingNIntegers
    {
    static void Main()
        {
        uint numberOfValues;
        bool check;

        do //Enetring the number of values to print
            {
            Console.Write("Enter the number of values to print: ");
            check = uint.TryParse(Console.ReadLine(), out numberOfValues); //If the entered string is not an int number than check will be false and the loop will go on

            if (!check)  //Printing error message if the input is wrong
                {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("\nWrong input. You must enter a valid positive INT number\n");
                Console.BackgroundColor = ConsoleColor.Black;
                }

            }
        while (!check);

        for (int count = 1; count <= numberOfValues; count++)
            {
            Console.WriteLine(count);
            }
        }
    }

