using System;

public class PrintADeckOf52Cards
{
    public static void Main()
    {
        char[] suits = { '\u2663', '\u2666', '\u2665', '\u2660' };
        char[] highestRankings = { 'J', 'Q', 'K', 'A' };

        for (int i = 2; i < 11; i++)
        {
            for (int j = 0; j < suits.Length; j++)
            {
                
            Console.Write("{0}{1} ", i, suits[j]);
            }

            Console.WriteLine();
        }

        for (int i = 0; i < highestRankings.Length; i++)
        {
            for (int j = 0; j < suits.Length; j++)
            {
                Console.Write("{0}{1} ", highestRankings[i], suits[j]);
            }

            Console.WriteLine();
        }
    }
}