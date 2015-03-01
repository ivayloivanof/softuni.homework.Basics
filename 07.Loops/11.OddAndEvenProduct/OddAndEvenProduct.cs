using System;
class OddAndEvenProduct
{
    static void Main()
    {
        Console.Write("Input numbers separated by a space: ");
        string n = Console.ReadLine();
        string[] numbers = n.Split(' ');
        int num = 0;
        int odd = 1;
        int even = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            num = Convert.ToInt32(numbers[i]);
            if (i%2 == 0 || i == 0)
            {
                even *= num;
            }
            else
            {
                odd *= num;
            }
        }
        if (odd == even)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}", even);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = {0}", odd);
            Console.WriteLine("even_product = {0}", even);
        }
    }
}