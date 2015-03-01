using System;

class CirclePerimeterAndArea
    {
    static void Main()
        {
        double radius, perimeter, area;
        bool check;

        do //Checking the radius value
            {
            Console.Write("Enter the radius of the circle: ");
            check = double.TryParse(Console.ReadLine(), out radius); //If the entered string is not an int number than check will be false and the loop will go on

            if (!check || radius < 0)  //Printing error message if the input is wrong
                {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("\nWrong input. You must enter a valid positive decimal number\n");
                Console.BackgroundColor = ConsoleColor.Black;
                }

            }

        while (!check || radius < 0);

        //Calculating the results
        perimeter = 2 * Math.PI * radius;
        area = Math.PI * Math.Pow(2, radius);

        Console.WriteLine("The area of a circle with radius {0} is {1:f2}.", radius, area);
        Console.WriteLine("The perimeter of a circle with radius {0} is {1:f2}.", radius, perimeter);

        }
    }

