using System;

public class OddAndEvenProduct
{
    public static void Main()
    {
        string[] userInput = Console.ReadLine().Split(' ');
        int[] values = Array.ConvertAll(userInput, int.Parse);
        int oddProduct = 1;
        int evenProduct = 1;

        for (int i = 0; i < values.Length; i++)
        {
            if (i % 2 == 0)
            {
                oddProduct *= values[i];
            }
            else
            {
                evenProduct *= values[i];
            }
        }

        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes\nproduct = " + oddProduct);
        }
        else
        {
            Console.WriteLine("no\nodd_product = {0}\neven_product = {1}", oddProduct, evenProduct);
        }
    }
}