using System;

class Time
{
    int h, m, s;

    public Time(int h, int m, int s) { this.h = h; this.m = m; this.s = s; }

    int ToSec() => h * 3600 + m * 60 + s;

    static Time FromSec(int sec)
    {
        if (sec < 0) sec = 0;
        return new Time(sec / 3600, (sec % 3600) / 60, sec % 60);
    }

    public void Display() => Console.WriteLine($"{h:D2}:{m:D2}:{s:D2}");

    public Time Add(Time t) => FromSec(ToSec() + t.ToSec());

    public Time Subtract(Time t) => FromSec(ToSec() - t.ToSec());
}

class MyTime
{
    static void Main()
    {
        Time t1 = new Time(2, 30, 40);
        Time t2 = new Time(1, 10, 50);

        t1.Display();
        t2.Display();
        t1.Add(t2).Display();
        t1.Subtract(t2).Display();
    }
}
