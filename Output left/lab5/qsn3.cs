using System;

class Student
{
    private int age;
    private string name;

    // Read-only (only get)
    public int RollNo { get; } = 25;

    // Read-write (get/set with validation)
    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 1) age = value;
        }
    }

    // Write-only (only set)
    public string SetName
    {
        set { name = value; }
    }

    // Expression-bodied read-only
    public string DisplayName => "Name: " + name;
}

class Program
{
    static void Main()
    {
        Student s = new Student();
        s.SetName = "Rahul";
        s.Age = 20;

        Console.WriteLine(s.RollNo);
        Console.WriteLine(s.DisplayName);
        Console.WriteLine(s.Age);
    }
}
