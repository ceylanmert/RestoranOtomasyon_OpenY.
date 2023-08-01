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
    public partial class makarnamenu : Form
    {
        List<GenelUser> menus;

        public int urunlerID = 2;
        public makarnamenu()
        {
            InitializeComponent();
        }

        private void makarnamenu_Load(object sender, EventArgs e)
        {
            Menuolustur();
        }
        public void Menuolustur()
        {
            //menus = new List<hamburgeruser>();

            //int urunlerIDCount = 7;

            //for (int i = 1; i < urunlerIDCount; i++)
            //{
            //    hamburgeruser menu1 = new hamburgeruser(i);

            //    panel_hamburger.Controls.Add(menu1);

            //    menus.Add(menu1);
            //}
            //foreach (var urun in menus)
            //{
            //    panel_hamburger.Controls.Add(urun);
            //}

            menus = new List<GenelUser>();

            try
            {
                using (MySqlConnection baglanti = new MySqlConnection("server=localhost;uid=root;password=1234m;database=restorantys"))
                {
                    baglanti.Open();

                    if (baglanti.State == ConnectionState.Open)
                    {
                        string sqlquery = "SELECT UrunID FROM urunler WHERE KategoriID = 2";

                        MySqlCommand cmd = new MySqlCommand(sqlquery, baglanti);

                        MySqlDataReader reader = cmd.ExecuteReader();



                        while (reader.Read())
                        {

                            int urunID = Convert.ToInt32(reader["UrunID"]);
                            GenelUser menu1 = new GenelUser(urunID);

                            panel_makarna.Controls.Add(menu1);
                            menus.Add(menu1);
                        }

                        reader.Close();

                        //string query2 = "SELECT KategoriID FROM urunler WHERE UrunID=@UrunID";
                        //MySqlCommand cmd2 = new MySqlCommand(query2, baglanti);
                        //cmd2.Parameters.AddWithValue("@UrunID", urunlerID);
                        //var urunID3 = cmd2.ExecuteScalar();

                        //if (urunID3 != null && urunID3 != DBNull.Value)
                        //{
                        //    int urunID2 = Convert.ToInt32(urunID3); //dönüştürülecek değer urunID3 değişkeninin içinde zaten mevcut.
                        //    GenelUser menu2 = new GenelUser(urunID2);
                        //    panel_makarna.Controls.Add(menu2);
                        //    menus.Add(menu2);
                        //}


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Mesajı: " + ex.Message);
            }

        }
    }
}
