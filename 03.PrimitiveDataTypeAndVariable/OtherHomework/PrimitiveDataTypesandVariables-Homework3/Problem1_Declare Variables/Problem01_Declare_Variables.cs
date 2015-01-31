using System;

namespace Problem01_Declare_Variables
{
    class Program
    {
        static void Main()
        {
            int RandomIntNum = 4825932;
            sbyte RandomSbNumber = -115;
            byte RandomBytehNumber = 97;
            short RandomShNumber = -10000;
            ushort RandomUshNumber = 52130;
            Console.WriteLine(RandomIntNum);
            Console.WriteLine("+");
            Console.WriteLine(RandomSbNumber);
            Console.WriteLine("+");
            Console.WriteLine(RandomShNumber);
            Console.WriteLine("+");
            Console.WriteLine(RandomBytehNumber);
            Console.WriteLine("+");
            Console.WriteLine(RandomUshNumber);
            Console.WriteLine("=");
            Console.WriteLine(RandomBytehNumber + RandomIntNum + RandomSbNumber + RandomShNumber + RandomUshNumber);
        }
    }
}
