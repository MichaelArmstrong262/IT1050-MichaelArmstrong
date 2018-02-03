//Hello Wrold
// Text-Displaying app.
using System;

class Hello1
{
    // Main method begins execution of C# app
    static void Main()
    {
        string s1 = "Hello world from ";
        string s2 = "Michael Armstrong!";

        s1 += s2;
        System.Console.WriteLine(s1);
        Console.WriteLine("Did I do the extra credit assignment correctly?");
        Console.WriteLine("Press Any Key to exit this application");
        Console.ReadKey();
    } // end Main
} //end class Hello1
