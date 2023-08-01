namespace RestoranOtomasyon
{
    partial class IceceklerMenu
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
            panel_Icecek = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // panel_Icecek
            // 
            panel_Icecek.AutoScroll = true;
            panel_Icecek.Dock = DockStyle.Fill;
            panel_Icecek.Location = new Point(0, 0);
            panel_Icecek.Name = "panel_Icecek";
            panel_Icecek.Size = new Size(800, 450);
            panel_Icecek.TabIndex = 0;
            // 
            // IceceklerMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_Icecek);
            Name = "IceceklerMenu";
            Text = "IceceklerMenu";
            Load += IceceklerMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panel_Icecek;
    }
}