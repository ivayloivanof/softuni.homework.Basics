using System;

public class MatrixOfNumbers
{
    public static void Main()
    {
        int userInput = int.Parse(Console.ReadLine());
        int index = 1;

        for (int i = 0; i < userInput; i++)
        {
            int counter = index;

            for (int j = 0; j < userInput; j++)
            {
                Console.Write("{0} ", counter++);
            }
            index++;

            Console.WriteLine();
        }
    }
}