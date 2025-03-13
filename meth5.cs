using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of even numbers you want: ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Please enter a valid positive integer: ");
        }
        
        Console.WriteLine("The first {0} even numbers are:", n);
        int count = 0, num = 2;
        while (count < n)
        {
            Console.Write(num + " ");
            num += 2;
            count++;
        }
    }
}