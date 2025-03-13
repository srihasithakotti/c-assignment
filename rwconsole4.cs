using System;

class Program
{
    static void Main()
    {
        // Taking input for first name
        Console.Write("Enter first name: ");
        string firstName = Console.ReadLine();

        // Taking input for last name
        Console.Write("Enter last name: ");
        string lastName = Console.ReadLine();

        // Concatenating strings
        string result = "Hello " + firstName + " " + lastName;

        // Printing the output
        Console.WriteLine(result);
    }
}