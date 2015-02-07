using System;
    class PrintCompanyInformation
    {
        static void Main()
        {
            string companyNameProgram = "Company name:";
            string companyNameUser = "Software University";
            string companyAddressProgram = "Company address:";
            string companyAddressUser = "26 V. Kanchev, Sofia";
            string phoneNumberProgram = "Phone number:";
            string phoneNumberUser = "+359 899 55 55 92";
            string faxNumberProgram = "Fax number:";
            string faxNumberUser = "";
            string webSiteProgram = "Web site:";
            string webSiteUser = "http://softuni.bg";
            string managerFirstNameProgram = "Manager first name:";
            string managerFirstNameUser = "Svetlin";
            string managerLastNameProgram = "Manager last name:";
            string managerLastNameUser = "Nakov";
            string managerAgeProgram = "Manager age:";
            string managerAgeUser = "25";
            string managerPhoneProgram = "Manager phone:";
            string managerPhoneUser = "+359 2 981 981";
            
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("|            {0,-19}|           {1,-15}|", "program", "user");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("| {0,-30}| {1,-25}|", companyNameProgram, companyNameUser);
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("| {0,-30}| {1,-25}|", companyAddressProgram, companyAddressUser);
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("| {0,-30}| {1,-25}|", phoneNumberProgram, phoneNumberUser);
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("| {0,-30}| {1,-25}|", faxNumberProgram, faxNumberUser);
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("| {0,-30}| {1,-25}|", webSiteProgram, webSiteUser);
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("| {0,-30}| {1,-25}|", managerFirstNameProgram, managerFirstNameUser);
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("| {0,-30}| {1,-25}|", managerLastNameProgram, managerLastNameUser);
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("| {0,-30}| {1,-25}|", managerAgeProgram, managerAgeUser);
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("| {0,-30}| {1,-25}|", managerPhoneProgram, managerPhoneUser);
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("| {0,-30}| {1,-25}|", companyNameUser, "");
            Console.WriteLine("| Address {0,-22}| {1,-25}|", companyAddressUser, "");
            Console.WriteLine("| Tel. {0,-25}| {1,-25}|", phoneNumberUser, "");
            Console.WriteLine("| Fax: (no fax) {0,-16}| {1,-25}|", "", "");
            Console.WriteLine("| Web site: {0,-20}| {1,-25}|", webSiteUser, "");
            Console.WriteLine("| Manager: {0,-14} (age: | {1,-25}|", (managerFirstNameUser + " " + managerLastNameUser), "");
            Console.WriteLine("| {0} tel. {1,-22}| {2,-25}|", managerAgeUser, managerPhoneUser,"");
            Console.WriteLine("------------------------------------------------------------");
            Console.ReadLine();
        }
    }