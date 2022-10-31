using KahveSiparisSimulatoru_AkinOzcelik.Classes;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace KahveSiparisSimulatoru_AkinOzcelik
{

    //Program icin Form uzerinen kendi yapmis oldugum calismalarda kurmus oldugum bazi sistemleri kullandim. Iki adet class tanimladim, bunlar urunler ve ekstralardir. Bu bu classlar yardimi ile urunlere gerekli ozellikleri ve hazirlanma surelerini atadim. Elimde olan sure ile bu kadar yapabildim. (Programda class dosyasinda kalan diger class'lar basta denedigim fakat kullanamadigim class'lardir.)

  
    //Program siparisin alinmasinin ardindan butonlari sure bitimine kadar kapatiyor. Ayrica ilk calisalar formunda secilen kasa arkasi eleman sayisi kadar  buton ve siparis hatti calistiriyor. 


    //Akin Ozcelik 24.10.2022 OOP Marathon Kahve Simulatoru

    public partial class Form1 : Form
    {
        int clickCountCalisan1 =0;
        int clickCountCalisan2 =0;
        int clickCountCalisan3 =0;
        int clickCountCalisan4 =0;

        int clickCountKasa1 = 0;
        int clickCountKasa2 = 0;
        int clickCountKasa3 = 0;


        int kasaArkasi = 0;
        int calisanSayisi = 0;
        
       
        public Form1()
        {
            InitializeComponent();
            if (nudCalisanSayisi.Value >= 5)
            {
                MessageBox.Show("Kasa arkasi calisan sayisi 4'ten buyuk olamaz");
                nudCalisanSayisi.Value = 4;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void pbCalisan1_Click(object sender, EventArgs e)
        {
            clickCountCalisan1++;
            if (clickCountCalisan1 % 2 == 1)
            {
                pbCalisan1.Image = KahveSiparisSimulatoru_AkinOzcelik.Properties.Resources.barisa;
                pbCalisan1.SizeMode = PictureBoxSizeMode.Zoom;
                calisanSayisi++;
                kasaArkasi++;
                lblCalisanSayisi.Text = "CALISAN SAYISI: " + calisanSayisi.ToString();
                 

            }
            else if (clickCountCalisan1 % 2 == 0)
            {
                pbCalisan1.Image = null;
                calisanSayisi--;
                kasaArkasi--;
            }
            
            if(calisanSayisi >= 6)
            {
                MessageBox.Show("Toplam çalışan sayısı 5 kişidir!!");
                pbCalisan1.Image = null;
                calisanSayisi--;
                kasaArkasi--;
                lblCalisanSayisi.Text = "CALISAN SAYISI: " + calisanSayisi.ToString();
                 
                Kapatici();
            }

            
        }

        private void pbCalisan2_Click(object sender, EventArgs e)
        {
            clickCountCalisan2++;
            if (clickCountCalisan2 % 2 == 1)
            {
                pbCalisan2.Image = KahveSiparisSimulatoru_AkinOzcelik.Properties.Resources.barisa;
                pbCalisan2.SizeMode = PictureBoxSizeMode.Zoom;
                
                calisanSayisi++;
                kasaArkasi++;
                lblCalisanSayisi.Text = "CALISAN SAYISI: " + calisanSayisi.ToString();
                 
            }
            else if (clickCountCalisan2 % 2 == 0)
            {
                pbCalisan2.Image = null;
                
                calisanSayisi--;
                kasaArkasi--;
                
            }
            if (calisanSayisi >= 6)
            {
                MessageBox.Show("Toplam çalışan sayısı 5 kişidir!!");
                pbCalisan2.Image = null;
                
                calisanSayisi--;
                kasaArkasi--;
                lblCalisanSayisi.Text = "CALISAN SAYISI: " + calisanSayisi.ToString();
                 
                Kapatici();
            }
        }

        private void pbCalisan3_Click(object sender, EventArgs e)
        {
            clickCountCalisan3++;
            if (clickCountCalisan3 % 2 == 1)
            {
                pbCalisan3.Image = KahveSiparisSimulatoru_AkinOzcelik.Properties.Resources.barisa;
                pbCalisan3.SizeMode = PictureBoxSizeMode.Zoom;
                
                calisanSayisi++;
                kasaArkasi++;
                lblCalisanSayisi.Text = "CALISAN SAYISI: " + calisanSayisi.ToString();
                 
                
            }
            else if (clickCountCalisan3 % 2 == 0)
            {
                pbCalisan3.Image = null;
                
                calisanSayisi--;
                kasaArkasi--;
            }
            if (calisanSayisi >= 6)
            {
                MessageBox.Show("Toplam çalışan sayısı 5 kişidir!!");
                pbCalisan3.Image = null;
                
                calisanSayisi--;
                kasaArkasi--;
                lblCalisanSayisi.Text = "CALISAN SAYISI: " + calisanSayisi.ToString();
                 
                Kapatici();
            }
        }
        private void pbCalisan4_Click(object sender, EventArgs e)
        {
            clickCountCalisan4++;
            if (clickCountCalisan4 % 2 == 1)
            {
                pbCalisan4.Image = KahveSiparisSimulatoru_AkinOzcelik.Properties.Resources.barisa;
                pbCalisan4.SizeMode = PictureBoxSizeMode.Zoom;
                
                calisanSayisi++;
                kasaArkasi++;
                lblCalisanSayisi.Text = "CALISAN SAYISI: " + calisanSayisi.ToString();
                 
            }
            else if (clickCountCalisan4 % 2 == 0)
            {
                pbCalisan4.Image = null;
                
                calisanSayisi--;
                kasaArkasi--;
            }
            if (calisanSayisi >= 6 )
            {
                MessageBox.Show("Toplam çalışan sayısı 5 kişidir!!");
                pbCalisan4.Image = null;
                
                calisanSayisi--;
                kasaArkasi--;
                lblCalisanSayisi.Text = "CALISAN SAYISI: " + calisanSayisi.ToString();
                 
                Kapatici();
            }
        }

        private void pbKasa1_Click(object sender, EventArgs e)
        {
            clickCountKasa1++;
            if (clickCountKasa1 % 2 == 1)
            {
                pbKasa1.Image = KahveSiparisSimulatoru_AkinOzcelik.Properties.Resources.cashier;
                pbKasa1.SizeMode = PictureBoxSizeMode.Zoom;
                calisanSayisi++;
                lblCalisanSayisi.Text = "CALISAN SAYISI: " + calisanSayisi.ToString();
                
            }
            else if (clickCountKasa1 % 2 == 0)
            {
                pbKasa1.Image = null;
                calisanSayisi--;
            }
            if (calisanSayisi >= 6)
            {
                MessageBox.Show("Toplam çalışan sayısı 5 kişidir!!");
                pbKasa1.Image = null;
                calisanSayisi--;
                lblCalisanSayisi.Text = "CALISAN SAYISI: " + calisanSayisi.ToString();
                Kapatici();
            }
        }

        private void pbKasa2_Click(object sender, EventArgs e)
        {
            clickCountKasa2++;
            if (clickCountKasa2 % 2 == 1)
            {
                pbKasa2.Image = KahveSiparisSimulatoru_AkinOzcelik.Properties.Resources.cashier;
                pbKasa2.SizeMode = PictureBoxSizeMode.Zoom;
                calisanSayisi++;
                lblCalisanSayisi.Text = "CALISAN SAYISI: " + calisanSayisi.ToString();
            }
            else if (clickCountKasa2 % 2 == 0)
            {
                pbKasa2.Image = null;
                calisanSayisi--;
            }
            if (calisanSayisi >= 6)
            {
                MessageBox.Show("Toplam çalışan sayısı 5 kişidir!!");
                pbKasa2.Image = null;
                calisanSayisi--;
                lblCalisanSayisi.Text = "CALISAN SAYISI: " + calisanSayisi.ToString();
                Kapatici();
            }
        }

        private void pbKasa3_Click(object sender, EventArgs e)
        {
            clickCountKasa3++;
            if (clickCountKasa3 % 2 == 1)
            {
                pbKasa3.Image = KahveSiparisSimulatoru_AkinOzcelik.Properties.Resources.cashier;
                pbKasa3.SizeMode = PictureBoxSizeMode.Zoom;
                calisanSayisi++;
                lblCalisanSayisi.Text = "CALISAN SAYISI: " + calisanSayisi.ToString();
            }
            else if (clickCountKasa3 % 2 == 0)
            {
                pbKasa3.Image = null;
                calisanSayisi--;
            }
            if (calisanSayisi >= 6)
            {
                MessageBox.Show("Toplam çalışan sayısı 5 kişidir!!");
                pbKasa3.Image = null;
                calisanSayisi--;
                lblCalisanSayisi.Text = "CALISAN SAYISI: " + calisanSayisi.ToString();
                Kapatici();
            }

            

        }
        private void Temizleyici()
        {
            pbCalisan1.Image = null;
            pbCalisan2.Image = null;
            pbCalisan3.Image = null;
            pbCalisan4.Image = null;
            pbKasa1.Image = null;
            pbKasa2.Image = null;
            pbKasa3.Image = null;

            calisanSayisi = 0;
            kasaArkasi = 0;

            clickCountCalisan1 = 0;
            clickCountCalisan2 = 0;
            clickCountCalisan3 = 0;
            clickCountCalisan4 = 0;
            
            clickCountKasa1 = 0;
            clickCountKasa2 = 0;
            clickCountKasa3 = 0;

            pbCalisan1.Enabled = true;
            pbCalisan2.Enabled = true;
            pbCalisan3.Enabled = true;
            pbCalisan4.Enabled = true;
            pbKasa1.Enabled = true;
            pbKasa2.Enabled = true;
            pbKasa3.Enabled = true;

            lblCalisanSayisi.Text = "CALISAN SAYISI: " + calisanSayisi.ToString();
        }

        private void Kapatici()
        {
            pbCalisan1.Enabled = false;
            pbCalisan2.Enabled = false;
            pbCalisan3.Enabled = false;
            pbCalisan4.Enabled = false;
            pbKasa1.Enabled = false;
            pbKasa2.Enabled = false;
            pbKasa3.Enabled = false;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizleyici();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (calisanSayisi == 5)
            {
                SiparisFormu siparisFormu = new SiparisFormu();

                nudCalisanSayisi.Value = kasaArkasi;


                if(nudCalisanSayisi.Value == 3)
                {
                    siparisFormu.btnSiparisVer4.Enabled = false;
                }
                if(nudCalisanSayisi.Value == 2)
                {
                    siparisFormu.btnSiparisVer3.Enabled = false;
                    siparisFormu.btnSiparisVer4.Enabled = false;
                }
                if (nudCalisanSayisi.Value == 1)
                {
                    siparisFormu.btnSiparisVer2.Enabled = false;
                    siparisFormu.btnSiparisVer3.Enabled = false;
                    siparisFormu.btnSiparisVer4.Enabled = false;
                }
                
                siparisFormu.ShowDialog();

            }
            else
            {
                MessageBox.Show("Calisan Sayisi 5'ten buyuk veya kucuk olamaz!!!");
                
            }




            


        }

        private void lblCalisanSayisi_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}