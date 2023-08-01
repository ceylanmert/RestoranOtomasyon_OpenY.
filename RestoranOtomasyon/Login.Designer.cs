namespace RestoranOtomasyon
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            lbl_GDon = new Label();
            lbl_GHesapVar = new Label();
            btn_GClear = new Button();
            btn_Login = new Button();
            checkBox_SGoster = new CheckBox();
            txt_GSifre = new TextBox();
            txt_GUnvan = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lbl_GDon
            // 
            lbl_GDon.AutoSize = true;
            lbl_GDon.Font = new Font("Ebrima", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_GDon.ForeColor = Color.Purple;
            lbl_GDon.Location = new Point(141, 534);
            lbl_GDon.Name = "lbl_GDon";
            lbl_GDon.Size = new Size(83, 30);
            lbl_GDon.TabIndex = 28;
            lbl_GDon.Text = "Üye OL";
            lbl_GDon.Click += lbl_GDon_Click;
            // 
            // lbl_GHesapVar
            // 
            lbl_GHesapVar.AutoSize = true;
            lbl_GHesapVar.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_GHesapVar.ForeColor = Color.Black;
            lbl_GHesapVar.Location = new Point(114, 504);
            lbl_GHesapVar.Name = "lbl_GHesapVar";
            lbl_GHesapVar.Size = new Size(149, 21);
            lbl_GHesapVar.TabIndex = 27;
            lbl_GHesapVar.Text = "Hesabın Yok Mu ? ";
            // 
            // btn_GClear
            // 
            btn_GClear.BackColor = Color.White;
            btn_GClear.Font = new Font("NSimSun", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_GClear.ForeColor = Color.DodgerBlue;
            btn_GClear.Location = new Point(58, 440);
            btn_GClear.Name = "btn_GClear";
            btn_GClear.Size = new Size(278, 49);
            btn_GClear.TabIndex = 26;
            btn_GClear.Text = "Temizle";
            btn_GClear.UseVisualStyleBackColor = false;
            btn_GClear.Click += btn_GClear_Click;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.DodgerBlue;
            btn_Login.Font = new Font("NSimSun", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Login.ForeColor = Color.White;
            btn_Login.Location = new Point(58, 385);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(278, 49);
            btn_Login.TabIndex = 25;
            btn_Login.Text = "Giriş Yap";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // checkBox_SGoster
            // 
            checkBox_SGoster.AutoSize = true;
            checkBox_SGoster.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox_SGoster.ForeColor = Color.Purple;
            checkBox_SGoster.Location = new Point(264, 352);
            checkBox_SGoster.Name = "checkBox_SGoster";
            checkBox_SGoster.Size = new Size(85, 27);
            checkBox_SGoster.TabIndex = 24;
            checkBox_SGoster.Text = "Göster";
            checkBox_SGoster.UseVisualStyleBackColor = true;
            checkBox_SGoster.CheckedChanged += checkBox_SGoster_CheckedChanged;
            // 
            // txt_GSifre
            // 
            txt_GSifre.BackColor = Color.LightGray;
            txt_GSifre.BorderStyle = BorderStyle.None;
            txt_GSifre.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_GSifre.ForeColor = Color.Silver;
            txt_GSifre.Location = new Point(88, 297);
            txt_GSifre.Multiline = true;
            txt_GSifre.Name = "txt_GSifre";
            txt_GSifre.PasswordChar = '*';
            txt_GSifre.Size = new Size(261, 34);
            txt_GSifre.TabIndex = 21;
            txt_GSifre.Text = "Şifre";
            txt_GSifre.Enter += txt_GSifre_Enter;
            txt_GSifre.Leave += txt_GSifre_Leave;
            // 
            // txt_GUnvan
            // 
            txt_GUnvan.BackColor = Color.LightGray;
            txt_GUnvan.BorderStyle = BorderStyle.None;
            txt_GUnvan.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_GUnvan.ForeColor = Color.Silver;
            txt_GUnvan.Location = new Point(88, 214);
            txt_GUnvan.Multiline = true;
            txt_GUnvan.Name = "txt_GUnvan";
            txt_GUnvan.Size = new Size(261, 34);
            txt_GUnvan.TabIndex = 20;
            txt_GUnvan.Text = "Unvan";
            txt_GUnvan.Enter += txt_GUnvan_Enter;
            txt_GUnvan.Leave += txt_GUnvan_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(88, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.sifre1;
            pictureBox3.Location = new Point(12, 288);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(55, 43);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 31;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.loginpng1;
            pictureBox2.Location = new Point(11, 208);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(384, 602);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_GDon);
            Controls.Add(lbl_GHesapVar);
            Controls.Add(btn_GClear);
            Controls.Add(btn_Login);
            Controls.Add(checkBox_SGoster);
            Controls.Add(txt_GSifre);
            Controls.Add(txt_GUnvan);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_GDon;
        private Label lbl_GHesapVar;
        private Button btn_GClear;
        private Button btn_Login;
        private CheckBox checkBox_SGoster;
        private TextBox txt_GSifre;
        private TextBox txt_GUnvan;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}