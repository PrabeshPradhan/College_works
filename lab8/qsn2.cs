using System;
using System.Linq;

class Employee
{
    public string Name;
    public int Salary;
}

class Test
{
    static void Main()
    {
        Employee[] e =
        {
            new Employee { Name="Ram", Salary=30000 },
            new Employee { Name="Hari", Salary=25000 },
            new Employee { Name="Sita", Salary=35000 }
        };

        var result = from x in e
                     orderby x.Name descending
                     select x;

        foreach (var x in result)
            Console.WriteLine(x.Name + " " + x.Salary);
    }
}
