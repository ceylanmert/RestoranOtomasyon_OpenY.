using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RestoranOtomasyon
{
    public partial class Login : Form
    {
        string connstring = "server=localhost;uid=root;password=1234m;database=restorantys";
        MySqlConnection baglanti = new MySqlConnection();
        public Login()
        {
            InitializeComponent();
            baglanti.ConnectionString = connstring;

        }

        private void lbl_GDon_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog();
            this.Close();
        }

        private void checkBox_SGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_SGoster.CheckState == CheckState.Checked)
            {
                txt_GSifre.UseSystemPasswordChar = true;
                checkBox_SGoster.Text = "Gizle";
            }
            else if (checkBox_SGoster.CheckState == CheckState.Unchecked)
            {
                txt_GSifre.UseSystemPasswordChar = false;
                checkBox_SGoster.Text = "Göster";
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                if (baglanti.State == ConnectionState.Open)
                {
                    string unvan = txt_GUnvan.Text;
                    string tcno = txt_GSifre.Text;


                    string query = "SELECT  COUNT(*) FROM yetkilitablo WHERE KUnvan = @KUnvan and KTC=@KTC";
                    MySqlCommand command = new MySqlCommand(query, baglanti);

                    command.Parameters.AddWithValue("@KUnvan", unvan);
                    command.Parameters.AddWithValue("@KTC", tcno);


                    //Sorgu çalıştır doğru ise count değeri 1 
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count == 1)
                    {
                        Menu menu = new Menu();
                        // KTC ve KUnvan değerlerini PersonelSinif sınıfına atıyoruz
                        PersonelSinif.KTC = Convert.ToInt32(tcno);
                        PersonelSinif.KUvan = unvan;

                        if (PersonelSinif.KTC == 1234 && PersonelSinif.KUvan == "admin")
                        {
                           menu.btn_admin.Enabled = true;
                        }
                        else
                        {
                            menu.btn_admin.Enabled = false;
                        }

                        this.Hide();
                        menu.ShowDialog();
                        this.Close();
                        
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı !");
                    }

                }



            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu : " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void txt_GUnvan_Enter(object sender, EventArgs e)
        {
            if (txt_GUnvan.Text == "Unvan")
            {
                txt_GUnvan.Text = "";

                txt_GUnvan.ForeColor = Color.Black;
            }
        }

        private void txt_GUnvan_Leave(object sender, EventArgs e)
        {
            if (txt_GUnvan.Text == "")
            {
                txt_GUnvan.Text = "Unvan";

                txt_GUnvan.ForeColor = Color.Silver;
            }
        }

        private void txt_GSifre_Enter(object sender, EventArgs e)
        {
            if (txt_GSifre.Text == "*****")
            {
                txt_GSifre.Text = "";
                txt_GSifre.ForeColor = Color.Black;
            }
        }

        private void txt_GSifre_Leave(object sender, EventArgs e)
        {
            if (txt_GSifre.Text == "")
            {
                txt_GSifre.Text = "*****";
                txt_GSifre.ForeColor = Color.Silver;
            }
        }

        private void btn_GClear_Click(object sender, EventArgs e)
        {
            txt_GUnvan.Clear();
            txt_GSifre.Clear();
        }
    }
}
