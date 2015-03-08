using System;

class Deck52Cards
{
    static void Main()
    {
        for (int i = 2; i <= 14; i++)
        {
            for (int suit = 1; suit <= 4; suit++)
            {
                if (i <= 10)
                {
                    Console.Write(i);
                }
                switch (i)
                {
                    case 11: Console.Write("J");break;
                    case 12: Console.Write("Q"); break;
                    case 13: Console.Write("K"); break;
                    case 14: Console.Write("A"); break;
                }
                switch (suit)
                {
                    case 1: Console.Write('\u2663'); break;
                    case 2: Console.Write('\u2666'); break;
                    case 3: Console.Write('\u2665'); break;
                    case 4: Console.WriteLine('\u2660'); break;
                }
            }
        }
    }
}

