using System;

class Program
{
    static void Main()
    {

        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());


        int temp = num1;
        num1 = num2;
        num2 = temp;

        
        Console.WriteLine("After swapping: " + num1 + "," + num2);
    }
}