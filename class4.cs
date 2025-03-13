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
    public int MaxSpeed { get; set; }
    
    // Constructor
    public Car(string brand, int year, string model, string color, double price, int maxSpeed)
    {
        this.brand = brand;
        this.year = year;
        Model = model;
        Color = color;
        Price = price;
        MaxSpeed = maxSpeed;
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
        Console.WriteLine("Max Speed: " + MaxSpeed + " km/h");
    }
}

class Program
{
    static void Main()
    {
        Car myObj = new Car("Toyota", 2022, "Corolla", "Red", 25000, 180);
        
        Console.WriteLine("Color: " + myObj.Color);
        Console.WriteLine("Max Speed: " + myObj.MaxSpeed + " km/h");
    }
}