using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsKorotkova.Forms
{
    partial class SalesSummaryForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label labelNoData;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.comboBoxProducts = new System.Windows.Forms.ComboBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelNoData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(12, 12);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(240, 21);
            this.comboBoxProducts.TabIndex = 0;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(270, 10);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(150, 25);
            this.buttonGenerate.TabIndex = 1;
            this.buttonGenerate.Text = "Показать отчёт";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 146);
            this.dataGridView1.TabIndex = 2;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 236);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Сумма";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(600, 300);
            this.chart1.TabIndex = 4;
            title2.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            title2.Name = "Title1";
            title2.Text = "График общей суммы продаж каждого бренда";
            this.chart1.Titles.Add(title2);
            this.chart1.Visible = false;
            // 
            // labelNoData
            // 
            this.labelNoData.AutoSize = true;
            this.labelNoData.ForeColor = System.Drawing.Color.DarkRed;
            this.labelNoData.Location = new System.Drawing.Point(9, 211);
            this.labelNoData.Name = "labelNoData";
            this.labelNoData.Size = new System.Drawing.Size(195, 13);
            this.labelNoData.TabIndex = 3;
            this.labelNoData.Text = "Нет данных для построения графика";
            this.labelNoData.Visible = false;
            // 
            // SalesSummaryForm
            // 
            this.ClientSize = new System.Drawing.Size(640, 548);
            this.Controls.Add(this.comboBoxProducts);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelNoData);
            this.Controls.Add(this.chart1);
            this.Name = "SalesSummaryForm";
            this.Text = "Суммарные продажи по брендам";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
