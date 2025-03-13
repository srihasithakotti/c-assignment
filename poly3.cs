using System;

class Calculator
{
    // Method Overloading: Same method name but different signatures
    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

    public int Multiply(int a, int b, int c)
    {
        return a * b * c;
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();
        
        // Calling Multiply method with different signatures
        Console.WriteLine("Multiplication of 5 and 10: " + calc.Multiply(5, 10));
        Console.WriteLine("Multiplication of 5.5 and 2.2: " + calc.Multiply(5.5, 2.2));
        Console.WriteLine("Multiplication of 2, 3 and 4: " + calc.Multiply(2, 3, 4));
    }
}