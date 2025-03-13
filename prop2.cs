using System;

class Employee
{
    private string name;
    private int id;
    private double salary;

    // Read-write properties
    public string Name {
        get { return name; }
        set { name = value; }
    }
    public int ID {
        get { return id; }
        set { id = value; }
    }
    public double Salary {
        get { return salary; }
        set { salary = value; }
    }

    // Constructor to initialize properties
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
        
        // Accessing properties
        Console.WriteLine("Employee Name: " + emp.Name);
        Console.WriteLine("Employee ID: " + emp.ID);
        Console.WriteLine("Employee Salary: " + emp.Salary);
        
        // Modifying properties
        emp.Name = "Jane Smith";
        emp.ID = 102;
        emp.Salary = 60000;
        
        Console.WriteLine("\nUpdated Employee Details:");
        Console.WriteLine("Employee Name: " + emp.Name);
        Console.WriteLine("Employee ID: " + emp.ID);
        Console.WriteLine("Employee Salary: " + emp.Salary);
    }
}