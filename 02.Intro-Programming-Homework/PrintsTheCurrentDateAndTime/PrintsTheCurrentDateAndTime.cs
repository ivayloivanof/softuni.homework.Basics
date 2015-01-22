using System;
class PrintsTheCurrentDateAndTime
{
    public static void Main()
    {
		DateTime currentDateTime = DateTime.Now;
        Console.WriteLine(currentDateTime);
        Console.ReadLine();
    }
}