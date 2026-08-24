using System;

//class Program
{
    // Method with optional parameters
    static void DisplayInfo(string name, int age = 18, string city = "Delhi")
    {
        Console.WriteLine($"Name: {name}, Age: {age}, City: {city}");
    }

    static void Main()
    {
        // Using default values
        DisplayInfo("Prabesh");

        // Passing specific parameter
        DisplayInfo("Pradhan", 21);

        // Using named parameters (order doesn't matter)
        DisplayInfo(name: "Rajan", city: "Kathmandu", age: 30);
        DisplayInfo(city: "Butwal", name: "Sneha");
    }
}
