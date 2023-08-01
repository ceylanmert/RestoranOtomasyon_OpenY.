using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace RestoranOtomasyon
{
    public class CheckBoxTiklandi
    {
      
        private Panel PanelIcerik; // Icerik CheckBox'ların bulundugu panel
        private Panel PanelSepet; // Sepet CheckBox ların ekleneceği Panel
        private List<CheckBox> checkBoxes; //CheckBox Listesi

        private Label sepetLabel; // Sepet Fiyatı
        private int sepetFiyat; // Sepetin Toplam Fiyatı
        public List<int>icerikAldik = new List<int>();
        private string icerikAd;
        public int UrunFiyat;
        public int carpan;
        string connstring = "server=localhost;uid=root;password=1234m;database=restorantys";
        MySqlConnection baglanti = new MySqlConnection();


        private Dictionary<CheckBox, Icerik> checkBoxIcerikDict;  // CheckBox ve Icerik nesnelerinin eşleşmesini tutan sözlük
       
       
          
     
        public class Icerik
        {
            public string Ad { get; set; }
            public string Fiyat { get; set; }

            public int IcerikID { get;  set; }
          
            public Icerik(string ad, string fiyat)
            {
                Ad = ad;
                Fiyat = fiyat;
             
            }

        }

        public CheckBoxTiklandi()
        {
            baglanti.ConnectionString = connstring;
            checkBoxes = new List<CheckBox>();
            checkBoxIcerikDict = new Dictionary<CheckBox, Icerik>();
          

        }
        public void seturunFiyat(int UrunFiyat)
        {
            this.UrunFiyat = UrunFiyat;
        }

        public void AddCheckBox(CheckBox checkBox, string icerikAd, string icerikFiyat)
        {
            checkBox.CheckedChanged += CheckBox_CheckedChanged;
            checkBox.Tag = new Icerik(icerikAd, icerikFiyat);
            checkBoxes.Add(checkBox);
            checkBoxIcerikDict.Add(checkBox, new Icerik(icerikAd, icerikFiyat));
            

        }
   

        public int Returndondur()
        {
            baglanti.Open();
            string query = "SELECT IcerikID from icerik where IcerikAD =@IcerikAD";
            MySqlCommand cmd = new MySqlCommand(query, baglanti);
            cmd.Parameters.AddWithValue("IcerikAD",icerikAd);
            object  a = cmd.ExecuteScalar();

            baglanti.Close();
            return Convert.ToInt32(a);
        }
        // CheckBox'ların CheckedChanged olayını işleyen metot
     
        public void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
            CheckBox checkBox = (CheckBox)sender;
            Icerik icerik = checkBoxIcerikDict[checkBox];
        

            int fiyat = Convert.ToInt32(checkBox.Text);

        
         
            

            if (checkBox.Checked )
                {
                Label cloneLabel = new Label();
                cloneLabel.AutoSize = true;
                cloneLabel.Location = new Point(checkBox.Location.X + checkBox.Size.Width + 10 , checkBox.Location.Y);
                cloneLabel.Text = icerik.Ad;
                PanelSepet.Controls.Add(cloneLabel);
                icerikAd = cloneLabel.Text;
                
                PanelSepet.Controls.Add(cloneLabel);

                    sepetFiyat +=  fiyat;
                //  int a = checkBoxTiklandi.Returndondur();
               // int a = checkBoxTiklandi.Returndondur();
               icerikAldik.Add(Returndondur());
            }

            
            else 
            {
                // PanelSepet içindeki CheckBox'ları kontrol et ve seçili CheckBox'ı kaldır
              

                // PanelSepet içindeki Label'ları kontrol et ve ilgili Label'ı kaldır
                foreach (Control control in PanelSepet.Controls.OfType<Label>().ToList())
                {
                    if (control.Text == icerik.Ad)
                    {
                        PanelSepet.Controls.Remove(control);
                        break;
                    }
                }

                    sepetFiyat -=  fiyat ;
              // Seçilen icerikID'yi listeden çıkar

            }
            
            sepetLabel.Text = (sepetFiyat+UrunFiyat).ToString();
            
           
        }

        // CheckBox'ları PanelIcerik'e bağlama metodu
        //public void AttachCheckBoxes(Panel PanelIcerik)
        //{
        //    foreach (Control control in PanelIcerik.Controls)
        //    {
        //        if (control is CheckBox checkBox)
        //        {
        //            checkBoxes.Add(checkBox);
        //            checkBox.CheckedChanged += CheckBox_CheckedChanged;
        //        }
        //    }
        //}

        // PanelSepet'i ayarlama metodu
        public void SetPanelSepet(Panel PanelSpet)
        {
            this.PanelSepet = PanelSpet;
        }

        // SepetLabel'i ayarlama metodu
        public void SetSepetLabel(Label sepetLabel)
        {
            this.sepetLabel = sepetLabel;
        }
    
  
       public void Arttir( int fiyat)
        {
          
            sepetFiyat += UrunFiyat;
            sepetLabel.Text = (sepetFiyat + UrunFiyat).ToString();

        }

        public void Azaltt(Label sepetLabel) 
        {
        
           if(sepetFiyat >= UrunFiyat) 
            {
                sepetFiyat -= UrunFiyat ;
                sepetLabel.Text = (sepetFiyat + UrunFiyat).ToString();
            }
        
        }

    }
}
