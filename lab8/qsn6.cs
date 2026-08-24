using System;
using System.Data.SqlClient;

class Test
{
    static void Main()
    {
        SqlConnection con = new SqlConnection(
            "Data Source=.;Initial Catalog=Bank;Integrated Security=True");

        con.Open();

        SqlCommand cmd = new SqlCommand(
            "SELECT * FROM Customer", con);

        SqlDataReader r = cmd.ExecuteReader();

        while (r.Read())
            Console.WriteLine(r[0] + " " + r[1] + " " + r[2] + " " + r[3]);

        r.Close();

        cmd = new SqlCommand(
            "UPDATE Customer SET Address='Kathmandu' WHERE [Account no.]=1234", con);

        cmd.ExecuteNonQuery();

        Console.WriteLine("Address updated.");
        con.Close();
    }
}
