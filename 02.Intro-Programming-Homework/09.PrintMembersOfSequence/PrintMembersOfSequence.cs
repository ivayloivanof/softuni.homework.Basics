using System;

class PrintMembersOfSequence
{
	static void Main()
	{
		Console.WriteLine("The first ten members of sequence are: ");
		for (int i = 2; i <= 11; i++)
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
        Console.ReadLine();
	}
}