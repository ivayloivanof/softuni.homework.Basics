using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Write Company name : ");
        string companyName = Console.ReadLine();
       
        Console.Write("Write Company address: ");
        string companyAddress = Console.ReadLine();
        
        Console.Write("Write Phone number : ");
        string phoneNumber = Console.ReadLine();
       
        Console.Write("Write Fax number: ");
        string faxNumber = Console.ReadLine();
       
        Console.Write("Write Web site: ");
        string webSite = Console.ReadLine();
        
        Console.Write("Write Manager first name : ");
        string managerFirstName = Console.ReadLine();
        
        Console.Write("Write Manager last name: ");
        string managerLastName = Console.ReadLine();
       
        Console.Write("Write Manager age: ");
        string managerAge = Console.ReadLine();
        
        Console.Write("Write Manager phone: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine("{0}",companyName);
        Console.WriteLine("Address: {0}",companyAddress);
        Console.WriteLine("Tel. {0}",phoneNumber);
        if (faxNumber == "")
        {
            Console.WriteLine("Fax : (no fax) ");
        }
        else Console.WriteLine("Fax : {0}", faxNumber);
        Console.WriteLine("Web site : {0}", webSite);
        Console.WriteLine("Manager: {0} {1} (age:{2}, tel.{3})",managerFirstName,managerLastName,managerAge,managerPhone);
    }
}

