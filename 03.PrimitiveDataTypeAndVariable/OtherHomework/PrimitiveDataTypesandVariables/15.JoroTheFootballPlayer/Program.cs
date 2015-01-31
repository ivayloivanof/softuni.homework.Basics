using System;

class Program
{
    static void Main(string[] args)
    {
        string year = (Console.ReadLine());
        int hollidays = int.Parse(Console.ReadLine());
        int hometown = int.Parse(Console.ReadLine());
        

        int playngDays = hometown + ((52 - hometown) * 2 / 3) + (hollidays / 2);  
        
            
        if (year == "t")
        {
            playngDays += 3;
        }

        Console.WriteLine(playngDays);

    }
}

