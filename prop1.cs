using System;

class Employee
{
    private string name;
    private int id;
    private double salary;

    // Read-only properties
    public string Name { get { return name; } }
    public int ID { get { return id; } }
    public double Salary { get { return salary; } }

    // Constructor to initialize read-only properties
    public Employee(string name, int id, double salary)
    {
        this.name = name;
        this.id = id;
        this.salary = salary;
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee("John Doe", 101, 50000);
        
        // Accessing read-only properties
        Console.WriteLine("Employee Name: " + emp.Name);
        Console.WriteLine("Employee ID: " + emp.ID);
        Console.WriteLine("Employee Salary: " + emp.Salary);
    }
}