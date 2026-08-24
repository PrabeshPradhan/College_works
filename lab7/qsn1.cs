using System;

class Test
{
    static void A()
    {
        Console.WriteLine("Method A");
    }

    static void B()
    {
        Console.WriteLine("Method B");
    }

    delegate void MyDelegate();

    static void Main()
    {
        MyDelegate d = A;       // Singlecast
        d();

        d += B;                 // Multicast
        d();
    }
}
