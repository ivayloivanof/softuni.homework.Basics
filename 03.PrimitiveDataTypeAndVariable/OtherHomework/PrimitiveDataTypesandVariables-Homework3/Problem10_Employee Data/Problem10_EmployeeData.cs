using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10_EmployeeData
            //A marketing company wants to keep record of its employees. Each record would have the following characteristics:
                //  First name - string
                //  Last name - string
                //  Age (0...100) - byte
                //  Gender (m or f) - bool
                //  Personal ID number (e.g. 8,306,112,507) - ulong
                //  Unique employee number (27560000…27569999) - ulong
            //Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.
{
    class Program
    {
        static void Main()
        {
            string FirstName = "Ivo";
            string LastName = "Donev";
            byte Age = 40;
            bool Male = true;
            bool Female = false;
            ulong PersonalID = 85552283114042;
            ulong UniqueEN = 8555228222555444311;
            Console.WriteLine("First Name:            {0}", FirstName);
            Console.WriteLine("Last Name:             {0}", LastName);
            Console.WriteLine("Age:                   {0}", Age);
            Console.WriteLine("Genfer - Male:         {0}", Male);
            Console.WriteLine("Gender - Female:       {0}", Female);
            Console.WriteLine("Personal ID Number:    {0}", PersonalID);
            Console.WriteLine("Unique Emploee Number: {0}", UniqueEN);
            Console.ReadLine();
        }
    }
}
