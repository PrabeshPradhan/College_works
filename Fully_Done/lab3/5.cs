using System;

//class Program
{
    static void Main()
    {
        // Declare and initialize jagged array
        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[] { 1, 2, 3 };
        jaggedArray[1] = new int[] { 4, 5 };
        jaggedArray[2] = new int[] { 6, 7, 8, 9 };

        // Display jagged array
        Console.WriteLine("Jagged Array Elements:");
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
                Console.Write(jaggedArray[i][j] + " ");
            Console.WriteLine();
        }
    }
}
