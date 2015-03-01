using System;

class CompanyWithManager
    {
    static void Main()
        {
        //Declaring company's variables
        string companyName, address, phoneNumber, faxNumber, webSite;

        //Declaring manager's varables
        string firstName, lastName, age, managersPhone;

        //Entering the company's information
        Console.WriteLine("Company Information\n");
        Console.Write("Please enter the company's name: ");
        companyName = Console.ReadLine();
        Console.Write("Please enter the company's address: ");
        address = Console.ReadLine();
        Console.Write("Please enter the company's phone number: ");
        phoneNumber = Console.ReadLine();
        Console.Write("Please enter the company's fax number: ");
        faxNumber = Console.ReadLine();
        Console.Write("Please enter the company's Web Site address: ");
        webSite = Console.ReadLine();

        //Entering the managers information
        Console.WriteLine("\nManager Information\n");
        Console.Write("Please enter the manager's first name: ");
        firstName = Console.ReadLine();
        Console.Write("Please enter the maanger's last name: ");
        lastName = Console.ReadLine();
        Console.Write("Please enter the manager's age: ");
        age = Console.ReadLine();
        Console.Write("Please enter the manager's phone number: ");
        managersPhone = Console.ReadLine();

        // Printing the information

        Console.WriteLine("\nCompany name: " + companyName);
        Console.WriteLine("Company address: " + address);
        Console.WriteLine("Company phone number: " + phoneNumber);
        Console.WriteLine("Company fax number: " + faxNumber);
        Console.WriteLine("Company Web Site address: " + webSite);
        Console.WriteLine();
        Console.WriteLine("Manager first name: " + firstName);
        Console.WriteLine("Manager last name: " + lastName);
        Console.WriteLine("Manager age: " + age);
        Console.WriteLine("Manager phone number: " + managersPhone);
        }
    }

