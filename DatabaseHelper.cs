using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace WindowsFormsKorotkova
{
    public class DatabaseHelper
    {
        private static readonly string _connectionString = @"Server=DESKTOP-IM5UK2N;
                                                  Database=shop;
                                                  Integrated Security=True;
                                                  Encrypt=True;
                                                  TrustServerCertificate=True;
                                                  Connection Timeout=30";

        public static SqlConnection GetOpenConnection()
        {
            var conn = new SqlConnection(_connectionString);
            try
            {
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                conn.Dispose();
                MessageBox.Show($"Ошибка подключения к базе данных: {ex.Message}",
                    "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }

}