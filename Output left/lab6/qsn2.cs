class A
{
    public virtual void Show()
    {
        Console.WriteLine("Class A");
    }
}

class B : A
{
    public override void Show()
    {
        Console.WriteLine("Class B");
    }

    static void Main()
    {
        B b = new B();
        b.Show();
    }
}
