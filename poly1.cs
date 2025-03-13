using System;

class Calculator
{
    // Method Overloading: Add method with two parameters
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Method Overloading: Add method with three parameters
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();
        
        // Calling Add method with two parameters
        Console.WriteLine("Sum of 5 and 10: " + calc.Add(5, 10));
        
        // Calling Add method with three parameters
        Console.WriteLine("Sum of 5, 10 and 15: " + calc.Add(5, 10, 15));
    }
}