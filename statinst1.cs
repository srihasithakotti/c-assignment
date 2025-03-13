using System;

class Car
{
    // Static Variable
    public static int CarCount = 0;

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
        CarCount++; // Increment car count when a new car object is created
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
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        // Creating multiple objects of Car class
        Car car1 = new Car("Toyota", 2022, "Corolla", "Red", 25000, 180);
        Car car2 = new Car("Honda", 2023, "Civic", "Blue", 27000, 200);
        Car car3 = new Car("Ford", 2021, "Mustang", "Black", 55000, 250);
        
        // Displaying details of each car
        car1.DisplayCarDetails();
        car2.DisplayCarDetails();
        car3.DisplayCarDetails();
        
        // Accessing static variable through class name
        Console.WriteLine("Total Cars Created: " + Car.CarCount);
    }
}