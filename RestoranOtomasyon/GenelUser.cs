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
using static RestoranOtomasyon.MenuDinamik;

namespace RestoranOtomasyon
{
    public partial class GenelUser : UserControl
    {
        string connstring = "server=localhost;uid=root;password=1234m;database=restorantys";

        MySqlConnection baglanti = new MySqlConnection();

        List<MealsMenu> producs;
        public int UrunID;
        public int urunlerID;
        public int KategoriID = 2;
        public GenelUser(int urunler)
        {
            InitializeComponent();
            baglanti.ConnectionString = connstring;
            this.UrunID = urunler;
        }

        private void MakarnaUser_Load(object sender, EventArgs e)
        {
            menu123();
            ResimKontrol();
        }

        public void ResimKontrol()
        {
            try
            {
                baglanti.Open();
                if (baglanti.State == ConnectionState.Open)
                {
                    string kontrolquery = "SELECT ResimCek from urunler where UrunID = @UrunID";
                    MySqlCommand command = new MySqlCommand(kontrolquery, baglanti);
                    command.Parameters.AddWithValue("UrunID", UrunID);
                    string resimYolu = command.ExecuteScalar() as string;
                    baglanti.Close();
                    if (!string.IsNullOrEmpty(resimYolu))
                    {
                        ResimGoster(resimYolu, pictureBox_Resim);
                    }
                    else
                    {
                        ResimDatabase(urunlerID, pictureBox_Resim);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void ResimDatabase(int urunID, PictureBox pictureBox)
        {
            //try
            //{
            //    baglanti.Open();
            //    if (baglanti.State == ConnectionState.Open)
            //    {
            //        string resimquery = "SELECT  ResimYap from urunler where UrunID = @UrunID";
            //        MySqlCommand cmd = new MySqlCommand(resimquery, baglanti);
            //        cmd.Parameters.AddWithValue("@UrunID", urunID);
            //        byte[] imageBytes = (byte[])cmd.ExecuteScalar();

            //        if (imageBytes != null)
            //        {
            //            using (MemoryStream ms = new MemoryStream(imageBytes))
            //            {
            //                pictureBox_Resim.Image = Image.FromStream(ms);
            //            }
            //        }
            //        else
            //        {

            //            pictureBox.Image = null;
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show("Hata Mesajı : " + ex.Message);
            //}

            //finally { baglanti.Close(); }
            baglanti.Open();
            if (baglanti.State == ConnectionState.Open)
            {
                using (var openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Resim Dosyaları (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif";
                    openFileDialog.Title = "Resim Dosyası Secin";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string localFilePath = openFileDialog.FileName;
                        string fileName = Path.GetFileName(localFilePath);

                        //yeni dizine kaydetmek için hedef belirle

                        string targetDirectory = @"\Resimler";
                        //@"C:\Resimler"; Resim yolunu göstermek istersek

                        //eğer hedef dizin yoksa oluştur

                        if (!Directory.Exists(targetDirectory))
                        {
                            Directory.CreateDirectory(targetDirectory);
                        }
                        //hedef dizin ve dosya adını birleştir tam dosya yolu oluştur
                        string targetFilePath = Path.Combine(targetDirectory, fileName);

                        //Resmi Hedef dizine Kopyala
                        try
                        {
                            File.Copy(localFilePath, targetFilePath, true);
                            Console.WriteLine("Resim Başarıyla Kaydedildi : " + targetFilePath);
                            string query1 = "SELECT UrunID from urunler";
                            string query = "UPDATE urunler SET ResimCek = @ResimCek WHERE UrunID = @UrunID";

                            MySqlCommand cmd = new MySqlCommand(query, baglanti);
                            cmd.Parameters.AddWithValue("@ResimCek", targetFilePath);

                            cmd.Parameters.AddWithValue("@UrunID", UrunID);

                            cmd.ExecuteNonQuery();

                            ResimGoster(targetFilePath, pictureBox);
                            baglanti.Close();

                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Hata Mesajı : " + ex.Message);
                        }


                    }
                }
            }


        }

        public void ResimGoster(string resimCek, PictureBox pictureBox)
        {
            try
            {
                if (File.Exists(resimCek))
                {
                    using (FileStream stream = new FileStream(resimCek, FileMode.Open, FileAccess.Read))
                    {
                        pictureBox_Resim.Image = Image.FromStream(stream);
                    }
                }
                else
                {
                    pictureBox_Resim.Image = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Resim Gösterme Hatası : " + ex.Message);
            }
        }
        private void btn_sepet_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                if (baglanti.State == ConnectionState.Open)
                {

                    string sqlquery = "SELECT KategoriID FROM urunler WHERE UrunID = @UrunID";
                    //string sqlquery = "SELECT UrunID FROM urunler";

                    MySqlCommand cmd = new MySqlCommand(sqlquery, baglanti);
                    cmd.Parameters.AddWithValue("@UrunID", UrunID);

                    var urunID = cmd.ExecuteScalar();


                    if (urunID != null && urunID != DBNull.Value)
                    {
                        urunlerID = Convert.ToInt32(urunID);
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Mesajı :" + ex.Message);
            }
            finally
            {

                baglanti.Close();

            }
            Contents contents = new Contents();
            contents.urunlerID = urunlerID;
            contents.UrunID = UrunID;
            contents.ShowDialog();
        }
        public List<Urun> menu123()
        {
            List<Urun> urunler = new List<Urun>();
            try
            {
                baglanti.Open();

                if (baglanti.State == ConnectionState.Open)
                {

                    string menuQuery = "Select UrunAD,UrunFiyat  from urunler where UrunID = @UrunID";

                    MySqlCommand cmd = new MySqlCommand(menuQuery, baglanti);
                    cmd.Parameters.AddWithValue("@UrunID", UrunID);

                    MySqlDataReader reader = cmd.ExecuteReader();


                    if (reader.Read())
                    {
                        string UrunAD = reader["UrunAD"].ToString();
                        string UrunFiyat = reader["UrunFiyat"].ToString();


                        lbl_KategoriID.Text = UrunAD;
                        lbl_UrunFiyat.Text = UrunFiyat.ToString();

                        this.Controls.Add(lbl_KategoriID);
                        this.Controls.Add(lbl_UrunFiyat);

                        this.Controls.Add(btn_sepet);

                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Mesajı : " + ex.Message);

            }
            finally { baglanti.Close(); }
            return urunler;
        }

        private void lbl_UrunFiyat_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_Resim_Click(object sender, EventArgs e)
        {
        }

        private void lbl_KategoriID_Click(object sender, EventArgs e)
        {
        }
    }
}