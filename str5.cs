using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the String in Uppercase: ");
        string input = Console.ReadLine();
        
        string lowerCaseString = input.ToLower();
        
        Console.WriteLine("String in Lowercase: " + lowerCaseString);
    }
}