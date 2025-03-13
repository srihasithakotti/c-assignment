using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a boolean value (true/false): ");
        bool input;
        while (!bool.TryParse(Console.ReadLine(), out input))
        {
            Console.Write("Invalid input! Please enter true or false: ");
        }
        
        Console.WriteLine("\nUsing WriteLine(Boolean) method:");
        Console.WriteLine(input);
    }
}