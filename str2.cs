using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        int length = 0;
        
        foreach (char c in input)
        {
            length++;
        }
        
        Console.WriteLine("Length of the string: " + length);
    }
}