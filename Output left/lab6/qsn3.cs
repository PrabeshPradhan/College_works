class Number
{
    public int x;

    public Number(int x)
    {
        this.x = x;
    }

    public static Number operator ++(Number n)
    {
        n.x++;
        return n;
    }

    public static Number operator --(Number n)
    {
        n.x--;
        return n;
    }

    public static Number operator *(Number a, Number b)
    {
        return new Number(a.x * b.x);
    }

    public static Number operator /(Number a, Number b)
    {
        return new Number(a.x / b.x);
    }

    public static bool operator ==(Number a, Number b)
    {
        return a.x == b.x;
    }

    public static bool operator !=(Number a, Number b)
    {
        return a.x != b.x;
    }

    static void Main()
    {
        Number a = new Number(10);
        Number b = new Number(5);

        a++;
        a--;
        Number c = a * b;
        Number d = a / b;

        Console.WriteLine(c.x);
        Console.WriteLine(d.x);
        Console.WriteLine(a == b);
        Console.WriteLine(a != b);
    }
}
