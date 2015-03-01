using System;
using System.Globalization;
using System.Threading;

class BeerTime
{
    static void Main()
    {
        try
        {
            Console.Write("Enter Date in this Format(hh:mm tt): ");
            string time = Console.ReadLine();
	        DateTime timeValid = DateTime.ParseExact(time, "hh:mm tt", CultureInfo.InvariantCulture);

            DateTime startBearTime = DateTime.ParseExact("01:00 PM", "hh:mm tt", CultureInfo.InvariantCulture);
            DateTime endBearTime = DateTime.ParseExact("03:00 AM", "hh:mm tt", CultureInfo.InvariantCulture);

            if (timeValid > startBearTime || timeValid < endBearTime)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("invalid time");
        }

        Console.ReadLine();
    }
}