using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11_BankAccountData
            //A bank account has a:

            //   - holder name (first name, middle name and last name) - string (3)
            //   - available amount of money (balance) - double
            //   - bank name - string
            //   - IBAN - string
            //   - 3 credit card numbers associated with the account - ulong

            //Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
{
    class Problem11_BankAccountData
    {
        static void Main()
        {
            string firstName = "Ivo";
            string middleName = "Antoniev";
            string lastName = "Donev";
            decimal accountBalance = 100000.00M;
            string bankName = "DSK Bank";
            string IBAN = "BG80 BNBG 9661 1020 3456 78";
            long creditCardVisa = 2658698726993697;
            long creditCardMaestro = 1523698745302456;
            long creditCardAE = 4896325789654856;
            Console.WriteLine("Firs Name:         {0}", firstName);
            Console.WriteLine("Middle Name:       {0}", middleName);
            Console.WriteLine("Lasr Name:         {0}", lastName);
            Console.WriteLine("Account Balance:   {0}", accountBalance);
            Console.WriteLine("Bank Name:         {0}", bankName);
            Console.WriteLine("IBAN:              {0}", IBAN);
            Console.WriteLine("VISA:              {0}", creditCardVisa);
            Console.WriteLine("Maestro:           {0}", creditCardMaestro);
            Console.WriteLine("American Express:  {0}", creditCardAE);
            Console.ReadLine();
        }
    }
}
