class Test
{
    void Add(int a, int b)
    {
        Console.WriteLine(a + b);
    }

    void Add(int a, int b, int c)
    {
        Console.WriteLine(a + b + c);
    }

    static void Main()
    {
        Test t = new Test();
        t.Add(10, 20);
        t.Add(10, 20, 30);
    }
}
