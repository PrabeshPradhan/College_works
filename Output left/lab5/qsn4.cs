using System;

class Subjects
{
    string[] sub = {
        "Introduction to Management", "Computer Networking", "DotNet Technology",
        "Computer Graphics and Animation", "MIS and e-Business"
    };

    public string this[int i]
    {
        get { return sub[i]; }
    }
}

class Program
{
    static void Main()
    {
        Subjects s = new Subjects();

        for (int i = 0; i < 5; i++)
            Console.WriteLine(s[i]);
    }
}
