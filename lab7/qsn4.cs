using System;

class Test
{
    delegate void MyDelegate();

    static event MyDelegate Event;

    static void Show()
    {
        Console.WriteLine("Event occurred");
    }

    static void Main()
    {
        Event += Show;
        Event();
    }
}
