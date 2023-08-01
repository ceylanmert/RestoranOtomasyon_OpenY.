namespace RestoranOtomasyon
{
    partial class Register
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_KUnvan = new TextBox();
            txt_KSifre = new TextBox();
            txt_KAdSyoad = new TextBox();
            txt_phone = new TextBox();
            btn_register = new Button();
            btn_clear = new Button();
            label6 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // txt_KUnvan
            // 
            txt_KUnvan.BackColor = Color.LightGray;
            txt_KUnvan.BorderStyle = BorderStyle.None;
            txt_KUnvan.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_KUnvan.ForeColor = Color.Silver;
            txt_KUnvan.Location = new Point(75, 138);
            txt_KUnvan.Multiline = true;
            txt_KUnvan.Name = "txt_KUnvan";
            txt_KUnvan.Size = new Size(261, 34);
            txt_KUnvan.TabIndex = 5;
            txt_KUnvan.Text = "Ünvan";
            txt_KUnvan.Enter += txt_KUnvan_Enter;
            txt_KUnvan.Leave += txt_KUnvan_Leave;
            // 
            // txt_KSifre
            // 
            txt_KSifre.BackColor = Color.LightGray;
            txt_KSifre.BorderStyle = BorderStyle.None;
            txt_KSifre.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_KSifre.ForeColor = Color.Silver;
            txt_KSifre.Location = new Point(75, 215);
            txt_KSifre.Multiline = true;
            txt_KSifre.Name = "txt_KSifre";
            txt_KSifre.Size = new Size(261, 34);
            txt_KSifre.TabIndex = 6;
            txt_KSifre.Text = "TC";
            txt_KSifre.Enter += txt_KSifre_Enter;
            txt_KSifre.Leave += txt_KSifre_Leave;
            // 
            // txt_KAdSyoad
            // 
            txt_KAdSyoad.BackColor = Color.LightGray;
            txt_KAdSyoad.BorderStyle = BorderStyle.None;
            txt_KAdSyoad.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_KAdSyoad.ForeColor = Color.Silver;
            txt_KAdSyoad.Location = new Point(75, 291);
            txt_KAdSyoad.Multiline = true;
            txt_KAdSyoad.Name = "txt_KAdSyoad";
            txt_KAdSyoad.Size = new Size(261, 34);
            txt_KAdSyoad.TabIndex = 7;
            txt_KAdSyoad.Text = "Ad Soyad";
            txt_KAdSyoad.Enter += txt_KAdSyoad_Enter;
            txt_KAdSyoad.Leave += txt_KAdSyoad_Leave;
            // 
            // txt_phone
            // 
            txt_phone.BackColor = Color.LightGray;
            txt_phone.BorderStyle = BorderStyle.None;
            txt_phone.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_phone.ForeColor = Color.Silver;
            txt_phone.Location = new Point(75, 372);
            txt_phone.Multiline = true;
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(261, 34);
            txt_phone.TabIndex = 8;
            txt_phone.Text = "Telefon";
            txt_phone.Enter += txt_phone_Enter;
            txt_phone.Leave += txt_phone_Leave;
            // 
            // btn_register
            // 
            btn_register.BackColor = Color.DodgerBlue;
            btn_register.Font = new Font("NSimSun", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_register.ForeColor = Color.White;
            btn_register.Location = new Point(74, 444);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(261, 52);
            btn_register.TabIndex = 11;
            btn_register.Text = "Kayıt OL";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.White;
            btn_clear.Font = new Font("NSimSun", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_clear.ForeColor = Color.DodgerBlue;
            btn_clear.Location = new Point(74, 502);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(261, 43);
            btn_clear.TabIndex = 12;
            btn_clear.Text = "Temizle";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(112, 557);
            label6.Name = "label6";
            label6.Size = new Size(183, 16);
            label6.TabIndex = 13;
            label6.Text = "Zaten Hesabınız Var Mı ? ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Ebrima", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DodgerBlue;
            label7.Location = new Point(100, 589);
            label7.Name = "label7";
            label7.Size = new Size(195, 30);
            label7.TabIndex = 14;
            label7.Text = "Giriş Ekranına Dön";
            label7.Click += label7_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.register;
            pictureBox1.Location = new Point(122, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.loginpng1;
            pictureBox2.Location = new Point(1, 138);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 33;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.sifre1;
            pictureBox3.Location = new Point(1, 206);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(55, 43);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 34;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.name1;
            pictureBox4.Location = new Point(1, 282);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(55, 43);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 35;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.phone1;
            pictureBox5.Location = new Point(1, 363);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(55, 43);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 36;
            pictureBox5.TabStop = false;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(410, 628);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btn_clear);
            Controls.Add(btn_register);
            Controls.Add(txt_phone);
            Controls.Add(txt_KAdSyoad);
            Controls.Add(txt_KSifre);
            Controls.Add(txt_KUnvan);
            ForeColor = Color.White;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_KUnvan;
        private TextBox txt_KSifre;
        private TextBox txt_KAdSyoad;
        private TextBox txt_phone;
        private Button btn_register;
        private Button btn_clear;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}