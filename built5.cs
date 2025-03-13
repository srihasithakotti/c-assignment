using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Enter first letter: ");
        char letter1 = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter second letter: ");
        char letter2 = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter third letter: ");
        char letter3 = Convert.ToChar(Console.ReadLine());

    
        Console.WriteLine("Output: " + letter3 + " " + letter2 + " " + letter1);
    }
}