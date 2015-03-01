using System;


    class BonusScore
    {
        static void Main()
        {
            Console.WriteLine("Input number between 1 and 9:");
            int score = int.Parse(Console.ReadLine());

            if (score >= 1 && score <= 3)
            {
                Console.WriteLine(score * 10);
            }
            else if (score >= 4 && score <= 6)
            {
                Console.WriteLine(score * 100);
            }
            else if (score >= 7 && score <= 9)
            {
                Console.WriteLine(score * 1000);
            }
            else
            {
                Console.WriteLine("Don't cheat, the input is invalid!");
            }
        }
    }

