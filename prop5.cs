using System;

class EmployeeModel
{
    // Properties
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public string EmailId { get; set; }
    public float Salary { get; set; }
    public bool IsEmployeeActive { get; set; }
}

class Program
{
    static void Main()
    {
        EmployeeModel emp1 = new EmployeeModel
        {
            EmpId = 101,
            EmpName = "John Doe",
            EmailId = "john.doe@example.com",
            Salary = 50000.5f,
            IsEmployeeActive = true
        };
        
        // Display First Employee Details
        Console.WriteLine("Employee 1 Details:");
        Console.WriteLine("Employee ID: " + emp1.EmpId);
        Console.WriteLine("Employee Name: " + emp1.EmpName);
        Console.WriteLine("Email ID: " + emp1.EmailId);
        Console.WriteLine("Salary: " + emp1.Salary);
        Console.WriteLine("Is Employee Active: " + emp1.IsEmployeeActive);
        
        Console.WriteLine();
        
        EmployeeModel emp2 = new EmployeeModel
        {
            EmpId = 102,
            EmpName = "Jane Smith",
            EmailId = "jane.smith@example.com",
            Salary = 60000.75f,
            IsEmployeeActive = false
        };
        
        // Display Second Employee Details
        Console.WriteLine("Employee 2 Details:");
        Console.WriteLine("Employee ID: " + emp2.EmpId);
        Console.WriteLine("Employee Name: " + emp2.EmpName);
        Console.WriteLine("Email ID: " + emp2.EmailId);
        Console.WriteLine("Salary: " + emp2.Salary);
        Console.WriteLine("Is Employee Active: " + emp2.IsEmployeeActive);
    }
}