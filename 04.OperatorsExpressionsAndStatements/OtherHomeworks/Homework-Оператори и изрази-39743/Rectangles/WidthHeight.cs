using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles
{
    class WidthHeight
    {
        static void Main()
        {
            Console.WriteLine("Enter wight:  ");
            float width = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter height:  ");
            float height = float.Parse(Console.ReadLine());
            float perimeter = (width + width + height + height);
            Console.WriteLine("The perimeter is: " + perimeter);
            float area = (width * height);
            Console.WriteLine("The area is: " + area);
        }
    }
}
