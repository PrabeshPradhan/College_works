using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter size of array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());

        int min = arr[0], max = arr[0];
        foreach (int num in arr)
        {
            if (num < min) min = num;
            if (num > max) max = num;
        }

        Console.WriteLine($"Minimum: {min}, Maximum: {max}");
    }
}
