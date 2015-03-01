using System;

class SortThree
{
    static void Main()
    {
        Console.WriteLine("Input three real numbers:");
        double firstNum = double.Parse(Console.ReadLine());
		double secondNum = double.Parse(Console.ReadLine());
		double thirdNum = double.Parse(Console.ReadLine());      
		
        if(firstNum != secondNum || firstNum != thirdNum || secondNum != thirdNum)
			{
				if (firstNum >= secondNum)
				{
					if(secondNum >= thirdNum)
					{
						Console.WriteLine(firstNum, secondNum, thirdNum);
					}
					else if(thirdNum >= firstNum)
					{
						Console.WriteLine(thirdNum, firstNum, secondNum);
					}
					else
					{
						Console.WriteLine(firstNum, thirdNum, secondNum);
					}
				}
				else if(secondNum >= thirdNum)
				{
					if(thirdNum >= firstNum)
					{
						Console.WriteLine(secondNum, thirdNum, firstNum);
					}
					else
					{
						Console.WriteLine(secondNum, firstNum, thirdNum);
					}
				}
				else
				{
					Console.WriteLine(thirdNum, secondNum, firstNum);
				}	
			}
		
		else
		{
			Console.WriteLine(firstNum, secondNum, thirdNum)
		}
    }
}