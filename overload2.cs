using System;

class Calculator
{
    // Method Overloading: Changing the order of parameters
    public int Multiply(int a, double b)
    {
        return (int)(a * b);
    }

    public int Multiply(double b, int a)
    {
        return (int)(b * a);
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();
        
        // Calling Multiply method with different parameter orders
        Console.WriteLine("Multiplication of int and double (5, 2.5): " + calc.Multiply(5, 2.5));
        Console.WriteLine("Multiplication of double and int (2.5, 5): " + calc.Multiply(2.5, 5));
    }
}