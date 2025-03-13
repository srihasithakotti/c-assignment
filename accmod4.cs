using System;

class DefaultModifierClass // Default access modifier (internal)
{
    int x; // Default access modifier (private within the same class)
    
    void SetValue(int value) // Default access modifier (private within the same class)
    {
        x = value;
    }

    public void SetAndDisplayValue(int value)
    {
        SetValue(value);
        Console.WriteLine("Output:");
        Console.WriteLine(x);
    }
}

class Program
{
    static void Main()
    {
        DefaultModifierClass obj = new DefaultModifierClass();
        Console.WriteLine("Enter value of x:");
        int value = Convert.ToInt32(Console.ReadLine());
        obj.SetAndDisplayValue(value);
    }
}