using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        int length = input.Count();
        
        Console.WriteLine("The Length of the String is: " + length);
    }
}