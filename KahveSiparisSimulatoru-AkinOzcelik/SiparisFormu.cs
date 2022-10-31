using KahveSiparisSimulatoru_AkinOzcelik.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace KahveSiparisSimulatoru_AkinOzcelik
{
    public partial class SiparisFormu : Form
    {
        //Program icin Form uzerinen kendi yapmis oldugum calismalarda kurmus oldugum bazi sistemleri kullandim. Iki adet class tanimladim, bunlar urunler ve ekstralardir. Bu bu classlar yardimi ile urunlere gerekli ozellikleri ve hazirlanma surelerini atadim. Elimde olan sure ile bu kadar yapabildim. (Programda class dosyasinda kalan diger class'lar basta denedigim fakat kullanamadigim class'lardir.)
        
        

        //Program siparisin alinmasinin ardindan butonlari sure bitimine kadar kapatiyor. Ayrica ilk calisalar formunda secilen kasa arkasi eleman sayisi kadar  buton ve siparis hatti calistiriyor. 
        
        //Akin Ozcelik 24.10.2022 OOP Marathon Kahve Simulatoru
       

        public List<Urunler> Urunler { get; set; } = new List<Urunler>()
        {
            new Urunler{UrunAdi = "Latte", BegenilmeOrani = "%80", HazirlanmaSuresi = 5},
            new Urunler{UrunAdi = "Americano", BegenilmeOrani = "%85", HazirlanmaSuresi = 1},
            new Urunler{UrunAdi = "Turk Kahvesi", BegenilmeOrani = "%100", HazirlanmaSuresi = 3},
            new Urunler{UrunAdi = "Espresso", BegenilmeOrani = "%70", HazirlanmaSuresi = 2},
            new Urunler{UrunAdi = "Cappucino", BegenilmeOrani = "%85", HazirlanmaSuresi = 4},
        };

        public List<EkstraMalzemeler> Ekstralar { get; set; } = new List<EkstraMalzemeler>()
        {
            new EkstraMalzemeler{EkstraAdi = "Sut", EkstraSuresi = 1},
            new EkstraMalzemeler{EkstraAdi = "Soguk Sut", EkstraSuresi = 1},
            new EkstraMalzemeler{EkstraAdi = "Sert Icim", EkstraSuresi = 2},
            new EkstraMalzemeler{EkstraAdi = "Sicak Sut", EkstraSuresi = 3},
            new EkstraMalzemeler{EkstraAdi = "Yumusak Icim", EkstraSuresi = 2},
            new EkstraMalzemeler{EkstraAdi = "Surup", EkstraSuresi = 1}
        };


        public SiparisFormu()
        {
            InitializeComponent();

            foreach (var item in Urunler)
            {
                
                listBoxUrunler.Items.Add( item.UrunAdi + " begenilme orani: " + item.BegenilmeOrani);
            }

            foreach(var item in Urunler)
            {
                listBoxHazirlanmaSureleri.Items.Add(item.UrunAdi + " Hazirlanma Suresi: " + (item.HazirlanmaSuresi) + " Dakika");

            }
        }



        private void SiparisFormu_Load(object sender, EventArgs e)
        {
            foreach (var items in Urunler)
            {
                cbUrunler.Items.Add(items.UrunAdi);
            }

            cbUrunler.SelectedIndex = 0;
        }





        int saniye1 = 60;
        int dakika1 = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            saniye1 = saniye1 - 1;
            lblSiparis1Saniye.Text = saniye1.ToString();
            lblSiparis1Dakika.Text = (dakika1-1).ToString();
            if(saniye1 == 0)
            {
                dakika1 = dakika1 - 1;
                lblSiparis1Dakika.Text = dakika1.ToString();
                saniye1 = 60;
            }
            if (lblSiparis1Dakika.Text == "-1")
            {
                timer1.Stop();
                btnSiparisVer1.Enabled = true;
                lblSiparis1Saniye.Text = "00";
                lblSiparis1Dakika.Text = "00";

            }

        }

        int saniye2 = 60;
        int dakika2 = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 1000;
            saniye2 = saniye2 - 1;
            lblSiparis2Saniye.Text = saniye2.ToString();
            lblSiparis2Dakika.Text = (dakika2 - 1).ToString();
            if (saniye2 == 0)
            {
                dakika2 = dakika2 - 1;
                lblSiparis2Dakika.Text = dakika2.ToString();
                saniye2 = 60;
            }
            if (lblSiparis2Dakika.Text == "-1")
            {
                timer1.Stop();
                btnSiparisVer2.Enabled = true;
                lblSiparis2Saniye.Text = "00";
                lblSiparis2Dakika.Text = "00";

            }

        }

        int saniye3 = 60;
        int dakika3 = 0;
        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Interval = 1000;
            saniye3 = saniye3 - 1;
            lblSiparis3Saniye.Text = saniye3.ToString();
            lblSiparis3Dakika.Text = (dakika3 - 1).ToString();
            if (saniye3 == 0)
            {
                dakika3 = dakika3 - 1;
                lblSiparis3Dakika.Text = dakika3.ToString();
                saniye3 = 60;
            }
            if (lblSiparis3Dakika.Text == "-1")
            {
                timer3.Stop();
                btnSiparisVer3.Enabled = true;
                lblSiparis3Saniye.Text = "00";
                lblSiparis3Dakika.Text = "00";
            }
        }

        int saniye4 = 60;
        int dakika4 = 0;
        private void timer4_Tick(object sender, EventArgs e)
        {
            timer4.Interval = 1000;
            saniye4 = saniye4 - 1;
            lblSiparis4Saniye.Text = saniye4.ToString();
            lblSiparis4Dakika.Text = (dakika4 - 1).ToString();
            if (saniye4 == 0)
            {
                dakika4 = dakika4 - 1;
                lblSiparis4Dakika.Text = dakika4.ToString();
                saniye4 = 60;
            }
            if (lblSiparis4Dakika.Text == "-1")
            {
                timer4.Stop();
                btnSiparisVer4.Enabled = true;
                lblSiparis4Saniye.Text = "00";
                lblSiparis4Dakika.Text = "00";
            }
        }

        private void lblSiparis1_Click(object sender, EventArgs e)
        {

        }


        private void btnSiparisVer1_Click(object sender, EventArgs e)
        {
             for (int i = 0; i < Urunler.Count; i++)
             {
                 if (cbUrunler.SelectedIndex == i)
                 {
                     dakika1 = Urunler[i].HazirlanmaSuresi ;

                 if (checkBoxSut.Checked == true)
                     dakika1 = dakika1 + Ekstralar[0].EkstraSuresi;
                 if (checkBoxSogukSut.Checked == true)
                     dakika1 = dakika1 + Ekstralar[1].EkstraSuresi;
                 if (checkBoxSertIcim.Checked == true)
                     dakika1 = dakika1 + Ekstralar[2].EkstraSuresi;
                 if (checkBoxSicakSut.Checked == true)
                     dakika1 = dakika1 + Ekstralar[3].EkstraSuresi;
                 if (checkBoxYumusakIcim.Checked == true)
                     dakika1 = dakika1 + Ekstralar[4].EkstraSuresi;
                 if (checkBoxSurup.Checked == true)
                     dakika1 = dakika1 + Ekstralar[5].EkstraSuresi;

                  timer1.Start();
                  btnSiparisVer1.Enabled = false;
                 
                 }
             }
        }

        private void btnSiparisVer2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Urunler.Count; i++)
            {
                if (cbUrunler.SelectedIndex == i)
                {
                    dakika2 = Urunler[i].HazirlanmaSuresi;
                    if (checkBoxSut.Checked == true)
                        dakika2 = dakika2 + Ekstralar[0].EkstraSuresi;
                    if (checkBoxSogukSut.Checked == true)
                        dakika2 = dakika2 + Ekstralar[1].EkstraSuresi;
                    if (checkBoxSertIcim.Checked == true)
                        dakika2 = dakika2 + Ekstralar[2].EkstraSuresi;
                    if (checkBoxSicakSut.Checked == true)
                        dakika2 = dakika2 + Ekstralar[3].EkstraSuresi;
                    if (checkBoxYumusakIcim.Checked == true)
                        dakika2 = dakika2 + Ekstralar[4].EkstraSuresi;
                    if (checkBoxSurup.Checked == true)
                        dakika2 = dakika2 + Ekstralar[5].EkstraSuresi;
                    timer2.Start();
                    btnSiparisVer2.Enabled = false;
                }
            }  
        }

        private void btnSiparisVer3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Urunler.Count; i++)
            {
                if (cbUrunler.SelectedIndex == i)
                {
                    dakika3 = Urunler[i].HazirlanmaSuresi;
                    if (checkBoxSut.Checked == true)
                        dakika3 = dakika3 + Ekstralar[0].EkstraSuresi;
                    if (checkBoxSogukSut.Checked == true)
                        dakika3 = dakika3 + Ekstralar[1].EkstraSuresi;
                    if (checkBoxSertIcim.Checked == true)
                        dakika3 = dakika3 + Ekstralar[2].EkstraSuresi;
                    if (checkBoxSicakSut.Checked == true)
                        dakika3 = dakika3 + Ekstralar[3].EkstraSuresi;
                    if (checkBoxYumusakIcim.Checked == true)
                        dakika3 = dakika3 + Ekstralar[4].EkstraSuresi;
                    if (checkBoxSurup.Checked == true)
                        dakika3 = dakika3 + Ekstralar[5].EkstraSuresi;
                    timer3.Start();
                    btnSiparisVer3.Enabled = false;
                }
            }

        }
        private void btnSiparisVer4_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < Urunler.Count; i++)
            {
                if (cbUrunler.SelectedIndex == i)
                {
                    dakika4 = Urunler[i].HazirlanmaSuresi;
                    if (checkBoxSut.Checked == true)
                        dakika4 = dakika4 + Ekstralar[0].EkstraSuresi;
                    if (checkBoxSogukSut.Checked == true)
                        dakika4 = dakika4 + Ekstralar[1].EkstraSuresi;
                    if (checkBoxSertIcim.Checked == true)
                        dakika4 = dakika4 + Ekstralar[2].EkstraSuresi;
                    if (checkBoxSicakSut.Checked == true)
                        dakika4 = dakika4 + Ekstralar[3].EkstraSuresi;
                    if (checkBoxYumusakIcim.Checked == true)
                        dakika4 = dakika4 + Ekstralar[4].EkstraSuresi;
                    if (checkBoxSurup.Checked == true)
                        dakika4 = dakika4 + Ekstralar[5].EkstraSuresi;
                    timer4.Start();
                    btnSiparisVer4.Enabled = false;
                }
            }
        }

        
        
        
    }
}



