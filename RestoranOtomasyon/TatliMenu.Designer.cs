namespace RestoranOtomasyon
{
    partial class TatliMenu
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
            panel_Tatli = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // panel_Tatli
            // 
            panel_Tatli.AutoScroll = true;
            panel_Tatli.Dock = DockStyle.Fill;
            panel_Tatli.Location = new Point(0, 0);
            panel_Tatli.Name = "panel_Tatli";
            panel_Tatli.Size = new Size(800, 450);
            panel_Tatli.TabIndex = 0;
            // 
            // TatliMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_Tatli);
            Name = "TatliMenu";
            Text = "TatliMenu";
            Load += TatliMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panel_Tatli;
    }
}