//Michael Armstrong
//Beginning

using System;

class addition
{
    static void Main()
    {
        // Example of 2 inputs that display an output
        int number1;
        int number2;
        int sum;

        Console.Write("Enter first integer here: ");
        number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter Second integer here: ");
        number2 = int.Parse(Console.ReadLine());

        sum = number1 + number2;

        Console.WriteLine($"Sum is {sum}");

        // 3 Variables xyz 
        int x = 10;
        int y = 3;
        int z = 6;
        int sum2 = (x + y) * (z + 10);
        Console.WriteLine("(x + y) * (z + 10) = " + sum2 + "");

        //Messages eEscape Sequences
        Console.WriteLine("Hello\tWorld!");
        Console.WriteLine("Hello\nWorld!");
        Console.WriteLine("\"Hello World!\"");
        Console.WriteLine("Hello\\World!");


    }
}