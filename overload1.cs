using System;

class Calculator
{
    // Method Overloading: Changing the number of parameters
    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public int Multiply(int a, int b, int c)
    {
        return a * b * c;
    }

    public int Multiply(int a, int b, int c, int d)
    {
        return a * b * c * d;
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();
        
        // Calling Multiply method with different number of parameters
        Console.WriteLine("Multiplication of 5 and 2: " + calc.Multiply(5, 2));
        Console.WriteLine("Multiplication of 5, 2 and 3: " + calc.Multiply(5, 2, 3));
        Console.WriteLine("Multiplication of 5, 2, 3 and 4: " + calc.Multiply(5, 2, 3, 4));
    }
}