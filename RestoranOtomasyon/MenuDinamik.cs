
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RestoranOtomasyon.MenuDinamik;

namespace RestoranOtomasyon
{
    public partial class MenuDinamik : UserControl
    {

        string connstring = "server=localhost;uid=root;password=1234m;database=restorantys";

        MySqlConnection baglanti = new MySqlConnection();

        List<MealsMenu> producs;

        public int urunlerID;
        public int KategoriID;

        public MenuDinamik()
        {
            InitializeComponent();

        }

        public class Urun
        {
            public int UrunID { get; set; }
            public string UrunFiyat { get; set; }
            public string UrunAD { get; set; }

        }

        private void btn_sepet_Click(object sender, EventArgs e)
        {

        }
    }


}