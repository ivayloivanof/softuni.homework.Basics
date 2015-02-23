using System;
class MagicDates
{
    static void Main()
    {
        Console.Write("Start year: ");
        short startYear = short.Parse(Console.ReadLine());
        Console.Write("End year: ");
        short endYear = short.Parse(Console.ReadLine());
        Console.Write("Magic Weight: ");
        short magicWeight = short.Parse(Console.ReadLine());
        bool noMagic = false;
        
        for (short yearN = startYear; yearN <= endYear; yearN++)
        {
            for (byte i = 1; i <= 12; i++)
            {
                if (i == 1 || i == 3 || i ==5 || i == 7 || i == 8 || i == 10 || i == 12)
                {
                    for (int j = 1; j <= 31; j++)
                    {
                        string day = j.ToString();
                        string month = i.ToString();
                        string year = yearN.ToString();

                        if (j < 10)
                        {
                            day = string.Format("0{0}", day);
                        }

                        if (i < 10)
                        {
                            month = string.Format("0{0}", month);
                        }


                        string date = string.Format("{0}{1}{2}", day, month, yearN);
                        
                        Console.WriteLine(date[0]*date[1]);
                        
                        Console.WriteLine("{0}-{1}-{2}", day, month, yearN);
                        
                        //01234567
                        //
                        //17032007
                        //1*7 + 1*0 + 1*3 + 1*2 + 1*0 + 1*0 + 1*7 + 
                        //7*0 + 7*3 + 7*2 + 7*0 + 7*0 + 7*7 + 
                        //0*3 + 0*2 + 0*0 + 0*0 + 0*7 + 
                        //3*2 + 3*0 + 3*0 + 3*7 + 
                        //2*0 + 2*0 + 2*7 + 
                        //0*0 + 0*7 + 0*7
                    }
                }
                else if (i == 4 || i == 6 || i == 9 || i == 11)
                {
                    for (int j = 1; j <= 30; j++)
                    {
                    
                    }
                } else if (DateTime.IsLeapYear(yearN) && i == 2)
                {
                    for (int j = 1; j <= 29; j++)
                    {
                    
                    }
                }
                else
                {
                    for (int j = 1; j <= 28; j++)
                    {
                    
                    }
                }
                
            }
        }
        if (noMagic)
        {
            Console.WriteLine("No");
        }
        Console.ReadLine();
    }
}
