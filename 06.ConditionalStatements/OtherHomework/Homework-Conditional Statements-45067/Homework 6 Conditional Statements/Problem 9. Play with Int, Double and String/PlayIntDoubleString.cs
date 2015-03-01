using System;

class PlayIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:");
		Console.WriteLine("1 --> int");
		Console.WriteLine("2 --> double");
		Console.WriteLine("3 --> string");

        int input = int.Parse(Console.ReadLine());
        int first;
		double second;
        string third;

        if(input == 1)
        {
            Console.WriteLine("Please enter integer:");
            first = int.Parse(Console.ReadLine());
            first = first+1;
            Console.WriteLine(first);
        }
        else if(input == 2)
        {
            Console.WriteLine("Please enter double:");
            second = double.Parse(Console.ReadLine());
            second = second+1;
            Console.WriteLine(second);
        }
        else if (input == 3)
        {
            Console.WriteLine("Please enter string:");
            third = Console.ReadLine();
            Console.WriteLine(third + "*");
        }
        else
        {
            Console.WriteLine("Wrong type, try again!");
        }

        Console.Read();
		
    }
}