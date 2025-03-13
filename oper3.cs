using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter value for a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter value for b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Equal to Operator: " + (a == b));
        Console.WriteLine("Greater than Operator: " + (a > b));
        Console.WriteLine("Less than Operator: " + (a < b));
        Console.WriteLine("Greater than or Equal to: " + (a >= b));
        Console.WriteLine("Lesser than or Equal to: " + (a <= b));
        Console.WriteLine("Not Equal to Operator: " + (a != b));
    }
}