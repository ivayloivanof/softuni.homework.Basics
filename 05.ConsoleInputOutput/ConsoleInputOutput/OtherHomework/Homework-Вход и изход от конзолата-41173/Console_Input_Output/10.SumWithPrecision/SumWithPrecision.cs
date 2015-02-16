using System;

class SumWithPrecision
    {
    static void Main()
        {
        double oldSum = 1, newSum = 0;
        double divisor = 2;
        do
            {
            oldSum = newSum;
            if (divisor % 2 == 0)
                {
                newSum = oldSum + (1 / divisor);
                }
            else
                {
                newSum = oldSum - (1 / divisor);
                }
            divisor++;
            }
        while (!((newSum - oldSum) < 0.001));
        Console.WriteLine("{0:f3}", newSum);
        }
    }

