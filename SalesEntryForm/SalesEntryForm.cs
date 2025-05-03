using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsKorotkova.Forms
{
    public partial class SalesEntryForm : Form
    {
        public SalesEntryForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(SalesEntryForm_Load);
        }

        private void SalesEntryForm_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            LoadSalesData(); // Initially load sales data
        }

        private void LoadComboBoxes()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetOpenConnection())
                {
                    if (conn == null)
                    {
                        MessageBox.Show("Не удалось подключиться к базе данных.");
                        return;
                    }

                    void Load(string query, ComboBox comboBox, string displayField, string valueField)
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        comboBox.DataSource = dt;
                        comboBox.DisplayMember = displayField;
                        comboBox.ValueMember = valueField;

                        if (dt.Rows.Count == 0)
                            MessageBox.Show($"Пустой источник данных для {comboBox.Name}");
                    }

                    Load("SELECT код_наименование, наименование FROM наименование", comboBoxName, "наименование", "код_наименование");
                    Load("SELECT код_цвета, цвет FROM цвет", comboBoxColor, "цвет", "код_цвета");
                    Load("SELECT код_материала, материал FROM материал", comboBoxMaterial, "материал", "код_материала");
                    Load("SELECT код_бренд, бренд FROM бренд", comboBoxBrand, "бренд", "код_бренд");
                    Load("SELECT код_сотрудника, фамилия + ' ' + имя AS ФИО FROM сотрудники", comboBoxEmployee, "ФИО", "код_сотрудника");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке ComboBox: " + ex.Message);
            }
        }

        private int GetNextSaleId(SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand("SELECT MAX(CAST(код_продажи AS INT))+1 FROM продажи;", conn);
            return (int)cmd.ExecuteScalar();
        }

        private int GetProductId(SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand(@"
                SELECT TOP 1 код_товара FROM товар 
                WHERE наименование = @nameId AND цвет = @colorId AND материал_обуви = @materialId AND бренд = @brandId", conn);

            cmd.Parameters.AddWithValue("@nameId", comboBoxName.SelectedValue);
            cmd.Parameters.AddWithValue("@colorId", comboBoxColor.SelectedValue);
            cmd.Parameters.AddWithValue("@materialId", comboBoxMaterial.SelectedValue);
            cmd.Parameters.AddWithValue("@brandId", comboBoxBrand.SelectedValue);

            object result = cmd.ExecuteScalar();
            if (result == null)
            {
                MessageBox.Show("Товар с выбранными параметрами не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }

            return Convert.ToInt32(result);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(textBoxPrice.Text, out decimal price) ||
                !int.TryParse(textBoxQuantity.Text, out int quantity))
            {
                MessageBox.Show("Пожалуйста, введите корректные значения цены и количества.");
                return;
            }

            using (SqlConnection conn = DatabaseHelper.GetOpenConnection())
            {
                if (conn == null) return;

                int saleId = GetNextSaleId(conn);
                int productId = GetProductId(conn);

                if (productId == -1) return;

                SqlCommand cmd = new SqlCommand(@"
                    INSERT INTO продажи (код_продажи, товар, цена, количество, дата, сотрудник)
                    VALUES (@saleId, @productId, @price, @quantity, @date, @employeeId)", conn);

                cmd.Parameters.AddWithValue("@saleId", saleId);
                cmd.Parameters.AddWithValue("@productId", productId);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@date", dateTimePicker.Value.ToString("dd.MM.yyyy"));
                cmd.Parameters.AddWithValue("@employeeId", comboBoxEmployee.SelectedValue);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Продажа успешно добавлена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSalesData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при добавлении продажи: " + ex.Message);
                }
            }
        }

        private void LoadSalesData()
        {
            using (SqlConnection conn = DatabaseHelper.GetOpenConnection())
            {
                if (conn == null) return;

                SqlDataAdapter adapter = new SqlDataAdapter(@"
                    SELECT 
                        s.код_продажи, 
                        n.наименование AS Наименование, 
                        cl.цвет AS Цвет, 
                        m.материал AS Материал, 
                        b.бренд AS Бренд, 
                        s.цена, 
                        s.количество, 
                        s.дата, 
                        emp.фамилия + ' ' + emp.имя AS Сотрудник
                    FROM продажи s
                    JOIN товар t ON s.товар = t.код_товара
                    JOIN наименование n ON t.наименование = n.код_наименование
                    JOIN цвет cl ON t.цвет = cl.код_цвета
                    JOIN материал m ON t.материал_обуви = m.код_материала
                    JOIN бренд b ON t.бренд = b.код_бренд
                    JOIN сотрудники emp ON s.сотрудник = emp.код_сотрудника", conn);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Форматируем дату
                foreach (DataRow row in dt.Rows)
                {
                    if (row["дата"] is DateTime dtValue)
                    {
                        row["дата"] = dtValue.ToString("dd.MM.yyyy");
                    }
                }

                dataGridViewSales.DataSource = dt;
            }
        }

        private void buttonShowSales_Click(object sender, EventArgs e)
        {
            LoadSalesData();
            dataGridViewSales.Visible = true; // Показать таблицу при нажатии на кнопку
        }
    }
}
