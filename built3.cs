using System;

class Program
{
    static void Main()
    {
        float floatValue = 12.34F; 
        decimal decimalValue = (decimal)floatValue; 

        Console.WriteLine("Float Value: " + floatValue);
        Console.WriteLine("Converted Decimal Value: " + decimalValue);
    }
}