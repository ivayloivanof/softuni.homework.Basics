using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DividedWith5And7
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter figure: ");
            float figure = float.Parse(Console.ReadLine());
            bool isDivided = (figure % 5 == 0) && (figure % 7 == 0);
            Console.WriteLine(isDivided);

        }
    }
}
