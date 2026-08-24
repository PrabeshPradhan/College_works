using System;

class Test
{
    static void Main()
    {
        Console.Write("Enter balance: ");
        double balance = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter withdrawal amount: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        try
        {
            if (amount > balance)
                throw new Exception("Insufficient balance");

            balance = balance - amount;
            Console.WriteLine("Remaining balance = " + balance);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
