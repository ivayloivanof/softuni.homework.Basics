using System;
using System.Collections.Generic;
using System.Linq;

class ZeroSubset
{
    static void Main(string[] args)
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());
        int fourthNumber = int.Parse(Console.ReadLine());
        int fifthNumber = int.Parse(Console.ReadLine());

        List<int> numbers = new List<int>();
        List<string> numbersPrint = new List<string>();
        numbers.Add(firstNumber);
        numbers.Add(secondNumber);
        numbers.Add(thirdNumber);
        numbers.Add(fourthNumber);
        numbers.Add(fifthNumber);

        for (int i = 0; i < numbers.Count; i++)
        {
            for (int b = i+1; b < numbers.Count; b++)
            {
                int result = numbers[i] + numbers[b];
                if (result == 0)
                {
                    string tempString = numbers[i].ToString() + " + " + numbers[b].ToString() + " = 0";
                    numbersPrint.Add(tempString);
                }

                for (int a = b + 1; a < numbers.Count; a++)
                {
                    int resultThree = numbers[i] + numbers[b] + numbers[a];
                    if (resultThree == 0)
                    {
                        string tempString = numbers[i].ToString() + " + " + numbers[b].ToString() + " + " + numbers[a].ToString() + " = 0";
                        numbersPrint.Add(tempString);
                    }
                    for (int d = a + 1; d < numbers.Count; d++)
                    {
                        int resultFour = numbers[i] + numbers[b] + numbers[a] + numbers[d];
                        if (resultFour == 0)
                        {
                            string tempString = numbers[i].ToString() + " + " + numbers[b].ToString() + " + " + numbers[a].ToString() + " + " + numbers[d].ToString() + " = 0";
                            numbersPrint.Add(tempString);
                        }
                    }
                }
            }
        }
        if (numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4] == 0)
        {
            String temp = numbers[0].ToString() + " + " + numbers[1].ToString() + " + " + numbers[2].ToString() + " + " + numbers[3].ToString() + " + " + numbers[4].ToString() + " = 0";
            numbersPrint.Add(temp);
        }
        List<string> onlyUnique = numbersPrint.Distinct().ToList();
        if (onlyUnique.Count == 0)
        {
            Console.WriteLine("no zero subset");
        }
        else
        {
            foreach (var item in onlyUnique)
            {
                Console.WriteLine(item);
            }
        }
    }
}