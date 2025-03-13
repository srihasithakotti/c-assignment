using System;

class Demo
{
    // Static method
    public static void StaticMethod()
    {
        Console.WriteLine("This is a static method.");
    }
    
    // Instance method
    public void InstanceMethod()
    {
        Console.WriteLine("This is an instance method.");
    }
}

class Program
{
    static void Main()
    {
        // Calling static method
        Demo.StaticMethod();
        
        // Creating an instance and calling instance method
        Demo obj = new Demo();
        obj.InstanceMethod();
    }
}