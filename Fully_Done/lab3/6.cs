using System;

class Program
{
    // Pass by value
    static void IncrementByValue(int num)
    {
        num++;
        Console.WriteLine($"Inside IncrementByValue: {num}");
    }

    // Pass by reference
    static void IncrementByReference(ref int num)
    {
        num++;
        Console.WriteLine($"Inside IncrementByReference: {num}");
    }

    static void Main()
    {
        int value = 10;
        Console.WriteLine($"Original value: {value}");

        IncrementByValue(value);
        Console.WriteLine($"After pass by value: {value}");

        IncrementByReference(ref value);
        Console.WriteLine($"After pass by reference: {value}");
    }
}
