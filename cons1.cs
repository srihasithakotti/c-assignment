using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an Int value: ");
        int intValue = Convert.ToInt32(Console.ReadLine());
        
        long longValue = intValue; 
        
        Console.WriteLine("Int value - " + intValue);
        Console.WriteLine("Long value - " + longValue);
    }
}