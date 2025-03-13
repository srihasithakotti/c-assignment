using System;

class Program
{
    static void Main()
    {
    
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

    
        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

    
        Console.Write("Enter an operation (+, -, *, /): ");
        char operation = Convert.ToChar(Console.ReadLine());

        double result = 0;

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                    result = num1 / num2;
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Invalid operation.");
                return;
        }

    
        Console.WriteLine($"{num1} {operation} {num2} = {result}");
    }
}