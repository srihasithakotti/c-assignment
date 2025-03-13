using System;

class Program
{
    static void Main()
    {
    
        Console.Write("Enter a symbol: ");
        char input = Convert.ToChar(Console.ReadLine());
        
        if ("aeiou".Contains(input))  
        {
            Console.WriteLine("It is a lowercase vowel.");
        }
        else if (char.IsDigit(input)) 
        {
            Console.WriteLine("It is a digit.");
        }
        else 
        {
            Console.WriteLine("It is another symbol.");
        }
    }
}