using System;

class AgeNowAndAgeAfterTenYears
{
    public static void Main()
    {
		//string age = Console.ReadLine();
        //Console.WriteLine("years = " + age);

		Console.WriteLine("Enter your birth date:");
		Console.Write ("Year: ");
		int year = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("--------------------------");
		Console.Write ("Month: ");
		byte month = Convert.ToByte(Console.ReadLine ());
		Console.WriteLine("--------------------------");
		Console.Write ("Day: ");
		byte day = Convert.ToByte(Console.ReadLine ());

		// birth day
		DateTime birthDay = new DateTime(year, month, day);

		int age = (int)((DateTime.Now - birthDay).TotalDays / 365.242199);
		//print old
		Console.WriteLine("Years : " + age);
		//print old after 10 years
		Console.WriteLine("Age after 10 years will be: " + (age + 10));
        Console.ReadLine();
    }
}