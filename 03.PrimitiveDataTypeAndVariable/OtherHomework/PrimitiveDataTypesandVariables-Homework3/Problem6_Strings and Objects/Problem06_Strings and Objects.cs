using System;

namespace Problem06_StringsAndObjects
{
    class Program
    {
        static void Main()
        {
            string a = "Hello";
            string b = "World";
            object variable = a+" "+b;
            object c = variable;
            Console.WriteLine(c);
        }
    }
}
