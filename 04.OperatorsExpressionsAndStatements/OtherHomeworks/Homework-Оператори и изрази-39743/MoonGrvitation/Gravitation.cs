using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonGrvitation
{
    class Gravitation
    {
        static void Main()
        {
            Console.WriteLine("Your weight on the Earth:   ");
            float weight = float.Parse(Console.ReadLine());
            double WeightOnTheMoon = (weight * 0.17);
            Console.WriteLine(WeightOnTheMoon);
                        
        }
    }
}
