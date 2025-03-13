using System;

class Employee
{
    // Properties
    public string Name { get; set; }
    public int ID { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
    
    // Constructor
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
        
        Employee emp = new Employee(name, id, department, salary);
        emp.DisplayDetails();
    }
}