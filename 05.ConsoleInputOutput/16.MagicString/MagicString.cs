using System;
using System.Collections.Generic;
class MagicString
{
    static void Main()
    {
        byte diff = byte.Parse(Console.ReadLine());

        int firstFourLetters;
        int secondFourLetters;

        byte[] numbers = { 3, 4, 1, 5 };
        byte[] temp = new byte[8];
        List<string> sequences = new List<string>();
        string stringTemp = "";
        for (byte i0 = 0; i0 < 4; i0++)
        {
            temp[0] = numbers[i0];
            for (byte i1 = 0; i1 < 4; i1++)
            {
                temp[1] = numbers[i1];
                for (byte i2 = 0; i2 < 4; i2++)
                {
                    temp[2] = numbers[i2];
                    for (byte i3 = 0; i3 < 4; i3++)
                    {
                        temp[3] = numbers[i3];
                        for (byte i4 = 0; i4 < 4; i4++)
                        {
 
                            if (temp[0] + temp[1] + temp[2] + temp[3] + diff <= 20)
                            {
                                // Първи случай
                            }
                            else if (temp[0] + temp[1] + temp[2] + temp[3] - diff >= 4)
                            {
                                // Втори случай
                            }
                                       
                        }
                    }
                }
            }
        }
        sequences.Sort();
        if (sequences.Count > 0)
        {
            for (byte j = 0; j < sequences.Count; j++) Console.WriteLine(sequences[j]);
        }
        else Console.WriteLine("No");
        Console.ReadLine();
    }
}