namespace RestoranOtomasyon
{
    partial class hamburgermenu
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
            panel_hamburger = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // panel_hamburger
            // 
            panel_hamburger.AutoScroll = true;
            panel_hamburger.Dock = DockStyle.Fill;
            panel_hamburger.Location = new Point(0, 0);
            panel_hamburger.Name = "panel_hamburger";
            panel_hamburger.Size = new Size(800, 450);
            panel_hamburger.TabIndex = 0;
            // 
            // hamburgermenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_hamburger);
            Name = "hamburgermenu";
            Text = "hamburgermenu";
            Load += hamburgermenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panel_hamburger;
    }
}