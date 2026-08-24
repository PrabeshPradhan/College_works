using System;

struct Company
{
    public string name;
    public string address;
    public string phone;
    public double salary;
}

class MyCompany
{
    static void Main()
    {
        Company c = new Company();

        Console.Write("Company name: ");
        c.name = Console.ReadLine();

        Console.Write("Company address: ");
        c.address = Console.ReadLine();

        Console.Write("Company phone: ");
        c.phone = Console.ReadLine();

        Console.Write("Company salary: ");
        c.salary = double.Parse(Console.ReadLine());

        Console.WriteLine("\n--- Details ---");
        Console.WriteLine("Name: " + c.name);
        Console.WriteLine("Address: " + c.address);
        Console.WriteLine("Phone: " + c.phone);
        Console.WriteLine("Salary: " + c.salary);
    }
}
