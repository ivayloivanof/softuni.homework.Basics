﻿using System;

    public class RandomNumbersInGivenRange
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            Random randomNumber = new Random();

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", randomNumber.Next(min, max + 1));
            }
            Console.WriteLine();
        }
    }