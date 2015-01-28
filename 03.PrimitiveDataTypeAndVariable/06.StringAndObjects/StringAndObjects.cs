using System;
class StringAndObjects
{
    static void Main()
    {
        string hallo = "Hallo";
        string world = "World";
        object concatenationHelloWorld = hallo + " " + world;
        string halloWorld = (string)concatenationHelloWorld;
    }
}