using System;

class Program
{
    static void Main()
    {
        string[] arr = new string[1];
        
        Console.Write("Enter a string for array storage: ");
        arr[0] = Console.ReadLine();
        
        Console.WriteLine("\nArray printing using for loop:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
        
        Console.WriteLine("\nArray printing using foreach loop:");
        foreach (string str in arr)
        {
            Console.WriteLine(str);
        }
    }
}