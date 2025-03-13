using System;

class Employee
{
    // Properties
    public string Name { get; set; }
    public int ID { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
    
    // Constructor Overloading
    public Employee()
    {
        Name = "Unknown";
        ID = 0;
        Department = "Not Assigned";
        Salary = 0.0;
    }
    
    public Employee(string name, int id)
    {
        Name = name;
        ID = id;
        Department = "Not Assigned";
        Salary = 0.0;
    }
    
    public Employee(string name, int id, string department, double salary)
    {
        Name = name;
        ID = id;
        Department = department;
        Salary = salary;
    }
    
    // Method to display employee details
    public void DisplayDetails()
    {
        Console.WriteLine("Employee Details:");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("ID: " + ID);
        Console.WriteLine("Department: " + Department);
        Console.WriteLine("Salary: " + Salary);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine();
        
        Console.Write("Enter Employee ID: ");
        int id = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter Employee Department: ");
        string department = Console.ReadLine();
        
        Console.Write("Enter Employee Salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());
        
        Employee emp1 = new Employee();
        Employee emp2 = new Employee(name, id);
        Employee emp3 = new Employee(name, id, department, salary);
        
        Console.WriteLine("\nDefault Employee:");
        emp1.DisplayDetails();
        
        Console.WriteLine("\nEmployee with Name and ID:");
        emp2.DisplayDetails();
        
        Console.WriteLine("\nEmployee with Full Details:");
        emp3.DisplayDetails();
    }
}