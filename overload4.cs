using System;

class Calculator
{
    // Method to divide two numbers
    public double Division(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Division by zero is not allowed.");
            return double.NaN;
        }
        return a / b;
    }

    // Method to divide three numbers
    public double Division(double a, double b, double c)
    {
        if (b == 0 || c == 0)
        {
            Console.WriteLine("Division by zero is not allowed.");
            return double.NaN;
        }
        return a / b / c;
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();
        
        // Calling Division method with different parameters
        Console.WriteLine("Division of 10 by 2: " + calc.Division(10, 2));
        Console.WriteLine("Division of 20 by 2 and 5: " + calc.Division(20, 2, 5));
    }
}