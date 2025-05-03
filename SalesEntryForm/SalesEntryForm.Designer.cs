namespace WindowsFormsKorotkova.Forms
{
    partial class SalesEntryForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.ComboBox comboBoxMaterial;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridViewSales;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.Label labelEmployee;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button buttonShowSales; // Новая кнопка для отображения таблицы

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridViewSales = new System.Windows.Forms.DataGridView();
            this.buttonShowSales = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.labelEmployee = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxName
            // 
            this.comboBoxName.Location = new System.Drawing.Point(150, 10);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(121, 21);
            this.comboBoxName.TabIndex = 0;
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.Location = new System.Drawing.Point(150, 50);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBrand.TabIndex = 1;
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.Location = new System.Drawing.Point(150, 90);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxColor.TabIndex = 2;
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.Location = new System.Drawing.Point(150, 130);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMaterial.TabIndex = 3;
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.Location = new System.Drawing.Point(150, 170);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEmployee.TabIndex = 4;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(150, 210);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 5;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(150, 250);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantity.TabIndex = 6;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(150, 290);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 7;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(150, 330);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Сохранить продажу";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridViewSales
            // 
            this.dataGridViewSales.Location = new System.Drawing.Point(20, 380);
            this.dataGridViewSales.Name = "dataGridViewSales";
            this.dataGridViewSales.Size = new System.Drawing.Size(600, 200);
            this.dataGridViewSales.TabIndex = 10;
            this.dataGridViewSales.Visible = false;
            // 
            // buttonShowSales
            // 
            this.buttonShowSales.Location = new System.Drawing.Point(320, 330);
            this.buttonShowSales.Name = "buttonShowSales";
            this.buttonShowSales.Size = new System.Drawing.Size(172, 23);
            this.buttonShowSales.TabIndex = 9;
            this.buttonShowSales.Text = "Вывести таблицу продаж";
            this.buttonShowSales.Click += new System.EventHandler(this.buttonShowSales_Click);
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(20, 10);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(100, 23);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "Наименование";
            // 
            // labelBrand
            // 
            this.labelBrand.Location = new System.Drawing.Point(20, 50);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(100, 23);
            this.labelBrand.TabIndex = 12;
            this.labelBrand.Text = "Бренд";
            // 
            // labelColor
            // 
            this.labelColor.Location = new System.Drawing.Point(20, 90);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(100, 23);
            this.labelColor.TabIndex = 13;
            this.labelColor.Text = "Цвет";
            // 
            // labelMaterial
            // 
            this.labelMaterial.Location = new System.Drawing.Point(20, 130);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(100, 23);
            this.labelMaterial.TabIndex = 14;
            this.labelMaterial.Text = "Материал";
            // 
            // labelEmployee
            // 
            this.labelEmployee.Location = new System.Drawing.Point(20, 170);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(100, 23);
            this.labelEmployee.TabIndex = 15;
            this.labelEmployee.Text = "Сотрудник";
            // 
            // labelPrice
            // 
            this.labelPrice.Location = new System.Drawing.Point(20, 210);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(100, 23);
            this.labelPrice.TabIndex = 16;
            this.labelPrice.Text = "Цена";
            // 
            // labelQuantity
            // 
            this.labelQuantity.Location = new System.Drawing.Point(20, 250);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(100, 23);
            this.labelQuantity.TabIndex = 17;
            this.labelQuantity.Text = "Количество";
            // 
            // labelDate
            // 
            this.labelDate.Location = new System.Drawing.Point(20, 290);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(100, 23);
            this.labelDate.TabIndex = 18;
            this.labelDate.Text = "Дата продажи";
            // 
            // SalesEntryForm
            // 
            this.ClientSize = new System.Drawing.Size(650, 600);
            this.Controls.Add(this.comboBoxName);
            this.Controls.Add(this.comboBoxBrand);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.comboBoxMaterial);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonShowSales);
            this.Controls.Add(this.dataGridViewSales);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.labelMaterial);
            this.Controls.Add(this.labelEmployee);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelDate);
            this.Name = "SalesEntryForm";
            this.Text = "Добавление продажи";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
