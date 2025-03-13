using System;
using System.Collections.Generic;
using System.Data;

class Program
{
    static void Main()
    {
        // Creating an integer list and adding elements
        List<int> intList = new List<int> { 1, 2, 3, 4, 5 };
        Console.WriteLine("Integer List using for loop:");
        for (int i = 0; i < intList.Count; i++)
        {
            Console.WriteLine(intList[i]);
        }

        Console.WriteLine("Integer List using foreach loop:");
        foreach (int num in intList)
        {
            Console.WriteLine(num);
        }

        // Creating a string list and adding elements
        List<string> strList = new List<string> { "One", "Two", "Three", "Four", "Five" };
        Console.WriteLine("String List using for loop:");
        for (int i = 0; i < strList.Count; i++)
        {
            Console.WriteLine(strList[i]);
        }

        Console.WriteLine("String List using foreach loop:");
        foreach (string str in strList)
        {
            Console.WriteLine(str);
        }

        // Count elements
        Console.WriteLine("Count of elements in string list: " + strList.Count);

        // Check existence of "Kishore"
        Console.WriteLine("Checking for 'Kishore' in string list using Exists: " + strList.Exists(x => x == "Kishore"));
        Console.WriteLine("Checking for 'Kishore' in string list using Find: " + (strList.Find(x => x == "Kishore") ?? "Not Found"));
        Console.WriteLine("Checking for 'Kishore' in string list using Contains: " + strList.Contains("Kishore"));

        // Insert an element
        strList.Insert(2, "InsertedValue");
        Console.WriteLine("List after insertion:");
        foreach (string str in strList)
        {
            Console.WriteLine(str);
        }

        // Reverse the list
        strList.Reverse();
        Console.WriteLine("Reversed List:");
        foreach (string str in strList)
        {
            Console.WriteLine(str);
        }

        // Remove element at index 3
        strList.RemoveAt(3);
        Console.WriteLine("List after removing element at index 3:");
        foreach (string str in strList)
        {
            Console.WriteLine(str);
        }

        // Creating DataTable
        DataTable dt = new DataTable("EmployeeTable");
        dt.Columns.Add("EmpId", typeof(int));
        dt.Columns.Add("EmpName", typeof(string));
        dt.Columns.Add("EmpSalary", typeof(double));
        dt.Columns.Add("Department", typeof(string));

        // Adding records
        dt.Rows.Add(101, "Alice", 50000, "IT");
        dt.Rows.Add(102, "Bob", 60000, "HR");
        dt.Rows.Add(103, "Charlie", 55000, "Finance");
        dt.Rows.Add(104, "David", 62000, "Marketing");
        dt.Rows.Add(105, "Eve", 58000, "IT");

        // Print EmpId column using for loop
        Console.WriteLine("EmpId using for loop:");
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            Console.WriteLine(dt.Rows[i]["EmpId"]);
        }

        // Print EmpId column using foreach loop
        Console.WriteLine("EmpId using foreach loop:");
        foreach (DataRow row in dt.Rows)
        {
            Console.WriteLine(row["EmpId"]);
        }

        // Creating DataSet and adding tables
        DataSet ds = new DataSet("MyDataSet");
        ds.Tables.Add(dt);

        // Creating and modifying ArrayList
        List<string> arrayList = new List<string> { "One", "Two", "Three" };
        Console.WriteLine("ArrayList elements:");
        foreach (string item in arrayList)
        {
            Console.WriteLine(item);
        }

        // Reverse ArrayList
        arrayList.Reverse();
        Console.WriteLine("Reversed ArrayList:");
        foreach (string item in arrayList)
        {
            Console.WriteLine(item);
        }

        // Sort ArrayList
        arrayList.Sort();
        Console.WriteLine("Sorted ArrayList:");
        foreach (string item in arrayList)
        {
            Console.WriteLine(item);
        }
    }
}