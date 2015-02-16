using System;

class quadraticEquation
    {
    static void Main()
        {
        //Variables declaration

        double a, b, c, x1 = 0, x2 = 0;
        double discriminant;
        bool check;

        do //Entering a
            {
            Console.Write("Enter a: ");
            check = double.TryParse(Console.ReadLine(), out a); //If the entered string is not an int number than check will be false and the loop will go on

            if (!check)  //Printing error message if the input is wrong
                {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("\nWrong input. You must enter a valid positive decimal number\n");
                Console.BackgroundColor = ConsoleColor.Black;
                }

            }

        while (!check);

        do //Entering b
            {
            Console.Write("Enter b: ");
            check = double.TryParse(Console.ReadLine(), out b); //If the entered string is not an int number than check will be false and the loop will go on

            if (!check)  //Printing error message if the input is wrong
                {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("\nWrong input. You must enter a valid positive decimal number\n");
                Console.BackgroundColor = ConsoleColor.Black;
                }

            }

        while (!check);

        do //Entering c
            {
            Console.Write("Enter c: ");
            check = double.TryParse(Console.ReadLine(), out c); //If the entered string is not an int number than check will be false and the loop will go on

            if (!check)  //Printing error message if the input is wrong
                {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("\nWrong input. You must enter a valid positive decimal number\n");
                Console.BackgroundColor = ConsoleColor.Black;
                }

            }

        while (!check);

        //Calculating discriminant

        discriminant = Math.Sqrt(Math.Pow(b, 2) - (4 * a * c));

        //Calculating x1 and x2
        if (discriminant >= 0)
            {
            x1 = (-b + (double)discriminant) / (2 * a);
            x2 = (-b - (double)discriminant) / (2 * a);
            }
        else
            {
            Console.WriteLine("The discriminant is not valid");
            }

        Console.WriteLine("Result: x1 = {0}, x2 = {1}", x1, x2 );

        }
    }


