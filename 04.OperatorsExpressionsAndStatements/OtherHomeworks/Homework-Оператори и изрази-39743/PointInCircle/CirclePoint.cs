using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInCircle
{
    class CirclePoint
    {
        public static bool PointInCircle(float centerX, float centerY, float radius, float pointX, float pointY)
        {
            return Math.Pow((pointX - centerX), 2) + Math.Pow((pointY - centerY), 2) < Math.Pow(radius, 2); 
        }

        static void Main()
        {
            Console.WriteLine("Enter x: ");
            float firstX = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter y: ");
            float firstY = float.Parse(Console.ReadLine());
            Console.WriteLine(PointInCircle(0, 0, 2, firstX, firstY));
        }
    }
}
