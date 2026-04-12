/*
 * File Name: ConnectionSQL.cs
 * File Description: Handles database connection to MySQL server. Provides a method to open and return a connection object.
 * Created by: BRIONES 
 * Created on: April 12 2026
 */

using System;
using MySql.Data.MySqlClient;

namespace StretchApp.src.models
{
    internal class ConnectionSQL
    {
        // Connection string to connect to the MySQL database.
        // Note: Modify uid and password according to your local MySQL setup before running the application.
        private readonly string _connectionString = "server=localhost;database=StretchDB;uid=root;password=password;";

        //Creates and opens a MySQL connection.
        public MySqlConnection GetConnection()
        {
            // Create a new MySqlConnection object with the connection string
            MySqlConnection conn = new MySqlConnection(_connectionString);

            try
            {
                // Attempt to open the connection
                conn.Open();
                Console.WriteLine("Database connection SUCCESSFUL!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Database connection FAILED: " + ex.Message);
            }

            return conn;
        }
    }
}

