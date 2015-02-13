using System;
class WorkHours
{
    static void Main()
    {
        try
        {
            Console.Write("The required work hours to finish the project ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("The days available to finish the project ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("The productivity in percent ");
            byte p = byte.Parse(Console.ReadLine());
            int workHoursPerDay = 12;

            double workDay = d*0.9;
            double workHours = Math.Floor(workDay * workHoursPerDay * p / 100.0);

            if (h <= workHours)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.WriteLine(workHours - h);
            Console.ReadLine();
        }
        catch (Exception)
        {
            Console.WriteLine("This is not valid number!");
            Console.ReadLine();
        }
        
    }
}