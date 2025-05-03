using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsKorotkova.Forms
{
    public partial class ProductRatingForm : Form
    {
        private DataTable ratingData;

        public ProductRatingForm()
        {
            InitializeComponent();
        }

        private void ProductRatingForm_Load(object sender, EventArgs e)
        {
            LoadBrands();
            chart1.Visible = false;
            labelNoData.Visible = false;
        }

        private void LoadBrands()
        {
            using (var conn = DatabaseHelper.GetOpenConnection())
            {
                if (conn == null) return;

                var cmd = new SqlCommand("SELECT бренд FROM бренд ORDER BY бренд", conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxBrands.Items.Add(reader.GetString(0));
                }
            }
        }

        private void buttonShowRating_Click(object sender, EventArgs e)
        {
            if (comboBoxBrands.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите бренд.");
                return;
            }

            string selectedBrand = comboBoxBrands.SelectedItem.ToString();

            using (var conn = DatabaseHelper.GetOpenConnection())
            {
                if (conn == null) return;

                string query = @"
SELECT 
    b.бренд AS 'Бренд',
    n.наименование AS 'Наименование товара',
    cl.цвет AS 'Цвет',
    m.материал AS 'Материал',
    SUM(s.количество) AS 'Всего продано',
    DENSE_RANK() OVER (ORDER BY SUM(s.количество) DESC) AS 'Рейтинг популярности'
FROM 
    dbo.продажи s
JOIN 
    dbo.товар p ON s.товар = p.код_товара
JOIN 
    dbo.наименование n ON n.код_наименование = p.наименование
JOIN 
    dbo.материал m ON p.материал_обуви = m.код_материала
JOIN 
    dbo.цвет cl ON p.цвет = cl.код_цвета
JOIN 
    dbo.бренд b ON p.бренд = b.код_бренд
WHERE 
    b.бренд = @brandName
GROUP BY 
    b.бренд, n.наименование, cl.цвет, m.материал
ORDER BY 
    [Всего продано] DESC;
";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@brandName", selectedBrand);

                    var adapter = new SqlDataAdapter(cmd);
                    ratingData = new DataTable();
                    adapter.Fill(ratingData);
                    dataGridView1.DataSource = ratingData;

                    chart1.Visible = false;
                    labelNoData.Visible = false;
                }
            }
        }

        private void buttonDrawChart_Click(object sender, EventArgs e)
        {
            if (ratingData == null || ratingData.Rows.Count == 0)
            {
                chart1.Visible = false;
                labelNoData.Visible = true;
                return;
            }

            labelNoData.Visible = false;
            chart1.Visible = true;
            UpdateChart(ratingData);
        }

        private void UpdateChart(DataTable data)
        {
            chart1.Series["Продажи"].Points.Clear();

            foreach (DataRow row in data.Rows)
            {
                string productName = row["Наименование товара"].ToString();
                int totalSold = Convert.ToInt32(row["Всего продано"]);
                chart1.Series["Продажи"].Points.AddXY(productName, totalSold);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void labelNoData_Click(object sender, EventArgs e)
        {

        }
    }
}
