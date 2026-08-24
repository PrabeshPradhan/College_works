using System;
using System.Linq;

class Test
{
    static void Main()
    {
        int[] n = { 10, 20, 30, 40, 50 };

        Console.WriteLine("Count = " + n.Count());
        Console.WriteLine("Sum = " + n.Sum());
        Console.WriteLine("Average = " + n.Average());
        Console.WriteLine("Minimum = " + n.Min());
        Console.WriteLine("Maximum = " + n.Max());
        Console.WriteLine("Aggregate = " + n.Aggregate((a, b) => a + b));
    }
}
