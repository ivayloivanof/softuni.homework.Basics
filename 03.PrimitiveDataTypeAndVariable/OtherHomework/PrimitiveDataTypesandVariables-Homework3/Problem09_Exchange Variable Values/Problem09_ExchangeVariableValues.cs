using System;

namespace Problem09_ExchangeVariableValues
{
    //Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic. 
    //Print the variable values before and after the exchange.
    class Program
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Variables a and b have the folowing values: \n \t a={0}; \n \t b={1};", a, b);
            Console.WriteLine("Exchanging Variables a and b to: \n \t a={0}; \n \t b={1};", a = 20, b = 40);
            Console.ReadLine();
        }

    }
}
