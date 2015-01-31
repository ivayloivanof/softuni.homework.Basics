using System;

namespace Problem07_QuotesInStrings
{
    class Program
    {
        static void Main()
        {
            string a = "The \"use\" of quotations causes difficulties.";
            string b = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(a +"\n"+b);
        }
    }
}
