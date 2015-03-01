using System;
using System.Globalization;

class BeerTime
{
    static void Main(string[] args)
    {
        Console.Write("Please add the time in format HH:MM TT: ");
        String stringTime = Console.ReadLine();
        String isItAM = stringTime.Substring(stringTime.Length - 2, 2);
        DateTime result = DateTime.Parse(stringTime);
        if (result.Hour > 0 && isItAM == "PM")
        {
            Console.WriteLine("beer time");
        }
        else if (result.Hour < 3 && isItAM == "AM")
        {
            Console.WriteLine("beer time");
        }
        else
        {
            Console.WriteLine("non-beer time");
        }
    }
}