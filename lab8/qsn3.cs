using System;
using System.Linq;

class Student
{
    public string Name, Address, College;
}

class Test
{
    static void Main()
    {
        Student[] s =
        {
            new Student { Name="Ram", Address="Kirtipur", College="Patan Multiple Campus" },
            new Student { Name="Hari", Address="Kathmandu", College="Patan Multiple Campus" },
            new Student { Name="Sita", Address="Kirtipur", College="Patan Multiple Campus" }
        };

        var result = from x in s
                     where x.Address == "Kirtipur" &&
                           x.College == "Patan Multiple Campus"
                     select x;

        foreach (var x in result)
            Console.WriteLine(x.Name);
    }
}
