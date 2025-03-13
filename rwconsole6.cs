using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        
        char[] passwordChars = password.ToCharArray();


        string passwordString = new string(passwordChars);

        Console.WriteLine("Password: " + passwordString);
    }
}