using System;
class PrintTheAsciiTable
{
    static void Main()
    {
        int a = 1;
        int i;

        for (i = 0; i <= 250; i++)
        {
            Console.WriteLine(i + " = " + (char)i);
        }
        Console.ReadLine();
    }
}