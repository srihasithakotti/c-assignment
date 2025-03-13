using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter value for a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter value for b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Addition Operator: " + (a + b));
        Console.WriteLine("Subtraction Operator: " + (a - b));
        Console.WriteLine("Multiplication Operator: " + (a * b));
        Console.WriteLine("Division Operator: " + (a / b));
        Console.WriteLine("Modulo Operator: " + (a % b));
    }
}