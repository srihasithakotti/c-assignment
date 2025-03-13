using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Value of I: ");
        double doubleValue = Convert.ToDouble(Console.ReadLine());
        
        int intValue = (int)doubleValue; 
        
        Console.WriteLine("Value of I is " + intValue);
    }
}