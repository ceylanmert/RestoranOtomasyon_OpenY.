using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranOtomasyon
{
    public partial class Menu : Form
    {

        private Form currentChildForm;
        private Button button;
        private Panel Leftborderbtn;
        public Menu()
        {
            InitializeComponent();
            //Form
            KullaniciAdiniGoster();


            Leftborderbtn = new Panel();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int vMsg, int vParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        public void KullaniciAdiniGoster()
        {
            lbl_kullanici.Text = PersonelSinif.KUvan;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult secim;
            secim = MessageBox.Show("Çıkmak İstediğinize Emin Misiniz?", "Kapat", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (secim == DialogResult.OK)
            {
                Application.Exit();

            }


        }

        // GEREKİRSE Boyut ayarlanabilir 
        //private void btnMaximize_Click(object sender, EventArgs e)
        //{
        //    if (WindowState == FormWindowState.Normal)
        //    {
        //        WindowState = FormWindowState.Maximized;
        //    }
        //    else
        //    {
        //        WindowState = FormWindowState.Normal;
        //    }
        //}

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void OpenChildForm(Form childForm)
        {
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MealsMenu());

        }
        private void DisableButton()
        {
            if (button != null)
            { button.Enabled = true; }
        }
        private void Reset()
        {
            DisableButton();
            Leftborderbtn.Visible = false;
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                currentChildForm = null;
            }

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                Reset();
            }
        }



        private void btn_mburger_Click(object sender, EventArgs e)
        {
            OpenChildForm(new hamburgermenu());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new makarnamenu());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EtMenu());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SalataMenu());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CorbaMenu());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TatliMenu());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new IceceklerMenu());
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminFrm());
        }

        private void btn_logindon_Click(object sender, EventArgs e)
        {
            Login loginPanel = new Login();
            this.Hide();
            loginPanel.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            KullaniciAdiniGoster();

        }
    }
}
