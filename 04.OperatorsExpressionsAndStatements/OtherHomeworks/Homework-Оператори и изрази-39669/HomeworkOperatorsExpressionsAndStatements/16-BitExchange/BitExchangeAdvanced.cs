using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_BitExchange
{
    class BitExchangeAdvanced
    {
        static void Main(string[] args)
        {
            uint maskDigits=0;
            
            uint number = uint.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < k; i++)
            {
                maskDigits = maskDigits << 1 | 1;
            }
            uint firstbits = (number >> p) & maskDigits;
            uint sekondtbits = (number >> q) & maskDigits;

            uint firstMask = maskDigits << p;
            uint secondMask = maskDigits << q;
             number = number & ~firstMask |sekondtbits<<p;
             number = number & ~secondMask | firstbits << q;

             if (k+p>=q||k+q>=p)
             {
                 Console.WriteLine("overlapping");
             }
             else if(k+p>32||k+q>32||p<0||q<0||k>32)
             {
                 Console.WriteLine("out of range");
             }
             else
             {
                 Console.WriteLine(number);
             }
          
            
        }
    }
}
