using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableinHexaFormat
{
    class Program
    {
        static void Main()
        {
            int value = 254;
            string hexOutput = value.ToString("X");

            Console.WriteLine(hexOutput);
        }
    }
}
