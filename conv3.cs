using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter string name: ");
        string strValue = Console.ReadLine();
        
        Console.Write("Enter Integer value: ");
        int intValue = Convert.ToInt32(Console.ReadLine());
        
        float floatValue = Convert.ToSingle(strValue);
        double doubleValue = Convert.ToDouble(intValue);
        
        Console.WriteLine("String to float - " + floatValue);
        Console.WriteLine("Int to double - " + doubleValue);
    }
}