namespace RestoranOtomasyon
{
    partial class Contents
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
            label1 = new Label();
            label2 = new Label();
            PanelIcerik = new FlowLayoutPanel();
            PanelSepet = new Panel();
            panel1 = new Panel();
            btn_azalt = new Button();
            btn_arttir = new Button();
            lbl_Icerik = new Label();
            sepetLabel = new Label();
            label3 = new Label();
            btn_MutfakGonder = new Button();
            combobox_masano = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            combo_Terminal = new ComboBox();
            PanelSepet.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ink Free", 21.7499962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(177, 9);
            label1.Name = "label1";
            label1.Size = new Size(200, 36);
            label1.TabIndex = 1;
            label1.Text = "Lütfen Seçiniz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Ink Free", 21.7499962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Purple;
            label2.Location = new Point(765, 9);
            label2.Name = "label2";
            label2.Size = new Size(255, 36);
            label2.TabIndex = 2;
            label2.Text = "SEPET OLUŞTUR";
            // 
            // PanelIcerik
            // 
            PanelIcerik.AutoScroll = true;
            PanelIcerik.BackColor = Color.DarkOrange;
            PanelIcerik.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PanelIcerik.Location = new Point(12, 62);
            PanelIcerik.Name = "PanelIcerik";
            PanelIcerik.Size = new Size(573, 324);
            PanelIcerik.TabIndex = 4;
            // 
            // PanelSepet
            // 
            PanelSepet.BackColor = Color.DarkOrange;
            PanelSepet.Controls.Add(panel1);
            PanelSepet.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PanelSepet.ForeColor = Color.White;
            PanelSepet.Location = new Point(619, 62);
            PanelSepet.Name = "PanelSepet";
            PanelSepet.Size = new Size(536, 324);
            PanelSepet.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Coral;
            panel1.Controls.Add(btn_azalt);
            panel1.Controls.Add(btn_arttir);
            panel1.Controls.Add(lbl_Icerik);
            panel1.Controls.Add(sepetLabel);
            panel1.Controls.Add(label3);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 278);
            panel1.Name = "panel1";
            panel1.Size = new Size(536, 46);
            panel1.TabIndex = 2;
            // 
            // btn_azalt
            // 
            btn_azalt.FlatStyle = FlatStyle.Flat;
            btn_azalt.Location = new Point(257, 10);
            btn_azalt.Name = "btn_azalt";
            btn_azalt.Size = new Size(32, 25);
            btn_azalt.TabIndex = 5;
            btn_azalt.Text = "-";
            btn_azalt.UseVisualStyleBackColor = true;
            btn_azalt.Click += btn_azalt_Click;
            // 
            // btn_arttir
            // 
            btn_arttir.FlatStyle = FlatStyle.Flat;
            btn_arttir.Location = new Point(219, 10);
            btn_arttir.Name = "btn_arttir";
            btn_arttir.Size = new Size(32, 25);
            btn_arttir.TabIndex = 4;
            btn_arttir.Text = "+";
            btn_arttir.UseVisualStyleBackColor = true;
            btn_arttir.Click += btn_arttir_Click;
            // 
            // lbl_Icerik
            // 
            lbl_Icerik.AutoSize = true;
            lbl_Icerik.Font = new Font("Mongolian Baiti", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Icerik.ForeColor = Color.White;
            lbl_Icerik.Location = new Point(3, 10);
            lbl_Icerik.Name = "lbl_Icerik";
            lbl_Icerik.Size = new Size(92, 25);
            lbl_Icerik.TabIndex = 3;
            lbl_Icerik.Text = "İcerik : ";
            lbl_Icerik.Click += lbl_Icerik_Click;
            // 
            // sepetLabel
            // 
            sepetLabel.AutoSize = true;
            sepetLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            sepetLabel.ForeColor = Color.White;
            sepetLabel.Location = new Point(464, 10);
            sepetLabel.Name = "sepetLabel";
            sepetLabel.Size = new Size(49, 25);
            sepetLabel.TabIndex = 0;
            sepetLabel.Text = "0 TL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Mongolian Baiti", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(295, 10);
            label3.Name = "label3";
            label3.Size = new Size(163, 25);
            label3.TabIndex = 1;
            label3.Text = "Sepet Tutarı : ";
            // 
            // btn_MutfakGonder
            // 
            btn_MutfakGonder.Location = new Point(1021, 392);
            btn_MutfakGonder.Name = "btn_MutfakGonder";
            btn_MutfakGonder.Size = new Size(134, 46);
            btn_MutfakGonder.TabIndex = 6;
            btn_MutfakGonder.Text = "Sepete Ekle";
            btn_MutfakGonder.UseVisualStyleBackColor = true;
            btn_MutfakGonder.Click += btn_MutfakGonder_Click;
            // 
            // combobox_masano
            // 
            combobox_masano.FormattingEnabled = true;
            combobox_masano.Location = new Point(749, 398);
            combobox_masano.Name = "combobox_masano";
            combobox_masano.Size = new Size(121, 23);
            combobox_masano.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(634, 398);
            label4.Name = "label4";
            label4.Size = new Size(102, 18);
            label4.TabIndex = 8;
            label4.Text = "Masa Seçin : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(634, 438);
            label5.Name = "label5";
            label5.Size = new Size(89, 18);
            label5.TabIndex = 10;
            label5.Text = "Terminal :";
            // 
            // combo_Terminal
            // 
            combo_Terminal.FormattingEnabled = true;
            combo_Terminal.Location = new Point(749, 433);
            combo_Terminal.Name = "combo_Terminal";
            combo_Terminal.Size = new Size(121, 23);
            combo_Terminal.TabIndex = 9;
            // 
            // Contents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 474);
            Controls.Add(label5);
            Controls.Add(combo_Terminal);
            Controls.Add(label4);
            Controls.Add(combobox_masano);
            Controls.Add(btn_MutfakGonder);
            Controls.Add(PanelSepet);
            Controls.Add(PanelIcerik);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Contents";
            Text = "Contents";
            Load += Contents_Load;
            PanelSepet.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private FlowLayoutPanel PanelIcerik;
        private Panel PanelSepet;
        private Panel panel1;
        private Label label3;
        private Label lbl_Icerik;
        private Button btn_MutfakGonder;
        private Button btn_azalt;
        public Button btn_arttir;
        public Label sepetLabel;
        private ComboBox combobox_masano;
        private Label label4;
        private Label label5;
        private ComboBox combo_Terminal;
    }
}