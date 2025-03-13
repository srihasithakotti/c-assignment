using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 3. Create an integer list and add any 5 integers
        List<int> intList = new List<int> { 10, 20, 30, 40, 50 };
        
        // 4. Print integer elements using for loop
        Console.WriteLine("Integer List using for loop:");
        for (int i = 0; i < intList.Count; i++)
        {
            Console.WriteLine(intList[i]);
        }
        
        // 5. Print integer elements using foreach loop
        Console.WriteLine("Integer List using foreach loop:");
        foreach (int num in intList)
        {
            Console.WriteLine(num);
        }
        
        // 6. Create a string list and add any 5 strings
        List<string> stringList = new List<string> { "John", "Doe", "Jane", "Smith", "Kishore" };
        
        // 7. Print string elements using for loop
        Console.WriteLine("String List using for loop:");
        for (int i = 0; i < stringList.Count; i++)
        {
            Console.WriteLine(stringList[i]);
        }
        
        // 8. Print string elements using foreach loop
        Console.WriteLine("String List using foreach loop:");
        foreach (string name in stringList)
        {
            Console.WriteLine(name);
        }
        
        // 9. Count elements in the list
        Console.WriteLine("Number of elements in string list: " + stringList.Count);
        
        // 10. Clear all elements in the list
        stringList.Clear();
        Console.WriteLine("String list cleared. Count: " + stringList.Count);
        
        // 11-13. Check for 'Kishore' in the list using Exists, Find, and Contains
        stringList.AddRange(new string[] { "John", "Doe", "Jane", "Smith", "Kishore" });
        Console.WriteLine("Is Kishore present (Exists)? " + stringList.Exists(name => name == "Kishore"));
        Console.WriteLine("Find Kishore: " + stringList.Find(name => name == "Kishore"));
        Console.WriteLine("Is Kishore present (Contains)? " + stringList.Contains("Kishore"));
        
        // 14. Insert an element into the list
        stringList.Insert(2, "Michael");
        Console.WriteLine("List after inserting Michael at index 2:");
        foreach (string name in stringList)
        {
            Console.WriteLine(name);
        }
        
        // 15. Reverse the list
        stringList.Reverse();
        Console.WriteLine("Reversed String List:");
        foreach (string name in stringList)
        {
            Console.WriteLine(name);
        }
        
        // 16. Remove an element at index 3
        stringList.RemoveAt(3);
        Console.WriteLine("List after removing element at index 3:");
        foreach (string name in stringList)
        {
            Console.WriteLine(name);
        }
        
        // 17-24. List of Student objects
        List<Student> students = new List<Student>();
        for (int i = 1; i <= 10; i++)
        {
            students.Add(new Student { Id = i, Name = "Student" + i });
        }
        Console.WriteLine("Total students in list: " + students.Count);
        students.Clear();
        Console.WriteLine("Students list cleared. Count: " + students.Count);
        
        // Check for student 'Kishore'
        students.Add(new Student { Id = 11, Name = "Kishore" });
        Console.WriteLine("Is Kishore present (Exists)? " + students.Exists(s => s.Name == "Kishore"));
        Console.WriteLine("Find Kishore: " + students.Find(s => s.Name == "Kishore"));
        Console.WriteLine("Is Kishore present (Contains)? " + students.Contains(new Student { Id = 11, Name = "Kishore" }));
        
        // Insert a student object into the list
        students.Insert(0, new Student { Id = 12, Name = "Michael" });
        Console.WriteLine("Students list after inserting Michael:");
        foreach (var student in students)
        {
            Console.WriteLine("Id: " + student.Id + ", Name: " + student.Name);
        }
    }
}

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }

    public override bool Equals(object obj)
    {
        if (obj is Student other)
        {
            return this.Id == other.Id && this.Name == other.Name;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Name);
    }
}