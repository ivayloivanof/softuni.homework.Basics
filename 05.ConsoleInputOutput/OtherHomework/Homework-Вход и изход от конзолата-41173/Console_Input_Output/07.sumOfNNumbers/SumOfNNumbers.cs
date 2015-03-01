using System;


class SumOfNNumbers
    {
    static void Main()
        {
        uint numberOfValues, count = 0;
        double sumOfValues = 0, temp;
        bool check;

        do //Enetring the number of values to sum
            {
            Console.Write("Enter the number of values to sum: ");
            check = uint.TryParse(Console.ReadLine(), out numberOfValues); //If the entered string is not an int number than check will be false and the loop will go on

            if (!check)  //Printing error message if the input is wrong
                {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("\nWrong input. You must enter a valid positive INT number\n");
                Console.BackgroundColor = ConsoleColor.Black;
                }

            }
        while (!check);

        while (count < numberOfValues)
            {
            do //Checking the radius value
                {
                Console.Write("Enter value {0}: ", (count + 1));
                check = double.TryParse(Console.ReadLine(), out temp); //If the entered string is not an int number than check will be false and the loop will go on

                if (!check)  //Printing error message if the input is wrong
                    {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nWrong input. You must enter a valid value\n");
                    Console.BackgroundColor = ConsoleColor.Black;
                    }

                }

            while (!check);

            sumOfValues = sumOfValues + temp;
            count++;
            }
        Console.WriteLine("The sum of entered values is: {0}", sumOfValues);
        }
    }

