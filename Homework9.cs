using System;
using System.Collections.Generic;

class Student
{
    private int studentID;
    private string studentName;

    public static List<Student> studentList = new List<Student>();

    public Student(int id, string name)
    {
        studentID = id;
        studentName = name;
        studentList.Add(this);
    }
    
    public string GetStudentName()
    {
        return studentName;
    }

    public void PrintInfo()
    {
        Console.WriteLine("Student ID: " + studentID + ", Student Name: " + studentName);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student(111, "Alice");
        Student s2 = new Student(222, "Bob");
        Student s3 = new Student(333, "Cathy");
        Student s4 = new Student(444, "David");

        Dictionary<string, double> gradebook = new Dictionary<string, double>();

        gradebook.Add("Alice", 4.0);
        gradebook.Add("Bob", 3.6);
        gradebook.Add("Cathy", 2.5);
        gradebook.Add("David", 1.8);
        
        if (!gradebook.ContainsKey("Tom"))
        {
            gradebook.Add("Tom", 3.3);
        }

        double totalGPA = 0;

        foreach (double gpa in gradebook.Values)
        {
            totalGPA += gpa;
        }

        double averageGPA = totalGPA / gradebook.Count;

        Console.WriteLine("The average GPA is: " + averageGPA.ToString("F2"));

        foreach (Student s in Student.studentList)
        {
            string name = s.GetStudentName();

            if (gradebook[name] > averageGPA)
            {
                s.PrintInfo();
            }
        }
    }
}