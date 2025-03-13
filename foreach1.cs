using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of natural terms do you want: ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Please enter a valid positive integer: ");
        }

        Console.WriteLine("The first {0} natural numbers using for loop are:", n);
        int sumFor = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
            sumFor += i;
        }
        Console.WriteLine();
        Console.WriteLine("The Sum of Natural Numbers up to {0} terms using for loop: {1}", n, sumFor);
        
        Console.WriteLine("\nThe first {0} natural numbers using foreach loop are:", n);
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = i + 1;
        }
        
        int sumForeach = 0;
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
            sumForeach += num;
        }
        Console.WriteLine();
        Console.WriteLine("The Sum of Natural Numbers up to {0} terms using foreach loop: {1}", n, sumForeach);
    }
}