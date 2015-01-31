using System;

//Declare two string variables and assign them with “Hello” and “World”. 
//Declare an object variable and assign it with the concatenation of the first two variables 
//(mind adding an interval between). Declare a third string variable and initialize it with the value of the object variable 
//(you should perform type casting).


class Program
{
    static void Main()
    {
        string hello = "Hello";
        Console.WriteLine(hello);
        string world = "World";
        Console.WriteLine(world);
        object helloWorld = hello + " " + world;
        Console.WriteLine(helloWorld);
        string sentence = (string)helloWorld;
        Console.WriteLine(sentence);


    }
}

