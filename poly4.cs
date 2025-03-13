using System;

class Calculator
{
    // Method Overloading: Same method name but different data types
    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

    public float Multiply(float a, float b)
    {
        return a * b;
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();
        
        // Calling Multiply method with different data types
        Console.WriteLine("Multiplication of 5 and 10: " + calc.Multiply(5, 10));
        Console.WriteLine("Multiplication of 5.5 and 2.2: " + calc.Multiply(5.5, 2.2));
        Console.WriteLine("Multiplication of 2.5f and 3.5f: " + calc.Multiply(2.5f, 3.5f));
    }
}