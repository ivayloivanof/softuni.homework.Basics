using System;

class CheckPlayCard
{
    static void Main()
    {
        string cardSign = Console.ReadLine();
        if (cardSign == "A" || cardSign == "2"||cardSign=="3"||cardSign=="4"||cardSign=="5"||cardSign=="6"||cardSign == "7" 
            || cardSign == "8" || cardSign == "9"||cardSign=="10"||cardSign=="J"||cardSign=="Q"||cardSign == "K" )
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }

    }
}

