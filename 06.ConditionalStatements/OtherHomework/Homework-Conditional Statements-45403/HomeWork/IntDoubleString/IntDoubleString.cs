using System;

class IntDoubleString
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please choose a type: ");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        Console.SetCursorPosition(22, 0);
        int usersChoice = int.Parse(Console.ReadLine());
        Console.SetCursorPosition(0, 4);
        int usersInt;
        double usersDouble;
        string usersString;
        if (usersChoice == 1)
        {
            Console.Write("Please enter an int: ");
            usersInt = int.Parse(Console.ReadLine());
            Console.WriteLine(usersInt + 1);
        }
        else if (usersChoice == 2)
        {
            Console.Write("Please enter a double: ");
            usersDouble = double.Parse(Console.ReadLine());
            Console.WriteLine(usersDouble + 1);
        }
        else
        {
            Console.Write("Please enter a string: ");
            usersString = Console.ReadLine();
            Console.WriteLine("{0}*", usersString);
        }

    }
}