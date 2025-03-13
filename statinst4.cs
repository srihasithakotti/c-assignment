using System;

class Car
{
    // Static Variable
    public static int CarCount;

    // Instance Variables
    private string brand;
    private int year;
    
    // Static Constructor
    static Car()
    {
        CarCount = 0;
        Console.WriteLine("Static Constructor Invoked - Car class initialized.");
    }
    
    // Instance Constructor
    public Car(string brand, int year, string model, string color, double price, int maxSpeed)
    {
        this.brand = brand;
        this.year = year;
        Model = model;
        Color = color;
        Price = price;
        MaxSpeed = maxSpeed;
        CarCount++; // Increment car count when a new car object is created
        Console.WriteLine("Instance Constructor Invoked - New Car Created.");
    }
    
    // Properties
    public string Model { get; set; }
    public string Color { get; set; }
    public double Price { get; set; }
    public int MaxSpeed { get; set; }
    
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
    
    // Static method to update and show total cars
    public static void UpdateCarCount(int newCount)
    {
        CarCount = newCount;
        Console.WriteLine("Car count updated to: " + CarCount);
    }
    
    public static void ShowTotalCars()
    {
        Console.WriteLine("Total Cars Created: " + CarCount);
    }
}

class Program
{
    static void Main()
    {
        // Creating multiple objects of Car class (Invoking instance constructor)
        Car car1 = new Car("Toyota", 2022, "Corolla", "Red", 25000, 180);
        Car car2 = new Car("Honda", 2023, "Civic", "Blue", 27000, 200);
        Car car3 = new Car("Ford", 2021, "Mustang", "Black", 55000, 250);
        
        // Displaying details of each car
        car1.DisplayCarDetails();
        car2.DisplayCarDetails();
        car3.DisplayCarDetails();
        
        // Updating static variable within the class
        Car.UpdateCarCount(10);
        
        // Accessing static method using class name
        Car.ShowTotalCars();
    }
}