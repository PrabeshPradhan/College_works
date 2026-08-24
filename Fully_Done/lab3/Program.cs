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

        int sum = 0;
        foreach (int num in arr)
            if (num % 2 != 0)
                sum += num;

        Console.WriteLine($"Sum of odd elements: {sum}");
    }
}
