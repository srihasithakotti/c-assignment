using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Integer value: ");
        int intValue = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter Float value: ");
        float floatValue = float.Parse(Console.ReadLine());
        
        Console.WriteLine("int.ToString() - " + intValue.ToString());
        Console.WriteLine("float.ToString() - " + floatValue.ToString());
    }
}