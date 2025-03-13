using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine().Replace(" ", ""); 
        
        char[] sortedChars = input.OrderBy(c => c).ToArray();
        
        Console.WriteLine("After sorting the string appears like: " + string.Join(" ", sortedChars));
    }
}