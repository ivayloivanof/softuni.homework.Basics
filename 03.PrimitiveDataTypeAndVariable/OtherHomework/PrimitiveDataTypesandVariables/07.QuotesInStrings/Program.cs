﻿using System;

class Program
{
    static void Main()
    {
     //Declare two string variables and assign them with following value:
     //The "use" of quotations causes difficulties.	 
     //Do the above in two different ways: with and without using quoted strings. 
     //Print the variables to ensure that their value was correctly defined.

        string firtSec = "The \"use\" of quotations causes difficulties.";
        string secondSec = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine(firtSec);
        Console.WriteLine(secondSec);

    }
}

