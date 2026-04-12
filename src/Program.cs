namespace StretchApp.src;
using MySql.Data.MySqlClient;
using StretchApp.src.models;

static class Program
{
    [STAThread]
    static void Main()
    {
        // Test database connection - Remove or comment out this block after confirming connection works
        MessageBox.Show("PROGRAM STARTED");

        // Create an instance of ConnectionSQL and attempt to get a connection
        ConnectionSQL db = new ConnectionSQL();
        
        // Get a MySQL connection
        MySqlConnection conn = db.GetConnection();

        if (conn.State == System.Data.ConnectionState.Open) // Check if the connection state is OPEN
        {
            MessageBox.Show("TEST PASSED: Connection is OPEN");
        }
        else
        {
            MessageBox.Show("TEST FAILED: Connection is NOT OPEN");
        }

        conn.Close();
        MessageBox.Show("Connection closed.");

        //// To customize application configuration such as set high DPI settings or default font,
        //// see https://aka.ms/applicationconfiguration.
        //ApplicationConfiguration.Initialize();
        //Application.Run(new Form1());
    }
}