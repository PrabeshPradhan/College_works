using System;

class Test
{
    static void Main()
    {
        Action<string> a = x => Console.WriteLine(x);
        a("Hello");

        Func<int, int, int> f = (x, y) => x + y;
        Console.WriteLine(f(10, 20));

        Predicate<int> p = x => x > 10;
        Console.WriteLine(p(20));
    }
}
