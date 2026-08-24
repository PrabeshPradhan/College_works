using System;

static class Demo {
    private static int x;

    static Demo() { x = 0; }

    public static void Inc() { x++; }
    public static void Show() { Console.WriteLine(x); }
}

class Program {
    static void Main() {
        Demo.Inc();
        Demo.Inc();
        Demo.Show();
    }
}
