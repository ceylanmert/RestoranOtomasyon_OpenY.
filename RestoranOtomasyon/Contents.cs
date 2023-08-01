using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace RestoranOtomasyon
{
    public partial class Contents : Form
    {

        string connstring = "server=localhost;uid=root;password=1234m;database=restorantys";
        MySqlConnection baglanti = new MySqlConnection();

        int adet = 1;
        public int UrunFiyat;
        public string UrunAD;
        public int UrunID;
      

        private CheckBoxTiklandi checkBoxTiklandi;


        public Contents()
        {
            InitializeComponent();
            baglanti.ConnectionString = connstring;
            checkBoxTiklandi = new CheckBoxTiklandi();
        }


        public List<int> selectedIcerikDs = new List<int>();
        
        private void Contents_Load(object sender, EventArgs e)
        {

            MasaDoldur();
            TerminalCevir();

            PanelIcerik.Location = new Point(50, 50);

            PanelIcerik.Size = new Size(350, 350);
            this.Controls.Add(PanelIcerik);
            


            try
            {
                baglanti.Open();
                if (baglanti.State == ConnectionState.Open)
                {
                    string urunFiyatQuery = "Select UrunFiyat FROM urunler where UrunID=@UrunID";
                   
                    MySqlCommand urunFiyatCommand = new MySqlCommand(urunFiyatQuery, baglanti);
                    urunFiyatCommand.Parameters.AddWithValue("@UrunID", UrunID);

                    object urunFiyatResult = urunFiyatCommand.ExecuteScalar();


                    if (urunFiyatResult != null)
                    {
                        UrunFiyat = Convert.ToInt32(urunFiyatResult);

                    }


                    string urunad = "SELECT UrunAD from urunler where UrunID = @UrunID";
                    MySqlCommand cmd23 = new MySqlCommand(urunad, baglanti);
                    cmd23.Parameters.AddWithValue("@UrunID", UrunID);

                    object Name = cmd23.ExecuteScalar();

                    if (Name != null)
                    {

                        UrunAD = Name.ToString();
                        lbl_Icerik.Text = UrunAD;
                    }
                    else
                    {
                        lbl_Icerik.Text = "Ürün bulunamadı.";
                    }


                    string query = "SELECT IcerikAD,IFiyat  FROM icerik where urunlerID = @urunlerID ";
                    MySqlCommand command = new MySqlCommand(query, baglanti);
                    command.Parameters.AddWithValue("@urunlerID", urunlerID);
                    MySqlDataReader reader = command.ExecuteReader();



                    int i = 0;
                    int IcerikID;
                    while (reader.Read())
                    {

                        string icerikAd = reader["IcerikAD"].ToString();

                        string icerikFiyat = reader["IFiyat"].ToString();
                        
                        CheckBox icerik = new CheckBox();
                        icerik.Location = new Point(200, PanelIcerik.Controls.Count * 30 + 30);
                        icerik.Size = new Size(15, 15);
                        icerik.Text = icerikFiyat;

                        Label label = new Label();

                        label.Location = new Point(100, PanelIcerik.Controls.Count * 30 + 30);

                        label.Text = icerikAd;
                       

                      

                        sepetLabel.Text = UrunFiyat.ToString();


                        PanelIcerik.Controls.Add(label);
                        PanelIcerik.Controls.Add(icerik);

                        checkBoxTiklandi.AddCheckBox(icerik, icerikAd, icerikFiyat);


                    }
                    reader.Close();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Mesajı : " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            checkBoxTiklandi.seturunFiyat(UrunFiyat);
            checkBoxTiklandi.SetSepetLabel(sepetLabel);
            checkBoxTiklandi.SetPanelSepet(PanelSepet);

        }
        public void btn_arttir_Click(object sender, EventArgs e)
        {


            checkBoxTiklandi.Arttir(UrunFiyat);
            adet += 1;


        }

        private void btn_azalt_Click(object sender, EventArgs e)
        {
            checkBoxTiklandi.Azaltt(sepetLabel);
            adet -= 1;
        }

        private void lbl_Icerik_Click(object sender, EventArgs e)
        {

        }
        int SepetID;
        int IcerikID = 1;
        int Adet;
        int Durum = 1;
        int ODurum = 1;
        decimal Tutar;
        string MasaNumarasi;
        string TerminalID;
        public int urunlerID;
        int ID;

        public void MasaDoldur()
        {
            baglanti.Open();
            if (baglanti.State == ConnectionState.Open)
            {
                string query = " SELECT AD from masasayisi";
                MySqlCommand cmd = new MySqlCommand(query, baglanti);
                MySqlDataReader reader = cmd.ExecuteReader();
                combobox_masano.Items.Clear();
                while (reader.Read())
                {
                    combobox_masano.Items.Add(reader["AD"].ToString());

                }

            }
            baglanti.Close();
        }

        public void TerminalCevir()
        {
            baglanti.Open();
            if (baglanti.State == ConnectionState.Open)
            {
                string terminalquery = "SELECT TAd FROM terminal";
                MySqlCommand cmd = new MySqlCommand(terminalquery, baglanti);
                MySqlDataReader reader = cmd.ExecuteReader();

                combo_Terminal.Items.Clear();

                while (reader.Read())
                {
                    combo_Terminal.Items.Add(reader["TAd"].ToString());
                }

            }
            baglanti.Close();
        }
        private string MasaCevir(string Text)
        {
            string numara = new string(Text.Where(char.IsDigit).ToArray());
            return numara;
        }
        private string TerminalCevir(string Text)
        {
            string numara1 = new string(Text.Where(char.IsDigit).ToArray());
            return numara1;
        }
       
        int sepetID;

        private void btn_MutfakGonder_Click(object sender, EventArgs e)
        {
            MasaNumarasi = combobox_masano.Text;
            string no = MasaCevir(MasaNumarasi);

            TerminalID = combo_Terminal.Text;
            string no1 = TerminalCevir(TerminalID);
            int terminal = combo_Terminal.SelectedIndex + 1;

            baglanti.Open();
            if (baglanti.State == ConnectionState.Open)
            {
              
                    string mutfakquery = ("INSERT INTO sepet(IcerikID,Adet,Tutar,ODurum,Durum,MasaNumarası,urunlerID,TerminalID) " +
                    "VALUES (@IcerikID,@Adet,@Tutar,@ODurum,@Durum,@MasaNumarası,@urunlerID,@TerminalID)");
                    MySqlCommand cmd = new MySqlCommand(mutfakquery, baglanti);

                    cmd.Parameters.AddWithValue("@IcerikID", IcerikID);
                    cmd.Parameters.AddWithValue("@Adet", adet);
                    cmd.Parameters.AddWithValue("@Tutar", adet * UrunFiyat);
                    cmd.Parameters.AddWithValue("@ODurum", ODurum);
                    cmd.Parameters.AddWithValue("@Durum", Durum);
                    cmd.Parameters.AddWithValue("@MasaNumarası", Convert.ToInt32(no));
                    cmd.Parameters.AddWithValue("@urunlerID", UrunID);
                    cmd.Parameters.AddWithValue("@TerminalID", terminal);
                    cmd.ExecuteNonQuery();
                    sepetID = (int)cmd.LastInsertedId;

                    baglanti.Close();
            }
            else
            {
                MessageBox.Show("Hata Oluştu Sipariş Alınamadı", "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglanti.Open();
            if (baglanti.State == ConnectionState.Open)
            {
                int i = 0;
                foreach (int icerikID in checkBoxTiklandi.icerikAldik)
                {
                    string squery = ("INSERT INTO sepeticerik(SepetID,IcerikID) values (@SepetID,@IcerikID)");
                    MySqlCommand sepetcmd = new MySqlCommand(squery, baglanti);
                    sepetcmd.Parameters.AddWithValue("@SepetID", sepetID);
                    sepetcmd.Parameters.AddWithValue("@IcerikID", checkBoxTiklandi.icerikAldik[i]);
                    sepetcmd.ExecuteNonQuery();
                    i++;
                }
                MessageBox.Show("Sipariş Alındı", "Sipariş Al", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


            }
            baglanti.Close();

        }
    }
}