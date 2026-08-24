using System;

//class Program
{
    static void Main()
    {
        int[,] A = new int[3, 3];
        int[,] B = new int[3, 3];
        int[,] C = new int[3, 3];

        Console.WriteLine("Enter first 3x3 matrix:");
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                A[i, j] = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second 3x3 matrix:");
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                B[i, j] = int.Parse(Console.ReadLine());

        // Matrix multiplication
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                for (int k = 0; k < 3; k++)
                    C[i, j] += A[i, k] * B[k, j];

        Console.WriteLine("Resultant matrix:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
                Console.Write(C[i, j] + " ");
            Console.WriteLine();
        }
    }
}
