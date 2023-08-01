namespace RestoranOtomasyon
{
    partial class makarnamenu
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
            panel_makarna = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // panel_makarna
            // 
            panel_makarna.AutoScroll = true;
            panel_makarna.Dock = DockStyle.Fill;
            panel_makarna.Location = new Point(0, 0);
            panel_makarna.Name = "panel_makarna";
            panel_makarna.Size = new Size(800, 450);
            panel_makarna.TabIndex = 1;
            // 
            // makarnamenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_makarna);
            Name = "makarnamenu";
            Text = "makarnamenu";
            Load += makarnamenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panel_makarna;
    }
}