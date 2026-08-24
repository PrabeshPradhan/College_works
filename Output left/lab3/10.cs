using System;

class Program
{
    static int Determinant3x3(int[,] mat)
    {
        // Formula: a(ei - fh) - b(di - fg) + c(dh - eg)
        int a = mat[0, 0], b = mat[0, 1], c = mat[0, 2];
        int d = mat[1, 0], e = mat[1, 1], f = mat[1, 2];
        int g = mat[2, 0], h = mat[2, 1], i = mat[2, 2];

        return a * (e * i - f * h)
             - b * (d * i - f * g)
             + c * (d * h - e * g);
    }

    static void Main()
    {
        int[,] matrix = new int[3, 3];
        Console.WriteLine("Enter 3x3 matrix elements:");

        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                matrix[i, j] = int.Parse(Console.ReadLine());

        int determinant = Determinant3x3(matrix);
        Console.WriteLine($"Determinant of the matrix: {determinant}");
    }
}
