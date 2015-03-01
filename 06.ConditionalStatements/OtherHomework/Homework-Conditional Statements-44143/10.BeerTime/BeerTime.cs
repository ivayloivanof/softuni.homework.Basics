using System;
using System.Globalization;
using System.Threading;

class BeerTime
{
    static void Main()
    {
        Console.WriteLine("Please, enter time (hh:mm tt)");

        string time = Console.ReadLine();
        DateTime timeValue;
        bool isDate = DateTime.TryParse(time, out timeValue);
        while (!isDate)
        {
            Console.WriteLine("Invalid time format. Please, enter time (hh:mm tt)");
            time = Console.ReadLine();
            isDate = DateTime.TryParse(time, out timeValue);
        }

        int hour = timeValue.Hour;
        int minutes = timeValue.Minute;

        if ((hour >= 13 && hour <= 24) || hour == 1 || hour == 2)
        {
            Console.WriteLine("beer time");
        }
        else
        {
            Console.WriteLine("non-beer time");
        }
    }
}

