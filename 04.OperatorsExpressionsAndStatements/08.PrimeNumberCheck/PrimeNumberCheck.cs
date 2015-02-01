using System;
class PrimeNumberCheck
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        
        int primeCount = 0;

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                primeCount++;
            }
        }

        bool isPrime = true;

        if (primeCount > 2 || number <= 1)
        {
            isPrime = false;
        }

        Console.WriteLine("This number is prime = " + isPrime);
        Console.ReadLine();
    }
}