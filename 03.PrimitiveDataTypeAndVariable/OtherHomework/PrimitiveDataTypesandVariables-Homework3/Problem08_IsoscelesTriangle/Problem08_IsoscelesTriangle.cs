using System;
using System.Text;

namespace Problem08_IsoscelesTriangle
{
    class Program
    {
        static void Main()
        //Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
        //   ©
        //  © ©
        // ©   ©
        //© © © ©
        //Note that the © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8 and assign a Unicode-friendly font in the console. Note also, that under old versions of Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.
        {
            Console.OutputEncoding = Encoding.UTF8;
            char copyrigtSign = '\u00A9';
            Console.WriteLine("{0,4}\n{0,3}{0,2}\n{0,2}{0,4}\n{0}{0,2}{0,2}{0,2}", copyrigtSign);
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("   \u00A9");
            Console.WriteLine("  \u00A9 \u00A9");
            Console.WriteLine(" \u00A9   \u00A9");
            Console.WriteLine("\u00A9 \u00A9 \u00A9 \u00A9");
            Console.ReadLine();
        }
    }
}
