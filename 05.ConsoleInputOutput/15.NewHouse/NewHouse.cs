using System;
class NewHouse
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        char dash = '\u2013';
        char astersisk = '\u002A';
        char pipe = '\u007C';

        int topRoofHeight = (numberN/2) + 1;
        int topLeftHeight = topRoofHeight -1;
        int topRightHeight = topRoofHeight + 1;
        int rowRoof = 1;
        int rowFloor = 1;
        //roof start
        for (rowRoof = 1; rowRoof <= numberN ; rowRoof+=2)
        {
            if (rowRoof == 1)
            {
                for (int i = 1; i <= numberN; i++)
                {
                    if (i == topRoofHeight)
                    {
                        Console.Write(astersisk);
                    }
                    else
                    {
                        Console.Write(dash);
                    }
                }
                
            }
            else if (rowRoof < numberN)
            {
                for (int i = 1; i <= numberN; i++)
                {
                    if (i >= topLeftHeight && i <= topRightHeight)
                    {
                        Console.Write(astersisk);
                    }
                    else
                    {
                        Console.Write(dash);
                    }
                }
                topLeftHeight--;
                topRightHeight++;
            }
            else
            {
                for (int i = 1; i <= numberN; i++)
                {
                    Console.Write(astersisk);
                }
            }
            Console.WriteLine();
        }
        //roof end

        //start floor
        for (rowFloor = 1; rowFloor <= numberN; rowFloor++)
        {
            Console.Write(pipe);
            for (int i = 1; i <= (numberN-2); i++)
                {
                    Console.Write(astersisk);
                }
            Console.WriteLine(pipe);
        }
        //end floor
        Console.ReadLine();
    }
}