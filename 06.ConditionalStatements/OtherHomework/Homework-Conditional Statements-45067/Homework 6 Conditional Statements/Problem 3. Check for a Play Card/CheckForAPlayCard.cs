using System;



    class CheckForAPlayCard
    {
        static void Main()
        {
            
            //MUCH! MUCH faster way!
            /* --->>
            Console.WriteLine("Input card's symbol or number:");

            string deck = "2 3 4 5 6 7 8 9 10 J Q K A";

            string card = (Console.ReadLine());

            if (deck.Contains(card))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            */
            //Using only "if"s --->>

            Console.WriteLine("Input card's symbol or number:");

            string card = (Console.ReadLine());

            //Using 'if' - 'else' if to avoid checking all 13 card faces in the first 'if'

            if(card == "2")
            {
                Console.WriteLine("Yes");
            }
            else if (card == "3")
            {
                Console.WriteLine("Yes");
            }
            else if (card == "4")
            {
                Console.WriteLine("Yes");
            }
            else if (card == "5")
            {
                Console.WriteLine("Yes");
            }
            else if (card == "6")
            {
                Console.WriteLine("Yes");
            }
            else if (card == "7")
            {
                Console.WriteLine("Yes");
            }
            else if (card == "8")
            {
                Console.WriteLine("Yes");
            }
            else if (card == "9")
            {
                Console.WriteLine("Yes");
            }
            else if (card == "10")
            {
                Console.WriteLine("Yes");
            }
            else if (card == "J")
            {
                Console.WriteLine("Yes");
            }
            else if (card == "Q")
            {
                Console.WriteLine("Yes");
            }
            else if (card == "K")
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }


        }
    }

