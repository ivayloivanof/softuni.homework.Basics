using System;


class Program
{
    static void Main(string[] args)
    {
        //A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
        //    bank name, IBAN, 3 credit card numbers associated with the account. Declare the variables needed to keep the 
        //        information for a single bank account using the appropriate data types and descriptive names.

        Console.WriteLine("Enter your full name(first name/enter, middle name/enter and last name/enter");
        string firstName = (Console.ReadLine());
        string middleName = (Console.ReadLine());
        string lastName = (Console.ReadLine());
        string iban = "BG32 UBBS 7827 1013 6179 05";
        string bank = "First Investment Bank";
        Console.WriteLine("Hello {0} {1} {2} in {3}(BankIban: {4}", firstName, middleName, lastName, bank, iban);
        decimal ballance = -0.00000000000001m;
        long cardNumber1 = 123456789123509;
        long cardNumber2 = 908765432123456;
        long cardNumber3 = 574836123456789;
        Console.WriteLine("You have tree credit cards: \n{0}\n{1}\n{2}", cardNumber1, cardNumber2, cardNumber3);
        Console.WriteLine("Your ballance is: {0}", ballance);
        Console.WriteLine("Have a nace day! :)");
    }
}

