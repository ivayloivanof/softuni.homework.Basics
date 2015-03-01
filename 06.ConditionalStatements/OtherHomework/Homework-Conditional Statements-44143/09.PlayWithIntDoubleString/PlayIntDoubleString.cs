using System;

class PlayIntDoubleString
{
    static void Main()
    {
        Console.WriteLine(@"Please choose a type:
                           1 --> int
                           2 --> double
                           3 --> string");
        byte choice = byte.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1: Console.WriteLine("Please enter an integer: ");
                int a = int.Parse(Console.ReadLine());
                a += 1;
                Console.WriteLine(a);break;

            case 2: Console.WriteLine("Please enter a double: ");
                double b = double.Parse(Console.ReadLine());
                b += 1;
                Console.WriteLine(b);break;
            case 3: Console.WriteLine("Please enter a string: ");
                string c = Console.ReadLine();
                Console.WriteLine(c+"*");break;
        }
    }
}

