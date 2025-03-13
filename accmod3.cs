using System;

class BaseClass
{
    private int x;
    
    private void SetValue(int value)
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
        BaseClass obj = new BaseClass();
        Console.WriteLine("Enter value of x:");
        int value = Convert.ToInt32(Console.ReadLine());
        obj.SetAndDisplayValue(value);
    }
}