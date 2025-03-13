using System;

class Calculator
{
    // Method to sum two numbers
    public int Sum(int a, int b)
    {
        return a + b;
    }

    // Method to sum three numbers
    public int Sum(int a, int b, int c)
    {
        return a + b + c;
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();
        
        // Calling Sum method with different parameters
        Console.WriteLine("Sum of 5 and 10: " + calc.Sum(5, 10));
        Console.WriteLine("Sum of 5, 10, and 15: " + calc.Sum(5, 10, 15));
    }
}