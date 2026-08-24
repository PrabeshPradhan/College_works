using System;

class ContactManager
{
    private string[] names;
    private string[] phones;

    public ContactManager(int size)
    {
        names = new string[size];
        phones = new string[size];
    }

    public void Add(int index, string name, string phone)
    {
        names[index] = name;
        phones[index] = phone;
    }

    // indexer returns phone by index
    public string this[int index]
    {
        get { return names[index] + " - " + phones[index]; }
    }
}

class Program
{
    static void Main()
    {
        ContactManager cm = new ContactManager(3);

        cm.Add(0, "Aman", "9876543210");
        cm.Add(1, "Sara", "9123456780");
        cm.Add(2, "Neeraj", "9988776655");

        for (int i = 0; i < 3; i++)
            Console.WriteLine(cm[i]);
    }
}
