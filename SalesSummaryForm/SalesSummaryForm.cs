using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsKorotkova.Forms
{
    public partial class SalesSummaryForm : Form
    {
        private DataTable reportData;

        public SalesSummaryForm()
        {
            InitializeComponent();
            LoadProductNames();
        }

        private void LoadProductNames()
        {
            using (var conn = DatabaseHelper.GetOpenConnection())
            {
                if (conn == null) return;

                string query = "SELECT DISTINCT наименование FROM dbo.наименование";

                using (var cmd = new SqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBoxProducts.Items.Add(reader.GetString(0));
                    }
                }
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (comboBoxProducts.SelectedItem == null)
            {
                MessageBox.Show("Выберите наименование товара.");
                return;
            }

            string selectedName = comboBoxProducts.SelectedItem.ToString();

            using (var conn = DatabaseHelper.GetOpenConnection())
            {
                if (conn == null) return;

                string query = @"
SELECT 
    b.бренд AS 'Бренд',
    SUM(s.количество * s.цена) AS 'Сумма продаж'
FROM 
    dbo.продажи s
JOIN 
    dbo.товар p ON s.товар = p.код_товара
JOIN 
    dbo.бренд b ON p.бренд = b.код_бренд
WHERE 
    p.наименование = (
        SELECT код_наименование FROM dbo.наименование WHERE наименование = @productName
    )
GROUP BY 
    b.бренд
ORDER BY 
    [Сумма продаж] DESC;";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@productName", selectedName);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    reportData = new DataTable();
                    adapter.Fill(reportData);
                    dataGridView1.DataSource = reportData;
                }
            }

            if (reportData.Rows.Count == 0)
            {
                chart1.Visible = false;
                labelNoData.Visible = true;
            }
            else
            {
                labelNoData.Visible = false;
                chart1.Visible = true;
                UpdateChart(reportData);
            }
        }

        private void UpdateChart(DataTable data)
        {
            chart1.Series["Сумма"].Points.Clear();

            foreach (DataRow row in data.Rows)
            {
                string brand = row["Бренд"].ToString();
                decimal amount = Convert.ToDecimal(row["Сумма продаж"]);
                chart1.Series["Сумма"].Points.AddXY(brand, amount);
            }
        }
    }
}
