using System;
class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type: ");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        int chouse = int.Parse(Console.ReadLine());

        switch (chouse)
        {
            case 1:
                Console.Write("Please enter a int: ");
                int intN = int.Parse(Console.ReadLine());
                Console.WriteLine(intN + 1);
                break;
            case 2:
                Console.Write("Please enter a double: ");
                double doubleN = double.Parse(Console.ReadLine());
                Console.WriteLine(doubleN + 1);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                string stringN = Console.ReadLine();
                Console.WriteLine(stringN + "*");
                break;
        }
        Console.ReadLine();
    }
}
