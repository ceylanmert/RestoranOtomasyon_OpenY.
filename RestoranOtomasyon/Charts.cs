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
using System.Windows.Forms.DataVisualization.Charting;

namespace RestoranOtomasyon
{
    public partial class frm_grafik : Form
    {
        string connstring = "server=localhost;uid=root;password=1234m;database=restorantys";
        MySqlConnection baglanti = new MySqlConnection();
        public frm_grafik()
        {
            InitializeComponent();
            baglanti.ConnectionString = connstring;
        }

        private void frm_grafik_Load(object sender, EventArgs e)
        {
            Dictionary<string, int> encokSatanlar = getEnCokSatanlar();
            updateChart(encokSatanlar);


        }

        private Dictionary<string, int > getEnCokSatanlar()
        {
            Dictionary<string, int> encokSatanlar = new Dictionary<string, int>();

            baglanti.Open();

            string query = "SELECT  urunler.UrunAD,SUM(sepet.Adet) AS ToplamSatis " +
                                  "FROM sepet " +
                                  "INNER JOIN urunler ON sepet.urunlerID = urunler.UrunID " +
                                  "GROUP BY urunler.UrunAD " +
                                  "ORDER BY ToplamSatis DESC " +
                                   "LIMIT 7";

            MySqlCommand cmd = new MySqlCommand(query, baglanti);

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string urunAdi = reader["UrunAD"].ToString();
                    int satisAdet = Convert.ToInt32(reader["ToplamSatis"]);
                    encokSatanlar.Add(urunAdi, satisAdet);
                }
                reader.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Veritabanı bağlantı hatası: " + ex.Message);

            }
            finally
            {
                baglanti.Close();
            }
            return encokSatanlar;

        }

        private void updateChart(Dictionary<string, int> encokSatanlar)
        {
            grafik_chart.Series.Clear();
            Series series = grafik_chart.Series.Add("En Çok Satan Ürünler");
            series.ChartType = SeriesChartType.Doughnut;

            foreach (var urun in encokSatanlar)
            {
                series.Points.AddXY(urun.Key, urun.Value);
            }

        }

        private void btn_burger_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            string burgerQuery = "SELECT urunler.UrunAD, SUM(sepet.Adet) AS ToplamSatis " +
                           "FROM sepet " +
                           "INNER JOIN urunler ON sepet.urunlerID = urunler.UrunID " +
                           "WHERE urunler.KategoriID = 1 " +
                           "GROUP BY urunler.UrunAD " +
                           "ORDER BY ToplamSatis DESC";

            MySqlCommand cmd2 = new MySqlCommand(burgerQuery, baglanti);

            try
            {
                Dictionary<string, int> burgerUrunler = new Dictionary<string, int>();
                MySqlDataReader reader = cmd2.ExecuteReader();


                while (reader.Read())
                {
                    string urunAdi = reader["UrunAD"].ToString();
                    int satisAdet = Convert.ToInt32(reader["ToplamSatis"]);
                    burgerUrunler.Add(urunAdi, satisAdet);

                }
                reader.Close();


                var coksatanBurger = burgerUrunler.OrderByDescending(x => x.Value).ToList();


                grafik_chart.Series.Clear();
                Series series = grafik_chart.Series.Add("En Çok Satan Ürünler");
                series.ChartType = SeriesChartType.Doughnut;


                foreach (var urun in coksatanBurger)
                {
                    series.Points.AddXY(urun.Key, urun.Value);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Veritabanı bağlantı hatası: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }


        }

        private void btn_makarna_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            string makarnaquery = "SELECT urunler.UrunAD, SUM(sepet.Adet) AS ToplamSatis " +
                                  "FROM sepet " +
                                  "INNER JOIN urunler ON sepet.urunlerID = urunler.UrunID " +
                                  "WHERE urunler.KategoriID = 2 " +
                                  "GROUP BY urunler.UrunAD " +
                                  "ORDER BY ToplamSatis DESC";


            MySqlCommand cmd = new MySqlCommand(makarnaquery, baglanti);

            try
            {
                Dictionary<string, int> makarnaUrun = new Dictionary<string, int>();
                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    string urunAdi = reader["UrunAD"].ToString();
                    int satisAdet = Convert.ToInt32(reader["ToplamSatis"]);
                    makarnaUrun.Add(urunAdi, satisAdet);
                }
                reader.Close();

                var coksatanMakarna = makarnaUrun.OrderByDescending(x => x.Value).ToList();

                grafik_chart.Series.Clear();
                Series series = grafik_chart.Series.Add("En Çok Satan Ürünler");
                series.ChartType = SeriesChartType.Doughnut;


                foreach (var urun in coksatanMakarna)
                {
                    series.Points.AddXY(urun.Key, urun.Value);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Veritabanı bağlantı hatası: " + ex.Message);

            }
            finally
            {
                baglanti.Close();
            }

        }

        private void btn_et_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            string etquery = "SELECT urunler.UrunAD, SUM(sepet.Adet) AS ToplamSatis " +
                                  "FROM sepet " +
                                  "INNER JOIN urunler ON sepet.urunlerID = urunler.UrunID " +
                                  "WHERE urunler.KategoriID = 3 " +
                                  "GROUP BY urunler.UrunAD " +
                                  "ORDER BY ToplamSatis DESC";

            MySqlCommand cmd = new MySqlCommand(etquery, baglanti);

            try
            {
                Dictionary<string, int> etUrun = new Dictionary<string, int>();

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string urunAdi = reader["UrunAD"].ToString();
                    int satisAdet = Convert.ToInt32(reader["ToplamSatis"]);
                    etUrun.Add(urunAdi, satisAdet);

                }
                reader.Close();

                var encoksatanEt = etUrun.OrderByDescending(x => x.Value);

                grafik_chart.Series.Clear();
                Series series = grafik_chart.Series.Add("En Çok Satan Ürünler");
                series.ChartType = SeriesChartType.Doughnut;

                foreach (var urun in encoksatanEt)
                {
                    series.Points.AddXY(urun.Key, urun.Value);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Veritabanı bağlantı hatası: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void btn_Salata_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            string salataquery = "SELECT urunler.UrunAD, SUM(sepet.Adet) AS ToplamSatis " +
                                  "FROM sepet " +
                                  "INNER JOIN urunler ON sepet.urunlerID = urunler.UrunID " +
                                  "WHERE urunler.KategoriID = 4 " +
                                  "GROUP BY urunler.UrunAD " +
                                  "ORDER BY ToplamSatis DESC";

            MySqlCommand cmd = new MySqlCommand(salataquery, baglanti);

            try
            {
                Dictionary<string, int> salataUrun = new Dictionary<string, int>();

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string urunAdi = reader["UrunAD"].ToString();
                    int satisAdet = Convert.ToInt32(reader["ToplamSatis"]);
                    salataUrun.Add(urunAdi, satisAdet);
                }
                reader.Close();


                var encokSalata = salataUrun.OrderByDescending(x => x.Value).ToList();


                grafik_chart.Series.Clear();
                Series series = grafik_chart.Series.Add("En Çok Satan Ürünler");
                series.ChartType = SeriesChartType.Doughnut;


                foreach (var urun in encokSalata)
                {
                    series.Points.AddXY(urun.Key, urun.Value);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Veritabanı bağlantı hatası: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

        }

        private void btn_Corba_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            string corbaquery = "SELECT urunler.UrunAD, SUM(sepet.Adet) AS ToplamSatis " +
                                  "FROM sepet " +
                                  "INNER JOIN urunler ON sepet.urunlerID = urunler.UrunID " +
                                  "WHERE urunler.KategoriID = 5 " +
                                  "GROUP BY urunler.UrunAD " +
                                  "ORDER BY ToplamSatis DESC";

            MySqlCommand cmd = new MySqlCommand(corbaquery, baglanti);

            try
            {
                Dictionary<string, int> corbaUrun = new Dictionary<string, int>();

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string urunAdi = reader["UrunAD"].ToString();
                    int satisAdet = Convert.ToInt32(reader["ToplamSatis"]);
                    corbaUrun.Add(urunAdi, satisAdet);
                }
                reader.Close();


                var encokCorba = corbaUrun.OrderByDescending(x => x.Value).ToList();


                grafik_chart.Series.Clear();
                Series series = grafik_chart.Series.Add("En Çok Satan Ürünler");
                series.ChartType = SeriesChartType.Doughnut;


                foreach (var urun in encokCorba)
                {
                    series.Points.AddXY(urun.Key, urun.Value);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Veritabanı bağlantı hatası: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void btn_Tatli_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            string tatliquery = "SELECT urunler.UrunAD, SUM(sepet.Adet) AS ToplamSatis " +
                                  "FROM sepet " +
                                  "INNER JOIN urunler ON sepet.urunlerID = urunler.UrunID " +
                                  "WHERE urunler.KategoriID = 6 " +
                                  "GROUP BY urunler.UrunAD " +
                                  "ORDER BY ToplamSatis DESC";

            MySqlCommand cmd = new MySqlCommand(tatliquery, baglanti);

            try
            {
                Dictionary<string, int> tatliUrun = new Dictionary<string, int>();

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string urunAdi = reader["UrunAD"].ToString();
                    int satisAdet = Convert.ToInt32(reader["ToplamSatis"]);
                    tatliUrun.Add(urunAdi, satisAdet);
                }
                reader.Close();


                var encokTatli = tatliUrun.OrderByDescending(x => x.Value).ToList();


                grafik_chart.Series.Clear();
                Series series = grafik_chart.Series.Add("En Çok Satan Ürünler");
                series.ChartType = SeriesChartType.Doughnut;


                foreach (var urun in encokTatli)
                {
                    series.Points.AddXY(urun.Key, urun.Value);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Veritabanı bağlantı hatası: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void btn_icecek_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            string icecekquery = "SELECT urunler.UrunAD, SUM(sepet.Adet) AS ToplamSatis " +
                                  "FROM sepet " +
                                  "INNER JOIN urunler ON sepet.urunlerID = urunler.UrunID " +
                                  "WHERE urunler.KategoriID = 7 " +
                                  "GROUP BY urunler.UrunAD " +
                                  "ORDER BY ToplamSatis DESC";

            MySqlCommand cmd = new MySqlCommand(icecekquery, baglanti);

            try
            {
                Dictionary<string, int> icecekUrun = new Dictionary<string, int>();

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string urunAdi = reader["UrunAD"].ToString();
                    int satisAdet = Convert.ToInt32(reader["ToplamSatis"]);
                    icecekUrun.Add(urunAdi, satisAdet);
                }
                reader.Close();


                var encokIcecek = icecekUrun.OrderByDescending(x => x.Value).ToList();


                grafik_chart.Series.Clear();
                Series series = grafik_chart.Series.Add("En Çok Satan Ürünler");
                series.ChartType = SeriesChartType.Doughnut;


                foreach (var urun in encokIcecek)
                {
                    series.Points.AddXY(urun.Key, urun.Value);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Veritabanı bağlantı hatası: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void btn_coksatan_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> encokSatanlar = getEnCokSatanlar();
            updateChart(encokSatanlar);

        }
    }
}
