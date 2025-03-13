using System;

class Car
{
    // Fields
    private string brand;
    private int year;
    
    // Properties
    public string Model { get; set; }
    public string Color { get; set; }
    public double Price { get; set; }
    
    // Constructor
    public Car(string brand, int year, string model, string color, double price)
    {
        this.brand = brand;
        this.year = year;
        Model = model;
        Color = color;
        Price = price;
    }
    
    // Method to display car details
    public void DisplayCarDetails()
    {
        Console.WriteLine("Car Details:");
        Console.WriteLine("Brand: " + brand);
        Console.WriteLine("Year: " + year);
        Console.WriteLine("Model: " + Model);
        Console.WriteLine("Color: " + Color);
        Console.WriteLine("Price: " + Price);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Car Brand: ");
        string brand = Console.ReadLine();
        
        Console.Write("Enter Car Year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter Car Model: ");
        string model = Console.ReadLine();
        
        Console.Write("Enter Car Color: ");
        string color = Console.ReadLine();
        
        Console.Write("Enter Car Price: ");
        double price = Convert.ToDouble(Console.ReadLine());
        
        Car myCar = new Car(brand, year, model, color, price);
        myCar.DisplayCarDetails();
    }
}