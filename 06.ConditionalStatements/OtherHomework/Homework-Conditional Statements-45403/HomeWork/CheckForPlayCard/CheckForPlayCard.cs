using System;

class CheckForPlayCard
{
    static void Main(string[] args)
    {
        String userInput = Console.ReadLine();
        int number;
        bool isItNumber = int.TryParse(userInput, out number);
        if (isItNumber == true)
        {
            if (number > 1 && number < 11)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
        else 
        {
            if (userInput == "J" || userInput == "Q" || userInput == "K" || userInput == "A")
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}