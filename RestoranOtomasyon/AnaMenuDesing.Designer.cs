namespace RestoranOtomasyon
{
    partial class AnaMenuDesing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaMenuDesing));
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FloralWhite;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 486);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(34, 214);
            label5.Name = "label5";
            label5.Size = new Size(289, 58);
            label5.TabIndex = 5;
            label5.Text = "Hamburger";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(239, 119, 18);
            label4.Location = new Point(34, 166);
            label4.Name = "label4";
            label4.Size = new Size(144, 23);
            label4.TabIndex = 4;
            label4.Text = "En İyi FİYAT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(239, 119, 18);
            label2.Location = new Point(34, 124);
            label2.Name = "label2";
            label2.Size = new Size(263, 23);
            label2.TabIndex = 2;
            label2.Text = "HER ZAMAN EN İYİ TAT";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 11.9999981F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(239, 119, 18);
            label1.Location = new Point(34, 311);
            label1.Name = "label1";
            label1.Size = new Size(484, 126);
            label1.TabIndex = 1;
            label1.Text = resources.GetString("label1.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.hamburger;
            pictureBox1.Location = new Point(371, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(452, 279);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // AnaMenuDesing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "AnaMenuDesing";
            Size = new Size(850, 486);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
    }
}
