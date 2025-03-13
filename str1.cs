using System;

class Program
{
    static void Main()
    {
        // Taking string input
        Console.Write("Enter a String: ");
        string input = Console.ReadLine();

        // Reversing the string manually
        string reversed = "";
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed += input[i];
        }

        // Printing the reversed string
        Console.WriteLine("Reverse String is: " + reversed);
    }
}