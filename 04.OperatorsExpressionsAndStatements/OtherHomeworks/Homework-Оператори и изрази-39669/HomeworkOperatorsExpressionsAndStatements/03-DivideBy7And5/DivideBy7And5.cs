﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DivideBy7And5
{
    class DivideBy7And5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer");
            int number = int.Parse(Console.ReadLine());
            bool result = number % 5 == 0 && number % 7 == 0 && number!=0;
            Console.WriteLine(result);
        }
    }
}
