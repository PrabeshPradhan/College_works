using System;

class Test
{
    delegate int Calculate(int a, int b);

    static void Main()
    {
        Calculate add = delegate(int a, int b)
        {
            return a + b;
        };

        Console.WriteLine(add(10, 20));

        Calculate mul = (a, b) => a * b;

        Console.WriteLine(mul(10, 20));
    }
}
