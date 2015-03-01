using System;
class PrintADeckOf52Cards
{
    static void Main()
    {
        char spade = '♠';
        char heart = '♥';
        char diamond = '♦';
        char club = '♣';
        string card = "";

        for (int i = 2; i <= 14; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                switch (i)
                {
                    case 11: card =  "J"; break;
                    case 12: card =  "D"; break;
                    case 13: card =  "K"; break;
                    case 14: card =  "A"; break;
                    default: card = Convert.ToString(i); break;
                }

                Console.Write("{0}{1} ", card, club);
                Console.Write("{0}{1} ", card, diamond);
                Console.Write("{0}{1} ", card, heart);
                Console.Write("{0}{1} ", card, spade);
                Console.WriteLine();
            }
        }
    }
}
