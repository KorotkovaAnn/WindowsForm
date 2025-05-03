namespace WindowsFormsKorotkova.Forms
{
    partial class ProductRatingForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxBrands;
        private System.Windows.Forms.Button buttonShowRating;
        private System.Windows.Forms.Button buttonDrawChart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label labelNoData;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.comboBoxBrands = new System.Windows.Forms.ComboBox();
            this.buttonShowRating = new System.Windows.Forms.Button();
            this.buttonDrawChart = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelNoData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxBrands
            // 
            this.comboBoxBrands.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBrands.FormattingEnabled = true;
            this.comboBoxBrands.Location = new System.Drawing.Point(9, 10);
            this.comboBoxBrands.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxBrands.Name = "comboBoxBrands";
            this.comboBoxBrands.Size = new System.Drawing.Size(188, 21);
            this.comboBoxBrands.TabIndex = 0;
            // 
            // buttonShowRating
            // 
            this.buttonShowRating.Location = new System.Drawing.Point(210, 10);
            this.buttonShowRating.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonShowRating.Name = "buttonShowRating";
            this.buttonShowRating.Size = new System.Drawing.Size(112, 20);
            this.buttonShowRating.TabIndex = 1;
            this.buttonShowRating.Text = "Показать рейтинг";
            this.buttonShowRating.UseVisualStyleBackColor = true;
            this.buttonShowRating.Click += new System.EventHandler(this.buttonShowRating_Click);
            // 
            // buttonDrawChart
            // 
            this.buttonDrawChart.Location = new System.Drawing.Point(338, 10);
            this.buttonDrawChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDrawChart.Name = "buttonDrawChart";
            this.buttonDrawChart.Size = new System.Drawing.Size(159, 20);
            this.buttonDrawChart.TabIndex = 4;
            this.buttonDrawChart.Text = "Нарисовать график";
            this.buttonDrawChart.UseVisualStyleBackColor = true;
            this.buttonDrawChart.Click += new System.EventHandler(this.buttonDrawChart_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 41);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(570, 181);
            this.dataGridView1.TabIndex = 2;
            // 
            // chart1
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);

            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Name = "Продажи";
            this.chart1.Series.Add(series2);

            // Добавление заголовка графика
            System.Windows.Forms.DataVisualization.Charting.Title chartTitle = new System.Windows.Forms.DataVisualization.Charting.Title();
            chartTitle.Text = "График рейтинга товаров выбранного бренда";
            chartTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            chartTitle.Alignment = System.Drawing.ContentAlignment.TopCenter;
            this.chart1.Titles.Add(chartTitle);

            this.chart1.Location = new System.Drawing.Point(7, 256);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(570, 244);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // labelNoData
            // 
            this.labelNoData.AutoSize = true;
            this.labelNoData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelNoData.ForeColor = System.Drawing.Color.DarkRed;
            this.labelNoData.Location = new System.Drawing.Point(11, 237);
            this.labelNoData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNoData.Name = "labelNoData";
            this.labelNoData.Size = new System.Drawing.Size(172, 17);
            this.labelNoData.TabIndex = 5;
            this.labelNoData.Text = "Нет данных для графика";
            this.labelNoData.Visible = false;
            this.labelNoData.Click += new System.EventHandler(this.labelNoData_Click);
            // 
            // ProductRatingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 511);
            this.Controls.Add(this.labelNoData);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonDrawChart);
            this.Controls.Add(this.buttonShowRating);
            this.Controls.Add(this.comboBoxBrands);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ProductRatingForm";
            this.Text = "Рейтинг товаров по бренду";
            this.Load += new System.EventHandler(this.ProductRatingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
