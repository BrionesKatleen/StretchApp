using MySql.Data.MySqlClient;
using StretchApp.src.models;

namespace StretchApp.src.tests
{
    public static class DatabaseTest
    {
        public static void TestConnection()
        {
            try
            {
                MessageBox.Show("TEST STARTED");

                ConnectionSQL db = new ConnectionSQL();
                MySqlConnection conn = db.GetConnection();

                if (conn.State == System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("TEST PASSED: Connection is OPEN");
                }
                else
                {
                    MessageBox.Show("TEST FAILED: Connection is NOT OPEN");
                }

                //conn.Close();
                //MessageBox.Show("Connection closed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("TEST FAILED: " + ex.Message);
            }
        }
    }
}
