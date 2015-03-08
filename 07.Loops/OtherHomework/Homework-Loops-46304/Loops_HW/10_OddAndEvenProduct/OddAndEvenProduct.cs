
using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.Write("Enter some number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter {0} numbers, separted by space:", n);
        string ns = Console.ReadLine();
        string [] numbers = ns.Split(' ');
        int oddProduct = 1;
        int evenProduct = 1;

        int newOdd;
        int newEven;

        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0)
            {
                int.TryParse(numbers[i], out newOdd);
                oddProduct = oddProduct * newOdd;
            }
            else
            {
                int.TryParse(numbers[i], out newEven);
                evenProduct = newEven * evenProduct;
            }
        }


        if (evenProduct == oddProduct) 
        {
            Console.WriteLine("yes\nproduct = {0}", evenProduct);
        }

        else
        {
            Console.WriteLine("no");
            
            Console.WriteLine("odd_product = {0}", oddProduct);
            Console.WriteLine("even_product = {0}", evenProduct);
        }

    }
}

