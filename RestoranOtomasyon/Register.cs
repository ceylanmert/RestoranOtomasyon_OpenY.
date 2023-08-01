
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using MySql.Data.MySqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RestoranOtomasyon
{
    public partial class Register : Form
    {
        string connstring = "server=localhost;uid=root;password=1234m;database=restorantys";
        MySqlConnection baglanti = new MySqlConnection();

        public Register()
        {
            InitializeComponent();
            baglanti.ConnectionString = connstring;


        }

        private void label7_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        // Kullanýcý kaydýnýn mevcut olup olmadýðýný kontrol eden fonksiyon
         private bool IsUserExists(string tcno)
        {
            using (MySqlConnection connection = new MySqlConnection(connstring))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM yetkilitablo WHERE KTC = @KTC";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@KTC", tcno);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if(count > 0)
                    {
                        //Kullanýcý Mevcut
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                catch (Exception ex){
                    MessageBox.Show("Hata Oluþtu : " + ex.Message);
                    return false;
                }
            }
        }
        private void btn_register_Click(object sender, EventArgs e)
        {
            string unvan = txt_KUnvan.Text;
            string tcno = txt_KSifre.Text;
            string adsoyad = txt_KAdSyoad.Text;
            string telefon = txt_phone.Text;


            //Kullanýcý Var mý yok mu kontrol et 

            bool isUserExists = IsUserExists (tcno);
            if(isUserExists)
            {
                MessageBox.Show("Bu kullanýcý zaten üyedir.", "Hata", MessageBoxButtons.OK,MessageBoxIcon.Question);
                txt_KUnvan.Clear();
                txt_KSifre.Clear();
                txt_KAdSyoad.Clear();
                txt_phone.Clear();
                
            }
             else
            {
                try
                {
                    baglanti.Open();
                    if (baglanti.State == ConnectionState.Open)
                    {
                       
                        //SQL Sorgusu Olustur

                        string query = "INSERT INTO yetkilitablo (KTC,KUnvan,KAdSoyad,KTel) VALUES (@KTC,@KUnvan,@KAdSoyad,@KTel)";

                        //Komut nesnesi oluþturma 

                        MySqlCommand command = new MySqlCommand(query, baglanti);

                        //Parametre Ata

                        command.Parameters.AddWithValue("@KTC", tcno);
                        command.Parameters.AddWithValue("@KUnvan", unvan);
                        command.Parameters.AddWithValue("@KadSoyad", adsoyad);
                        command.Parameters.AddWithValue("@KTel", telefon);
                        command.ExecuteNonQuery();

                    }

                    //NOT: if else ile kayýtlý belirtilmesi gereken : Kayýtlý kullanýcý var ise tekrar oluþturma.(kayýtlý kullanýcý var)
                    MessageBox.Show("Kayýt Baþarýyla Yapýldý!", "Kayýt Yapýldý", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txt_KSifre.Clear();
                    txt_KAdSyoad.Clear();
                    txt_KUnvan.Clear();
                    txt_phone.Clear();



                }
                catch (Exception ex)

                {
                    MessageBox.Show("Hata Oluþtu  : " + ex.Message);
                }
                finally
                {
                    baglanti.Close();

                }
            }
          


        }
        
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_KAdSyoad.Clear();
            txt_KUnvan.Clear();
            txt_phone.Clear();
            txt_KSifre.Clear();
        }



        private void txt_KUnvan_Enter(object sender, EventArgs e)
        {
            if (txt_KUnvan.Text == "Ünvan")
            {
                txt_KUnvan.Text = "";
                txt_KUnvan.ForeColor = Color.Black;
            }
        }

        private void txt_KUnvan_Leave(object sender, EventArgs e)
        {
            if (txt_KUnvan.Text == "")
            {
                txt_KUnvan.Text = "Ünvan";
                txt_KUnvan.ForeColor = Color.Silver;
            }
        }

        private void txt_KSifre_Enter(object sender, EventArgs e)
        {
            if (txt_KSifre.Text == "TC")
            {
                txt_KSifre.Text = "";
                txt_KSifre.ForeColor = Color.Black;
            }
        }

        private void txt_KSifre_Leave(object sender, EventArgs e)
        {
            if (txt_KSifre.Text == "")
            {
                txt_KSifre.Text = "TC";
                txt_KSifre.ForeColor = Color.Silver;
            }

        }

        private void txt_KAdSyoad_Enter(object sender, EventArgs e)
        {
            if (txt_KAdSyoad.Text == "Ad Soyad")
            {
                txt_KAdSyoad.Text = "";
                txt_KAdSyoad.ForeColor = Color.Black;
            }
        }

        private void txt_KAdSyoad_Leave(object sender, EventArgs e)
        {
            if (txt_KAdSyoad.Text == "")
            {
                txt_KAdSyoad.Text = "Ad Soyad";
                txt_KAdSyoad.ForeColor = Color.Silver;
            }
        }

        private void txt_phone_Enter(object sender, EventArgs e)
        {
            if (txt_phone.Text == "Telefon")
            {
                txt_phone.Text = "";
                txt_phone.ForeColor = Color.Black;
            }
        }

        private void txt_phone_Leave(object sender, EventArgs e)
        {
            if (txt_phone.Text == "")
            {
                txt_phone.Text = "Telefon";
                txt_phone.ForeColor = Color.Silver;
            }

        }
    }
}