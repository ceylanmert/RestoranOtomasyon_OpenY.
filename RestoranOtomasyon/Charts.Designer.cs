namespace RestoranOtomasyon
{
    partial class frm_grafik
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
            grafik_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btn_burger = new Button();
            btn_makarna = new Button();
            btn_et = new Button();
            btn_Salata = new Button();
            btn_Corba = new Button();
            btn_Tatli = new Button();
            btn_icecek = new Button();
            btn_coksatan = new Button();
            ((System.ComponentModel.ISupportInitialize)grafik_chart).BeginInit();
            SuspendLayout();
            // 
            // grafik_chart
            // 
            chartArea1.Name = "ChartArea1";
            grafik_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            grafik_chart.Legends.Add(legend1);
            grafik_chart.Location = new Point(12, 12);
            grafik_chart.Name = "grafik_chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.LabelForeColor = Color.Transparent;
            series1.Legend = "Legend1";
            series1.Name = "Burger";
            series1.SmartLabelStyle.CalloutLineColor = Color.Transparent;
            grafik_chart.Series.Add(series1);
            grafik_chart.Size = new Size(543, 323);
            grafik_chart.TabIndex = 0;
            grafik_chart.Text = "chart1";
            // 
            // btn_burger
            // 
            btn_burger.Location = new Point(12, 350);
            btn_burger.Name = "btn_burger";
            btn_burger.Size = new Size(96, 39);
            btn_burger.TabIndex = 1;
            btn_burger.Text = "Burger";
            btn_burger.UseVisualStyleBackColor = true;
            btn_burger.Click += btn_burger_Click;
            // 
            // btn_makarna
            // 
            btn_makarna.Location = new Point(114, 350);
            btn_makarna.Name = "btn_makarna";
            btn_makarna.Size = new Size(96, 39);
            btn_makarna.TabIndex = 2;
            btn_makarna.Text = "Makarna";
            btn_makarna.UseVisualStyleBackColor = true;
            btn_makarna.Click += btn_makarna_Click;
            // 
            // btn_et
            // 
            btn_et.Location = new Point(216, 350);
            btn_et.Name = "btn_et";
            btn_et.Size = new Size(96, 39);
            btn_et.TabIndex = 3;
            btn_et.Text = "Et Yemekleri";
            btn_et.UseVisualStyleBackColor = true;
            btn_et.Click += btn_et_Click;
            // 
            // btn_Salata
            // 
            btn_Salata.Location = new Point(318, 350);
            btn_Salata.Name = "btn_Salata";
            btn_Salata.Size = new Size(96, 39);
            btn_Salata.TabIndex = 4;
            btn_Salata.Text = "Salata";
            btn_Salata.UseVisualStyleBackColor = true;
            btn_Salata.Click += btn_Salata_Click;
            // 
            // btn_Corba
            // 
            btn_Corba.Location = new Point(420, 350);
            btn_Corba.Name = "btn_Corba";
            btn_Corba.Size = new Size(96, 39);
            btn_Corba.TabIndex = 5;
            btn_Corba.Text = "Corba";
            btn_Corba.UseVisualStyleBackColor = true;
            btn_Corba.Click += btn_Corba_Click;
            // 
            // btn_Tatli
            // 
            btn_Tatli.Location = new Point(12, 395);
            btn_Tatli.Name = "btn_Tatli";
            btn_Tatli.Size = new Size(96, 39);
            btn_Tatli.TabIndex = 6;
            btn_Tatli.Text = "Tatlı";
            btn_Tatli.UseVisualStyleBackColor = true;
            btn_Tatli.Click += btn_Tatli_Click;
            // 
            // btn_icecek
            // 
            btn_icecek.Location = new Point(114, 395);
            btn_icecek.Name = "btn_icecek";
            btn_icecek.Size = new Size(96, 39);
            btn_icecek.TabIndex = 7;
            btn_icecek.Text = "Icecek";
            btn_icecek.UseVisualStyleBackColor = true;
            btn_icecek.Click += btn_icecek_Click;
            // 
            // btn_coksatan
            // 
            btn_coksatan.Location = new Point(216, 395);
            btn_coksatan.Name = "btn_coksatan";
            btn_coksatan.Size = new Size(96, 39);
            btn_coksatan.TabIndex = 8;
            btn_coksatan.Text = "Çok Satanlar";
            btn_coksatan.UseVisualStyleBackColor = true;
            btn_coksatan.Click += btn_coksatan_Click;
            // 
            // frm_grafik
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(590, 450);
            Controls.Add(btn_coksatan);
            Controls.Add(btn_icecek);
            Controls.Add(btn_Tatli);
            Controls.Add(btn_Corba);
            Controls.Add(btn_Salata);
            Controls.Add(btn_et);
            Controls.Add(btn_makarna);
            Controls.Add(btn_burger);
            Controls.Add(grafik_chart);
            Name = "frm_grafik";
            Text = "Grafik";
            Load += frm_grafik_Load;
            ((System.ComponentModel.ISupportInitialize)grafik_chart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grafik_chart;
        private Button btn_burger;
        private Button btn_makarna;
        private Button btn_et;
        private Button btn_Salata;
        private Button btn_Corba;
        private Button btn_Tatli;
        private Button btn_icecek;
        private Button btn_coksatan;
    }
}