using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine().Replace(" ", ""); 
        
        var maxChar = input.GroupBy(c => c)
                           .OrderByDescending(g => g.Count())
                           .First();
        
        Console.WriteLine($"The highest frequency of the character '{maxChar.Key}' appears {maxChar.Count()} time(s)");
    }
}