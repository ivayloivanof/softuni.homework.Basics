using System;
class NumbersIntervalDividableGivenNumber
{
    static void Main()
    {
        try
        {
            Console.Write("Insert start number: ");
            int startNum = int.Parse(Console.ReadLine());
            Console.Write("Insert end number: ");
            int endNum = int.Parse(Console.ReadLine());
            if (startNum > 0 && endNum > 0)
            {
                int i;
                int existP = 0;
                for (i = startNum; i <= endNum; i++)
                {
                    int p = i%5;
                    if (p == 0)
                    {
                        existP += 1;
                    }
                }
                Console.WriteLine(existP);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Can be used only positive integers!");
                Console.ReadLine();
            }
            
        }
        catch (FormatException)
        {
            Console.WriteLine("This is not integer number");
            Console.ReadLine();
        }
    }
}