namespace BestBuy_Proyecto
{
    partial class ProductDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnBack = new System.Windows.Forms.Button();
            this.chartEarning = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTop3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartStock = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartEarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTop3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(838, 473);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Regresar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // chartEarning
            // 
            chartArea1.Name = "ChartArea1";
            this.chartEarning.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartEarning.Legends.Add(legend1);
            this.chartEarning.Location = new System.Drawing.Point(510, 210);
            this.chartEarning.Name = "chartEarning";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartEarning.Series.Add(series1);
            this.chartEarning.Size = new System.Drawing.Size(393, 257);
            this.chartEarning.TabIndex = 12;
            this.chartEarning.Text = "chart3";
            // 
            // chartTop3
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTop3.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartTop3.Legends.Add(legend2);
            this.chartTop3.Location = new System.Drawing.Point(238, 244);
            this.chartTop3.Name = "chartTop3";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartTop3.Series.Add(series2);
            this.chartTop3.Size = new System.Drawing.Size(266, 208);
            this.chartTop3.TabIndex = 11;
            this.chartTop3.Text = "Top 3 Productos vendidos";
            // 
            // chartStock
            // 
            chartArea3.Name = "ChartArea1";
            this.chartStock.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartStock.Legends.Add(legend3);
            this.chartStock.Location = new System.Drawing.Point(12, 259);
            this.chartStock.Name = "chartStock";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartStock.Series.Add(series3);
            this.chartStock.Size = new System.Drawing.Size(220, 182);
            this.chartStock.TabIndex = 10;
            this.chartStock.Text = "chart1";
            // 
            // picProduct
            // 
            this.picProduct.Image = global::BestBuy_Proyecto.Properties.Resources.aLaptop1;
            this.picProduct.Location = new System.Drawing.Point(381, 67);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(174, 124);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduct.TabIndex = 9;
            this.picProduct.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(276, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbSearch
            // 
            this.cmbSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(357, 18);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(281, 21);
            this.cmbSearch.TabIndex = 7;
            // 
            // ProductDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(915, 498);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.chartEarning);
            this.Controls.Add(this.chartTop3);
            this.Controls.Add(this.chartStock);
            this.Controls.Add(this.picProduct);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbSearch);
            this.Name = "ProductDashboard";
            this.Text = "ProductDashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductDashboard_FormClosing);
            this.Load += new System.EventHandler(this.ProductDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartEarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTop3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEarning;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTop3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStock;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbSearch;
    }
}