using System;

//class Program
{
    static void Main()
    {
        int[,] matrix = new int[3, 3];
        Console.WriteLine("Enter 3x3 matrix elements:");

        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                matrix[i, j] = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = 0; i < 3; i++)
            sum += matrix[i, i];

        Console.WriteLine($"Sum of diagonal elements: {sum}");
    }
}
