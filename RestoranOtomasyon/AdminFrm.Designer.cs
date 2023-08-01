namespace RestoranOtomasyon
{
    partial class AdminFrm
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
            label3 = new Label();
            txt_urunad = new TextBox();
            txt_urunfiyat = new TextBox();
            pictureBox_Resim = new PictureBox();
            btn_ekle = new Button();
            btn_sil = new Button();
            btn_guncelle = new Button();
            btn_resimekle = new Button();
            txt_kategori = new TextBox();
            label4 = new Label();
            txt_ID = new TextBox();
            label5 = new Label();
            datagird_verigetir = new DataGridView();
            btn_grafik = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Resim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datagird_verigetir).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 104);
            label1.Name = "label1";
            label1.Size = new Size(102, 22);
            label1.TabIndex = 0;
            label1.Text = "UrunAD : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(9, 153);
            label2.Name = "label2";
            label2.Size = new Size(136, 22);
            label2.TabIndex = 1;
            label2.Text = "Urun Fiyat : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(332, 18);
            label3.Name = "label3";
            label3.Size = new Size(227, 22);
            label3.TabIndex = 2;
            label3.Text = "Resim Değiştir / Yükle";
            // 
            // txt_urunad
            // 
            txt_urunad.Location = new Point(151, 104);
            txt_urunad.Name = "txt_urunad";
            txt_urunad.Size = new Size(134, 23);
            txt_urunad.TabIndex = 3;
            // 
            // txt_urunfiyat
            // 
            txt_urunfiyat.Location = new Point(151, 155);
            txt_urunfiyat.Name = "txt_urunfiyat";
            txt_urunfiyat.Size = new Size(134, 23);
            txt_urunfiyat.TabIndex = 4;
            // 
            // pictureBox_Resim
            // 
            pictureBox_Resim.Location = new Point(332, 61);
            pictureBox_Resim.Name = "pictureBox_Resim";
            pictureBox_Resim.Size = new Size(227, 121);
            pictureBox_Resim.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Resim.TabIndex = 5;
            pictureBox_Resim.TabStop = false;
            // 
            // btn_ekle
            // 
            btn_ekle.Location = new Point(28, 220);
            btn_ekle.Name = "btn_ekle";
            btn_ekle.Size = new Size(93, 43);
            btn_ekle.TabIndex = 6;
            btn_ekle.Text = "Ekle";
            btn_ekle.UseVisualStyleBackColor = true;
            btn_ekle.Click += btn_ekle_Click;
            // 
            // btn_sil
            // 
            btn_sil.Location = new Point(127, 220);
            btn_sil.Name = "btn_sil";
            btn_sil.Size = new Size(93, 43);
            btn_sil.TabIndex = 7;
            btn_sil.Text = "Sil";
            btn_sil.UseVisualStyleBackColor = true;
            btn_sil.Click += btn_sil_Click;
            // 
            // btn_guncelle
            // 
            btn_guncelle.Location = new Point(226, 220);
            btn_guncelle.Name = "btn_guncelle";
            btn_guncelle.Size = new Size(93, 43);
            btn_guncelle.TabIndex = 8;
            btn_guncelle.Text = "Güncelle";
            btn_guncelle.UseVisualStyleBackColor = true;
            btn_guncelle.Click += btn_guncelle_Click;
            // 
            // btn_resimekle
            // 
            btn_resimekle.Location = new Point(424, 220);
            btn_resimekle.Name = "btn_resimekle";
            btn_resimekle.Size = new Size(93, 43);
            btn_resimekle.TabIndex = 9;
            btn_resimekle.Text = "Resim Seç";
            btn_resimekle.UseVisualStyleBackColor = true;
            btn_resimekle.Click += btn_resimekle_Click;
            // 
            // txt_kategori
            // 
            txt_kategori.Location = new Point(151, 61);
            txt_kategori.MaxLength = 1;
            txt_kategori.Name = "txt_kategori";
            txt_kategori.Size = new Size(134, 23);
            txt_kategori.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(9, 61);
            label4.Name = "label4";
            label4.Size = new Size(114, 22);
            label4.TabIndex = 10;
            label4.Text = "Kategori :";
            // 
            // txt_ID
            // 
            txt_ID.Location = new Point(154, 20);
            txt_ID.Name = "txt_ID";
            txt_ID.ReadOnly = true;
            txt_ID.Size = new Size(134, 23);
            txt_ID.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 18);
            label5.Name = "label5";
            label5.Size = new Size(41, 22);
            label5.TabIndex = 12;
            label5.Text = "ID :";
            // 
            // datagird_verigetir
            // 
            datagird_verigetir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagird_verigetir.Location = new Point(12, 264);
            datagird_verigetir.Name = "datagird_verigetir";
            datagird_verigetir.RowTemplate.Height = 25;
            datagird_verigetir.Size = new Size(547, 194);
            datagird_verigetir.TabIndex = 14;
            datagird_verigetir.CellEnter += datagird_verigetir_CellEnter;
            // 
            // btn_grafik
            // 
            btn_grafik.Location = new Point(325, 220);
            btn_grafik.Name = "btn_grafik";
            btn_grafik.Size = new Size(93, 43);
            btn_grafik.TabIndex = 15;
            btn_grafik.Text = "Grafik Bak";
            btn_grafik.UseVisualStyleBackColor = true;
            btn_grafik.Click += button1_Click;
            // 
            // AdminFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(699, 510);
            Controls.Add(btn_grafik);
            Controls.Add(datagird_verigetir);
            Controls.Add(txt_ID);
            Controls.Add(label5);
            Controls.Add(txt_kategori);
            Controls.Add(label4);
            Controls.Add(btn_resimekle);
            Controls.Add(btn_guncelle);
            Controls.Add(btn_sil);
            Controls.Add(btn_ekle);
            Controls.Add(pictureBox_Resim);
            Controls.Add(txt_urunfiyat);
            Controls.Add(txt_urunad);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminFrm";
            Text = "AdminFrm";
            Load += AdminFrm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_Resim).EndInit();
            ((System.ComponentModel.ISupportInitialize)datagird_verigetir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_urunad;
        private TextBox txt_urunfiyat;
        private PictureBox pictureBox_Resim;
        private Button btn_ekle;
        private Button btn_sil;
        private Button btn_guncelle;
        private Button btn_resimekle;
        private TextBox txt_kategori;
        private Label label4;
        private TextBox txt_ID;
        private Label label5;
        private DataGridView datagird_verigetir;
        private Button btn_grafik;
    }
}