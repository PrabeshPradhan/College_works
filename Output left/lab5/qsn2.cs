using System;

class A
{
    protected int x = 10;
    public void ShowA() => Console.WriteLine("A: " + x);
}

class B : A
{
    public void ShowB() => Console.WriteLine("B inherited x = " + x);
}

class Program
{
    static void Main()
    {
        B obj = new B();
        obj.ShowA();
        obj.ShowB();
    }
}

using System;

class A { public void Amsg() => Console.WriteLine("A"); }
class B : A { public void Bmsg() => Console.WriteLine("B"); }
class C : B { public void Cmsg() => Console.WriteLine("C"); }

class Program
{
    static void Main()
    {
        C obj = new C();
        obj.Amsg(); obj.Bmsg(); obj.Cmsg();
    }
}


using System;

class A
{
    public void Show() => Console.WriteLine("Parent A");
}

class B : A
{
    public void Bmsg() => Console.WriteLine("Child B");
}

class C : A
{
    public void Cmsg() => Console.WriteLine("Child C");
}

class Program
{
    static void Main()
    {
        B b = new B();
        C c = new C();
        b.Show(); b.Bmsg();
        c.Show(); c.Cmsg();
    }
}

using System;

interface I1 { void A(); }
interface I2 { void B(); }

class Demo : I1, I2
{
    public void A() => Console.WriteLine("I1 method");
    public void B() => Console.WriteLine("I2 method");
}

class Program
{
    static void Main()
    {
        Demo d = new Demo();
        d.A();
        d.B();
    }
}

