using System;

class Calculator
{
    // Method using parameter array to calculate sum
    public int Sum(params int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter numbers separated by space: ");
        string[] inputs = Console.ReadLine().Split();
        int[] numbers = Array.ConvertAll(inputs, int.Parse);
        
        Calculator calc = new Calculator();
        
        int sum = calc.Sum(numbers);
        
        Console.WriteLine("Sum of given numbers = {0}", sum);
    }
}