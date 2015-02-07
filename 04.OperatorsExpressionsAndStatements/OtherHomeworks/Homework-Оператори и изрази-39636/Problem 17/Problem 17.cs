using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(@"Leap or normal year?: ");
            string yearType = Console.ReadLine();
            Console.Write(@"Number of holidays (p): ");
            int numHolidays = int.Parse(Console.ReadLine());
            Console.Write(@"Number of weekends Vladi spends in his hometown (h): ");
            int numHome = int.Parse(Console.ReadLine());
            if (numHolidays < 0 || numHolidays > 300 || numHome < 0 || numHome > 48)
            {
                Console.WriteLine("Invalid value for p or h!");
            }
            else
            {
                double normalPlays = (48 - numHome) * 0.75;
                double holidayPlays = numHolidays * 2 / 3;
                if (yearType == "leap")
                {
                    double totalPlays = Math.Floor(1.15 * ((holidayPlays + normalPlays + numHome)));
                    Console.WriteLine(totalPlays);
                }
                else if (yearType == "normal")
                {
                    double totalPlays = Math.Floor(holidayPlays + normalPlays + numHome);
                    Console.WriteLine(totalPlays);
                }
            }
        }
    }
}
