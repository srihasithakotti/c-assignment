using System;

class Student
{
    // Public properties
    public int StudentId { get; set; }
    public string StudentName { get; set; }
}

class Program
{
    static void Main()
    {
        // Creating Student object
        Student student1 = new Student
        {
            StudentId = 101,
            StudentName = "Santhi"
        };
        
        // Display Student Details
        Console.WriteLine("Details of Student:");
        Console.WriteLine("Student ID: " + student1.StudentId);
        Console.WriteLine("Student Name: " + student1.StudentName);
    }
}