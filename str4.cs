using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string input = Console.ReadLine();
        
        Console.Write("Enter the word to replace: ");
        string oldWord = Console.ReadLine();
        
        Console.Write("Enter the new word: ");
        string newWord = Console.ReadLine();
        
        string updatedSentence = input.Replace(oldWord, newWord);
        
        Console.WriteLine("Sentence After Replacing: " + updatedSentence);
    }
}