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

    public partial class EtMenu : Form
    {
        List<GenelUser> menus;
        public EtMenu()
        {
            InitializeComponent();
        }
        public void Menuolustur()
        {
            menus = new List<GenelUser>();

            try
            {
                using (MySqlConnection baglanti = new MySqlConnection("server=localhost;uid=root;password=1234m;database=restorantys"))
                {
                    baglanti.Open();

                    if (baglanti.State == ConnectionState.Open)
                    {
                        string sqlquery = "SELECT UrunID FROM urunler WHERE KategoriID = 3";
                        MySqlCommand cmd = new MySqlCommand(sqlquery, baglanti);
                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            int urunID = Convert.ToInt32(reader["UrunID"]);
                            GenelUser menu1 = new GenelUser(urunID);
                            panel_et.Controls.Add(menu1);
                            menus.Add(menu1);
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Mesajı: " + ex.Message);
            }

        }

        private void panel_et_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EtMenu_Load(object sender, EventArgs e)
        {
            Menuolustur();
        }
    }
}
