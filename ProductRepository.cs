using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsKorotkova
{
    public class ProductRepository
    {
        public DataTable GetAllProducts()
        {
            using (SqlConnection conn = DatabaseHelper.GetOpenConnection())
            {
                if (conn == null) return null;

                try
                {
                    string query = "SELECT * FROM dbo.товар"; 
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки данных: {ex.Message}",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }
    }
}

