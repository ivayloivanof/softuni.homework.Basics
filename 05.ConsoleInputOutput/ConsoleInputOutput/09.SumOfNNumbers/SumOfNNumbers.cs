using System;
    class SumOfNNumbers
    {
        static void Main()
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                int i;
                double sumNum = 0;
                for (i = 1; i<=n; i++)
                {
                    double k = double.Parse(Console.ReadLine());
                    sumNum += k;
                }
                Console.WriteLine(sumNum);
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("This is not number!");
                Console.ReadLine();
            }
        }
    }