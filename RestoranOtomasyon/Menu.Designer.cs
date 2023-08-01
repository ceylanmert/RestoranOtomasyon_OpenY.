namespace RestoranOtomasyon
{
    partial class Menu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            panelMenu = new Panel();
            btn_logindon = new Button();
            ımageList1 = new ImageList(components);
            btn_admin = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            btn_mburger = new Button();
            button1 = new Button();
            panelTitleBar = new Panel();
            panel_adming = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            lbl_kullanici = new Label();
            btnMinimize = new Button();
            btn_exit = new Button();
            ıconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panelDesktop = new Panel();
            anaMenuDesing1 = new AnaMenuDesing();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTitleBar.SuspendLayout();
            panel_adming.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ıconCurrentChildForm).BeginInit();
            panelDesktop.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(btn_logindon);
            panelMenu.Controls.Add(btn_admin);
            panelMenu.Controls.Add(panel1);
            panelMenu.Controls.Add(button8);
            panelMenu.Controls.Add(button7);
            panelMenu.Controls.Add(button6);
            panelMenu.Controls.Add(button5);
            panelMenu.Controls.Add(button4);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(btn_mburger);
            panelMenu.Controls.Add(button1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 749);
            panelMenu.TabIndex = 0;
            // 
            // btn_logindon
            // 
            btn_logindon.BackColor = Color.White;
            btn_logindon.FlatAppearance.BorderSize = 0;
            btn_logindon.FlatStyle = FlatStyle.Flat;
            btn_logindon.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_logindon.ForeColor = Color.FromArgb(239, 119, 18);
            btn_logindon.ImageAlign = ContentAlignment.MiddleLeft;
            btn_logindon.ImageIndex = 10;
            btn_logindon.ImageList = ımageList1;
            btn_logindon.Location = new Point(0, 619);
            btn_logindon.Name = "btn_logindon";
            btn_logindon.Size = new Size(217, 60);
            btn_logindon.TabIndex = 10;
            btn_logindon.Text = "Login";
            btn_logindon.UseVisualStyleBackColor = false;
            btn_logindon.Click += btn_logindon_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "burger.png");
            ımageList1.Images.SetKeyName(1, "energy-drink.png");
            ımageList1.Images.SetKeyName(2, "hot-soup.png");
            ımageList1.Images.SetKeyName(3, "meat.png");
            ımageList1.Images.SetKeyName(4, "menu.png");
            ımageList1.Images.SetKeyName(5, "salad.png");
            ımageList1.Images.SetKeyName(6, "spaguetti.png");
            ımageList1.Images.SetKeyName(7, "sweets.png");
            ımageList1.Images.SetKeyName(8, "admin.png");
            ımageList1.Images.SetKeyName(9, "user.png");
            ımageList1.Images.SetKeyName(10, "loginuser.png");
            ımageList1.Images.SetKeyName(11, "menuburgers.png");
            ımageList1.Images.SetKeyName(12, "whiteadmin.png");
            // 
            // btn_admin
            // 
            btn_admin.BackColor = Color.White;
            btn_admin.Enabled = false;
            btn_admin.FlatAppearance.BorderSize = 0;
            btn_admin.FlatStyle = FlatStyle.Flat;
            btn_admin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_admin.ForeColor = Color.FromArgb(239, 119, 18);
            btn_admin.ImageAlign = ContentAlignment.MiddleLeft;
            btn_admin.ImageIndex = 9;
            btn_admin.ImageList = ımageList1;
            btn_admin.Location = new Point(0, 686);
            btn_admin.Name = "btn_admin";
            btn_admin.Size = new Size(217, 60);
            btn_admin.TabIndex = 9;
            btn_admin.Text = "Admin";
            btn_admin.UseVisualStyleBackColor = false;
            btn_admin.Click += btn_admin_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 85);
            panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.restaurant;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.FromArgb(239, 119, 18);
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.ImageIndex = 1;
            button8.ImageList = ımageList1;
            button8.Location = new Point(3, 553);
            button8.Name = "button8";
            button8.Size = new Size(217, 60);
            button8.TabIndex = 7;
            button8.Text = "İÇECEKLER";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.FromArgb(239, 119, 18);
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.ImageIndex = 7;
            button7.ImageList = ımageList1;
            button7.Location = new Point(3, 487);
            button7.Name = "button7";
            button7.Size = new Size(217, 60);
            button7.TabIndex = 6;
            button7.Text = "TATLILAR";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.FromArgb(239, 119, 18);
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.ImageIndex = 2;
            button6.ImageList = ımageList1;
            button6.Location = new Point(3, 421);
            button6.Name = "button6";
            button6.Size = new Size(220, 60);
            button6.TabIndex = 5;
            button6.Text = "ÇORBALAR";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(239, 119, 18);
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.ImageIndex = 5;
            button5.ImageList = ımageList1;
            button5.Location = new Point(3, 355);
            button5.Name = "button5";
            button5.Size = new Size(220, 60);
            button5.TabIndex = 4;
            button5.Text = "SALATALAR";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(239, 119, 18);
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.ImageIndex = 3;
            button4.ImageList = ımageList1;
            button4.Location = new Point(3, 289);
            button4.Name = "button4";
            button4.Size = new Size(220, 60);
            button4.TabIndex = 3;
            button4.Text = "ET YEMEKLERİ";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(239, 119, 18);
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.ImageIndex = 6;
            button3.ImageList = ımageList1;
            button3.Location = new Point(3, 223);
            button3.Name = "button3";
            button3.Size = new Size(220, 60);
            button3.TabIndex = 2;
            button3.Text = "MAKARNALAR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btn_mburger
            // 
            btn_mburger.BackColor = Color.White;
            btn_mburger.FlatAppearance.BorderSize = 0;
            btn_mburger.FlatStyle = FlatStyle.Flat;
            btn_mburger.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_mburger.ForeColor = Color.FromArgb(239, 119, 18);
            btn_mburger.ImageAlign = ContentAlignment.MiddleLeft;
            btn_mburger.ImageIndex = 11;
            btn_mburger.ImageList = ımageList1;
            btn_mburger.Location = new Point(3, 157);
            btn_mburger.Name = "btn_mburger";
            btn_mburger.Size = new Size(217, 60);
            btn_mburger.TabIndex = 1;
            btn_mburger.Text = "HAMBURGERELR";
            btn_mburger.UseVisualStyleBackColor = false;
            btn_mburger.Click += btn_mburger_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(239, 119, 18);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.ImageIndex = 4;
            button1.ImageList = ımageList1;
            button1.Location = new Point(3, 91);
            button1.Name = "button1";
            button1.Size = new Size(217, 60);
            button1.TabIndex = 0;
            button1.Text = "Tüm Menü";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(240, 132, 41);
            panelTitleBar.Controls.Add(panel_adming);
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(btn_exit);
            panelTitleBar.Controls.Add(ıconCurrentChildForm);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(870, 85);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // panel_adming
            // 
            panel_adming.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel_adming.AutoSize = true;
            panel_adming.Controls.Add(label1);
            panel_adming.Controls.Add(pictureBox2);
            panel_adming.Controls.Add(lbl_kullanici);
            panel_adming.Location = new Point(718, 30);
            panel_adming.Name = "panel_adming";
            panel_adming.Size = new Size(149, 49);
            panel_adming.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(39, 30);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 5;
            label1.Text = "Giriş Yaptı";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.whiteadmin;
            pictureBox2.Location = new Point(3, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // lbl_kullanici
            // 
            lbl_kullanici.AutoSize = true;
            lbl_kullanici.Font = new Font("Gill Sans Ultra Bold", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_kullanici.ForeColor = Color.White;
            lbl_kullanici.Location = new Point(39, 12);
            lbl_kullanici.Name = "lbl_kullanici";
            lbl_kullanici.Size = new Size(103, 18);
            lbl_kullanici.TabIndex = 4;
            lbl_kullanici.Text = "Kullanıcı Adı :";
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(787, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(37, 26);
            btnMinimize.TabIndex = 3;
            btnMinimize.Text = "-";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btn_exit
            // 
            btn_exit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_exit.FlatAppearance.BorderSize = 0;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_exit.ForeColor = Color.White;
            btn_exit.Location = new Point(830, 3);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(37, 26);
            btn_exit.TabIndex = 1;
            btn_exit.Text = "X";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // ıconCurrentChildForm
            // 
            ıconCurrentChildForm.BackColor = Color.FromArgb(240, 132, 41);
            ıconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            ıconCurrentChildForm.IconColor = Color.White;
            ıconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconCurrentChildForm.IconSize = 41;
            ıconCurrentChildForm.Location = new Point(18, 23);
            ıconCurrentChildForm.Name = "ıconCurrentChildForm";
            ıconCurrentChildForm.Size = new Size(42, 41);
            ıconCurrentChildForm.TabIndex = 0;
            ıconCurrentChildForm.TabStop = false;
            // 
            // panelDesktop
            // 
            panelDesktop.Controls.Add(anaMenuDesing1);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(220, 85);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(870, 664);
            panelDesktop.TabIndex = 2;
            // 
            // anaMenuDesing1
            // 
            anaMenuDesing1.Dock = DockStyle.Fill;
            anaMenuDesing1.Enabled = false;
            anaMenuDesing1.Location = new Point(0, 0);
            anaMenuDesing1.Name = "anaMenuDesing1";
            anaMenuDesing1.Size = new Size(870, 664);
            anaMenuDesing1.TabIndex = 0;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 749);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "Menu";
            Text = "Menu";
            WindowState = FormWindowState.Maximized;
            Load += Menu_Load;
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panel_adming.ResumeLayout(false);
            panel_adming.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ıconCurrentChildForm).EndInit();
            panelDesktop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button button1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button btn_mburger;
        private Panel panel1;
        private Button button8;
        private Button button7;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox ıconCurrentChildForm;
        private Button btn_exit;
        private Button btnMinimize;
        private ImageList ımageList1;
        private Panel panelDesktop;
        private AnaMenuDesing anaMenuDesing1;
        public Button btn_admin;
        public Button btn_logindon;
        public Panel panelTitleBar;
        public Label lbl_kullanici;
        private Panel panel_adming;
        private Label label1;
        private PictureBox pictureBox2;
    }
}