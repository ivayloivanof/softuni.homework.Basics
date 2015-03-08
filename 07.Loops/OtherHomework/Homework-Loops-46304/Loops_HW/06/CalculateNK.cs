using System;

    class CalculateNK
    {
        static void Main()
        {
            Console.WriteLine("Enter n and k, where 1<k<n<100: ");
            int n= int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int nFaktorial = 1;
            int kFaktorial = 1;

            for (int i=1, j=1; i<=n; i++, j++)
            {
                nFaktorial *= i;
                if (j <= k)
                {
                    kFaktorial *= j;
                }
            }

            Console.WriteLine("n!/k! = {0}", nFaktorial / kFaktorial);
        }
    }

