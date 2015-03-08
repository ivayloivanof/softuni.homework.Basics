using System;

class DeckOfCards
{
    static void Main()
    {
        char[] suits = { '\u2663', '\u2666', '\u2665', '\u2660' };
        char[] faces = { 'J', 'Q', 'K', 'A' };

            for (int i = 2; i <= 10; i++)
            {
                foreach (var suit in suits)
                {
                    Console.Write("{0}{1} ", i, suit);
                }
                Console.WriteLine();
            }

            foreach (var face in faces)
            {
                foreach (var suit in suits)
                {
                    Console.Write("{0}{1} ", face, suit);
                }
                Console.WriteLine();
            }

    }
}

