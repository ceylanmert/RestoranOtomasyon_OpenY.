namespace RestoranOtomasyon
{
    partial class SalataMenu
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
            panel_Salata = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // panel_Salata
            // 
            panel_Salata.AutoScroll = true;
            panel_Salata.Dock = DockStyle.Fill;
            panel_Salata.Location = new Point(0, 0);
            panel_Salata.Name = "panel_Salata";
            panel_Salata.Size = new Size(800, 450);
            panel_Salata.TabIndex = 0;
            // 
            // SalataMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_Salata);
            Name = "SalataMenu";
            Text = "SalataMenu";
            Load += SalataMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panel_Salata;
    }
}