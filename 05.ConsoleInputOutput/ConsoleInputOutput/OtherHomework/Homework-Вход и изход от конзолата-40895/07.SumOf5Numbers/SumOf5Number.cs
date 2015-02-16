using System;

class SumOf5Numbers
{  
    static void Main()
    {
        Console.Write("Enter Five numbers with space between them : ");
        string numberLine = Console.ReadLine();
        string[] strNumber = numberLine.Split(' ');
        decimal result = 0;

        for (int i = 0; i < strNumber.Length; i++)
        {
           result += Convert.ToDecimal(strNumber[i]);
        }

        Console.WriteLine("The sum of numbers is : {0} ", result);
		
     }
}