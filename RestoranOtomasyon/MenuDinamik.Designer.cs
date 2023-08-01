namespace RestoranOtomasyon
{
    partial class MenuDinamik
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_UrunFiyat = new Label();
            btn_sepet = new Button();
            pictureBox_Resim = new PictureBox();
            lbl_KategoriID = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Resim).BeginInit();
            SuspendLayout();
            // 
            // lbl_UrunFiyat
            // 
            lbl_UrunFiyat.AutoSize = true;
            lbl_UrunFiyat.Font = new Font("Javanese Text", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_UrunFiyat.ForeColor = Color.Blue;
            lbl_UrunFiyat.Location = new Point(22, 219);
            lbl_UrunFiyat.Name = "lbl_UrunFiyat";
            lbl_UrunFiyat.Size = new Size(83, 47);
            lbl_UrunFiyat.TabIndex = 9;
            lbl_UrunFiyat.Text = "103 TL";
            // 
            // btn_sepet
            // 
            btn_sepet.BackColor = Color.Transparent;
            btn_sepet.FlatAppearance.BorderSize = 0;
            btn_sepet.FlatStyle = FlatStyle.Flat;
            btn_sepet.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_sepet.ForeColor = Color.Black;
            btn_sepet.Location = new Point(141, 219);
            btn_sepet.Name = "btn_sepet";
            btn_sepet.Size = new Size(119, 47);
            btn_sepet.TabIndex = 8;
            btn_sepet.Text = "Sepete Ekle";
            btn_sepet.UseVisualStyleBackColor = false;
            btn_sepet.Click += btn_sepet_Click;
            // 
            // pictureBox_Resim
            // 
            pictureBox_Resim.Location = new Point(22, 63);
            pictureBox_Resim.Name = "pictureBox_Resim";
            pictureBox_Resim.Size = new Size(238, 141);
            pictureBox_Resim.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Resim.TabIndex = 6;
            pictureBox_Resim.TabStop = false;
            // 
            // lbl_KategoriID
            // 
            lbl_KategoriID.AutoSize = true;
            lbl_KategoriID.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_KategoriID.Location = new Point(22, 22);
            lbl_KategoriID.Name = "lbl_KategoriID";
            lbl_KategoriID.Size = new Size(74, 26);
            lbl_KategoriID.TabIndex = 5;
            lbl_KategoriID.Text = "Burger";
            // 
            // MenuDinamik
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbl_UrunFiyat);
            Controls.Add(btn_sepet);
            Controls.Add(pictureBox_Resim);
            Controls.Add(lbl_KategoriID);
            Name = "MenuDinamik";
            Size = new Size(275, 288);
            ((System.ComponentModel.ISupportInitialize)pictureBox_Resim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_UrunFiyat;
        private Button btn_sepet;
        private PictureBox pictureBox_Resim;
        private Label lbl_KategoriID;
    }
}
