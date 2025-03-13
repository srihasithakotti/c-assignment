using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter value for a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        
        int res;
        
        res = a++;
        Console.WriteLine("a is " + a + " and res is " + res);
        
        res = a--;
        Console.WriteLine("a is " + a + " and res is " + res);
        
        res = ++a;
        Console.WriteLine("a is " + a + " and res is " + res);
        
        res = --a;
        Console.WriteLine("a is " + a + " and res is " + res);
    }
}