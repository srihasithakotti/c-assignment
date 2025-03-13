using System;

class BaseClass
{
    protected int x;
    
    protected void SetValue(int value)
    {
        x = value;
    }
}

class DerivedClass : BaseClass
{
    public void Display()
    {
        Console.WriteLine("Enter value of x:");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Output:");
        Console.WriteLine(x);
    }
}

class Program
{
    static void Main()
    {
        DerivedClass obj = new DerivedClass();
        obj.Display();
    }
}