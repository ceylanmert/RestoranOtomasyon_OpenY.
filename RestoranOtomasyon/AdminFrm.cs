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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static RestoranOtomasyon.MenuDinamik;

namespace RestoranOtomasyon
{
    public partial class AdminFrm : Form
    {
        string connstring = "server=localhost;uid=root;password=1234m;database=restorantys";
        MySqlConnection baglanti = new MySqlConnection();

        private int urunlerID;
        public string resimYolu;
        public string targetFilePath;
        public AdminFrm()
        {
            InitializeComponent();
            baglanti.ConnectionString = connstring;
        }
        public int KategoriID;
        public string resimDosyaYolu;
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            urunlerID = Convert.ToInt32(txt_ID.Text);

            string urunad = txt_urunad.Text;
            string urunfiyat = txt_urunfiyat.Text;
            string kategoriID = txt_kategori.Text;

            resimDosyaYolu = pictureBox_Resim.ImageLocation;

            try
            {
                baglanti.Open();
                if (baglanti.State == ConnectionState.Open)
                {
                    string eklequery = "INSERT INTO urunler  (UrunAD,UrunFiyat,KategoriID,ResimCek) VALUES (@UrunAD,@UrunFiyat,@KategoriID,@ResimCek)";
                    MySqlCommand cmd = new MySqlCommand(eklequery, baglanti);
                    cmd.Parameters.AddWithValue("@UrunAD", urunad);
                    cmd.Parameters.AddWithValue("@UrunFiyat", urunfiyat);
                    cmd.Parameters.AddWithValue("@KategoriID", kategoriID);
                    cmd.Parameters.AddWithValue("@ResimCek", resimYolu); // Resim yolu parametreye ekleniyor

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Kayıt Başarıyla Yapıldı!", "Kayıt Yapıldı", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txt_urunad.Clear();
                    txt_urunfiyat.Clear();
                    txt_kategori.Clear();


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Mesajı : ", "Hata Kutusu" + ex.Message);
            }
            finally
            {
                VeriGetir(); baglanti.Close();
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {

            DialogResult result;
            result = MessageBox.Show("Silmek İstediğinize Emin misiniz ? ", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                try
                {
                    baglanti.Open();
                    string silquery = "DELETE FROM urunler where UrunID=@UrunID";
                    MySqlCommand cmd = new MySqlCommand(silquery, baglanti);
                    cmd.Parameters.AddWithValue("@UrunID", Convert.ToInt32(txt_ID.Text));
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    VeriGetir();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata Mesajı : " + ex.Message);

                }

            }

        }
        public void VeriGetir()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            string veriquery = "SELECT * FROM urunler";
            MySqlDataAdapter adapter = new MySqlDataAdapter(veriquery, baglanti);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            datagird_verigetir.DataSource = tablo;

            baglanti.Close();



        }
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                if (baglanti.State == ConnectionState.Open)
                {
                    string guncelquery = "UPDATE urunler SET UrunAD=@UrunAD,UrunFiyat=@UrunFiyat,KategoriID=@KategoriID,ResimCek=@ResimCek where UrunID = @UrunID";
                    MySqlCommand cmd = new MySqlCommand(guncelquery, baglanti);

                    cmd.Parameters.AddWithValue("@UrunAD", txt_urunad.Text);
                    cmd.Parameters.AddWithValue("@UrunFiyat", txt_urunfiyat.Text);
                    cmd.Parameters.AddWithValue("@KategoriID", txt_kategori.Text);
                    cmd.Parameters.AddWithValue("@ResimCek", resimYolu);
                    cmd.Parameters.AddWithValue("@UrunID", txt_ID.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txt_urunad.Clear();
                    txt_urunfiyat.Clear();
                    txt_kategori.Clear();
                    txt_ID.Clear();

                }
                baglanti.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Mesajı : " + ex.Message);

            }
            finally
            {
                VeriGetir();
            }
        }

        private void AdminFrm_Load(object sender, EventArgs e)
        {
            VeriGetir();
            urunlerID = Convert.ToInt32(datagird_verigetir.CurrentRow.Cells["UrunID"].Value);


        }

        private void datagird_verigetir_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = datagird_verigetir.CurrentRow.Cells[0].Value.ToString();
            txt_kategori.Text = datagird_verigetir.CurrentRow.Cells[1].Value.ToString();
            txt_urunad.Text = datagird_verigetir.CurrentRow.Cells[2].Value.ToString();
            txt_urunfiyat.Text = datagird_verigetir.CurrentRow.Cells[3].Value.ToString();

            //Resim Göster

            string resimYolu = datagird_verigetir.CurrentRow.Cells["ResimCek"].Value.ToString();


            if (!string.IsNullOrEmpty(resimYolu))
            {
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, resimYolu);
                if (File.Exists(fullPath))
                {
                    using (FileStream stream = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                    {
                        pictureBox_Resim.Image = Image.FromStream(stream);
                    }
                }
                else
                {
                    pictureBox_Resim.Image = null;
                }
            }
            else
            {
                pictureBox_Resim.Image = null;
            }

        }

        private void btn_resimekle_Click(object sender, EventArgs e)
        {

            ResimDatabase(urunlerID, pictureBox_Resim);
            ResimGoster(resimYolu, pictureBox_Resim);

        }

        public void ResimDatabase(int urunID, PictureBox pictureBox)
        {
            //Resimleri ekle butonundan kaydediyoruz burdan seçiyoruz
            try
            {
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

                            string targetDirectory = @"\Resimler";

                            if (!Directory.Exists(targetDirectory))
                            {
                                Directory.CreateDirectory(targetDirectory);
                            }

                            targetFilePath = Path.Combine(targetDirectory, fileName);

                            try
                            {
                                File.Copy(localFilePath, targetFilePath, true);
                                Console.WriteLine("Resim Başarıyla Kaydedildi : " + targetFilePath);

                                resimYolu = @"\Resimler\" + fileName;




                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show("Hata Mesajı : " + ex.Message);
                            }


                        }
                        if (!string.IsNullOrEmpty(resimYolu))
                        {
                            resimDosyaYolu = Path.GetFileName(resimYolu);

                            // Resim seçildiğinde PictureBox'a da gösterelim
                            pictureBox_Resim.Image = Image.FromFile(resimYolu);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Mesajı : " + ex.Message);

            }
            finally { baglanti.Close(); }


        }

        public void ResimGoster(string resimCek, PictureBox pictureBox)
        {
            try
            {
                if (!string.IsNullOrEmpty(resimCek))
                {
                    // Resim yolunu dosya adıyla birleştirerek tam dosya yolunu oluşturun
                    string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resimler", resimCek);
                    if (File.Exists(fullPath))
                    {
                        using FileStream stream = new FileStream(fullPath, FileMode.Open, FileAccess.Read);
                        {
                            pictureBox_Resim.Image = Image.FromStream(stream);
                        }
                    }
                    else
                    {
                        pictureBox_Resim.Image = null;
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

        private void button1_Click(object sender, EventArgs e)
        {
            frm_grafik grafik = new frm_grafik();
            grafik.ShowDialog();
        }
    }
}
