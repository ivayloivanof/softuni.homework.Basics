using System;

    class PrintCompanyInfo
    {
        static void Main()
        {
            Console.Write("Company name: ");
            string compName = Console.ReadLine();
            Console.Write("Company address: ");
            string compAddress = Console.ReadLine();
            Console.Write("Company phone number: ");
            int compPhoneNumb = int.Parse(Console.ReadLine());
            Console.Write("Company fax number: ");
            int compFaxNumb = int.Parse(Console.ReadLine());
            Console.Write("Company website: ");
            string website = Console.ReadLine();
            Console.Write("Manager first name: ");
            string manFirstName = Console.ReadLine();
            Console.Write("Manager last name: ");
            string manLastName = Console.ReadLine();
            Console.Write("Manager age: ");
            int manAge = int.Parse(Console.ReadLine());
            Console.Write("Manager phone number: ");
            int manPhoneNumb = int.Parse(Console.ReadLine());
            Console.WriteLine("-".PadRight(79, '-'));
            Console.WriteLine("{0} company addres:{1} phone:{2} fax:{3} website:{4}", compName, compAddress, compPhoneNumb, compFaxNumb, website);
            Console.WriteLine("-".PadRight(79, '-'));
            Console.WriteLine("Manager name:{0} {1} is {2} years old, phone:{3}", manFirstName, manLastName, manAge, manPhoneNumb);
        }
    }
