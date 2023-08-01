namespace RestoranOtomasyon
{
    partial class CorbaMenu
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
            panel_Corba = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // panel_Corba
            // 
            panel_Corba.AutoScroll = true;
            panel_Corba.Dock = DockStyle.Fill;
            panel_Corba.Location = new Point(0, 0);
            panel_Corba.Name = "panel_Corba";
            panel_Corba.Size = new Size(800, 450);
            panel_Corba.TabIndex = 0;
            // 
            // CorbaMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_Corba);
            Name = "CorbaMenu";
            Text = "CorbaMenu";
            Load += CorbaMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panel_Corba;
    }
}