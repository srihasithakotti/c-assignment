using System;

class Calculator
{
    // Method to calculate sum
    public int Sum(int a, int b)
    {
        return a + b;
    }
    
    // Method to calculate product
    public int Product(int a, int b)
    {
        return a * b;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter value for a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter value for b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        
        Calculator calc = new Calculator();
        
        int sum = calc.Sum(a, b);
        int product = calc.Product(a, b);
        
        Console.WriteLine("Sum = {0} and Product = {1}", sum, product);
    }
}