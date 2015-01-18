using System;

class PrintLongSequence
{
	static void Main()
	{
		Console.WriteLine("The first 1000 members of sequence are: ");
		for (int i = 2; i <= 1000; i++)
		{

			if (i % 2 == 0)
			{
				Console.Write(i+"  ");
			}
			else
			{
				Console.Write(-i+"  ");
			}

		}
	}
}