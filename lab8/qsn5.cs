using System;
using System.Data.SqlClient;

class Test
{
    static void Main()
    {
        SqlConnection con = new SqlConnection(
            "Data Source=.;Initial Catalog=Bank;Integrated Security=True");

        con.Open();

        string insert = "INSERT INTO Customer VALUES" +
            "(1001,'Ram','Kirtipur',1000)," +
            "(1002,'Hari','Kathmandu',400)," +
            "(1003,'Sita','Lalitpur',700)";

        SqlCommand cmd = new SqlCommand(insert, con);
        cmd.ExecuteNonQuery();

        cmd = new SqlCommand(
            "DELETE FROM Customer WHERE Deposit_amount < 500", con);

        cmd.ExecuteNonQuery();

        Console.WriteLine("Records inserted and deleted successfully.");
        con.Close();
    }
}
