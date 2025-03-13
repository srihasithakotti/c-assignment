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
        EmployeeModel emp = new EmployeeModel
        {
            EmpId = 101,
            EmpName = "John Doe",
            EmailId = "john.doe@example.com",
            Salary = 50000.5f,
            IsEmployeeActive = true
        };
        
        // Display Employee Details
        Console.WriteLine("Employee ID: " + emp.EmpId);
        Console.WriteLine("Employee Name: " + emp.EmpName);
        Console.WriteLine("Email ID: " + emp.EmailId);
        Console.WriteLine("Salary: " + emp.Salary);
        Console.WriteLine("Is Employee Active: " + emp.IsEmployeeActive);
    }
}