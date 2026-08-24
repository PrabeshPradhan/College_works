using System;
class Program
{
    static bool IsPrime(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i * i <= num; i++)
            if (num % i == 0)
                return false;
        return true;
    }

    static void Main()
    {
        Console.Write("Enter size of array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());

        Console.WriteLine("Prime elements in the array:");
        foreach (int num in arr)
            if (IsPrime(num))
                Console.Write(num + " ");
    }
}
