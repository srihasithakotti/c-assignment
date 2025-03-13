using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of odd natural terms you want: ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Please enter a valid positive integer: ");
        }

        Console.WriteLine("The odd numbers using for loop are:");
        int sumFor = 0;
        int[] oddNumbers = new int[n];
        for (int i = 0, odd = 1; i < n; i++, odd += 2)
        {
            Console.Write(odd + " ");
            sumFor += odd;
            oddNumbers[i] = odd;
        }
        Console.WriteLine();
        Console.WriteLine("The Sum of odd Natural Numbers up to {0} terms using for loop: {1}", n, sumFor);
        
        Console.WriteLine("\nThe odd numbers using foreach loop are:");
        int sumForeach = 0;
        foreach (int num in oddNumbers)
        {
            Console.Write(num + " ");
            sumForeach += num;
        }
        Console.WriteLine();
        Console.WriteLine("The Sum of odd Natural Numbers up to {0} terms using foreach loop: {1}", n, sumForeach);
    }
}