using System;
class SumOfElements
{
    static void Main()
    {
        string numberAllSequence = Console.ReadLine();
        string[] numberSplitSequence = numberAllSequence.Split(' ');
        int number = 0;
        int numberBig = 0;
        int numberSequence = 0;
	    foreach (string num in numberSplitSequence)
	    {
	        number = int.Parse(num);
	        if (number > numberBig)
	        {
	            numberBig = number;
	        }
	    }
        foreach (string num in numberSplitSequence)
        {
            number = int.Parse(num);
            if (number != numberBig)
            {
                numberSequence += number;
            }
        }
        if (numberSequence == numberBig)
        {
            Console.WriteLine("Yes, sum={0}" , numberSequence);
        }
        else if (numberSequence > numberBig)
        {
            Console.WriteLine("No, diff={0}" , (numberSequence - numberBig));
        }
        else if (numberSequence < numberBig)
        {
            Console.WriteLine("No, diff={0}" , (numberBig - numberSequence));
        }
	    Console.ReadLine();
    }
}