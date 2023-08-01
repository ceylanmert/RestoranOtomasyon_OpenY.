namespace RestoranOtomasyon
{
    partial class EtMenu
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
            panel_et = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // panel_et
            // 
            panel_et.AutoScroll = true;
            panel_et.Dock = DockStyle.Fill;
            panel_et.Location = new Point(0, 0);
            panel_et.Name = "panel_et";
            panel_et.Size = new Size(800, 450);
            panel_et.TabIndex = 0;
            // 
            // EtMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_et);
            Name = "EtMenu";
            Text = "EtMenu";
            Load += EtMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panel_et;
    }
}