using System;

//class Program
{
    static int Sum(params int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
            sum += num;
        return sum;
    }

    static void Main()
    {
        Console.WriteLine($"Sum of 1, 2, 3: {Sum(1, 2, 3)}");
        Console.WriteLine($"Sum of 10, 20, 30, 40: {Sum(10, 20, 30, 40)}");
        Console.WriteLine($"Sum of 5, 15: {Sum(5, 15)}");

        int[] arr = { 100, 200, 300 };
        Console.WriteLine($"Sum of array: {Sum(arr)}");
    }
}
