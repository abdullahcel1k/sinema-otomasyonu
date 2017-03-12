using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using System.Drawing;
using System.Data;
using Newtonsoft.Json.Linq;
using System.Net;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace CinemaAutomation.Formlar
{
    
    public partial class frmAdmin : Form
    {
        Fonksiyonlar.VTBaglanti mysqlim = new Fonksiyonlar.VTBaglanti();
        MySqlCommand cmd;

        string personelTC;
        public frmAdmin(string personel)
        {
            InitializeComponent();
            personelTC = personel;
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            //form yüklendiğinde tabloların doldurulması
            gridPersonel.DataSource = mysqlim.Listele("tblpersonel");
            gridFilmler.DataSource = mysqlim.Listele("tblfilm");
            gridSeans.DataSource = mysqlim.Listele("tblseans");
            gridSalon.DataSource = mysqlim.Listele("tblsalon");
            gridBilet.DataSource = mysqlim.Listele("tblbilet");
            combobxdoldur("f_Adi","tblfilm");
            combobxdoldur("s_Id", "tblsalon");
            biletKontrol();
        }

        //Personel aratma metodu
        private void btnPersonelAra_Click(object sender, EventArgs e)
        {
            string sorgu;
            if (combobxSutun.Text == "TC")
            {
                sorgu = "select * from tblpersonel where p_TC like '%" + txtArama.Text + "%'";
                gridPersonel.DataSource = mysqlim.Secim(sorgu);
            }
            else if (combobxSutun.Text == "Ad")
            {
                sorgu = "select * from tblpersonel where p_Ad like '%" + txtArama.Text + "%'";
                gridPersonel.DataSource = mysqlim.Secim(sorgu);
            }
            else if (combobxSutun.Text == "Soyad")
            {
                sorgu = "select * from tblpersonel where p_Soyad like '%" + txtArama.Text + "%'";
                gridPersonel.DataSource = mysqlim.Secim(sorgu);
            }
            else if (combobxSutun.Text == "Telefon")
            {
                sorgu = "select * from tblpersonel where p_Telefon like '%" + txtArama.Text + "%'";
                gridPersonel.DataSource = mysqlim.Secim(sorgu);
            }else
            {
                gridPersonel.DataSource = mysqlim.Listele("tblpersonel");
            }

        }

        //personel ekleme
        private void btnPersoneladd_Click(object sender, EventArgs e)
        {
            string komut="insert into tblpersonel (p_TC,p_Ad,p_Soyad,p_Sifre,p_Mail,p_Telefon,p_Yetki) values ('"+txtTC.Text+ "','" + txtAd.Text + "','" + txtSoyad.Text+ "','" + txtSifre.Text+ "','" + txtMail.Text + "','" + txtTelefon.Text + "','" + combxYetki.SelectedItem.ToString() + "')";
            mysqlim.kaydet(komut);
            gridPersonel.DataSource = mysqlim.Listele("tblpersonel");
        }

        //alttaki iki metot grid den seçilen personelin bilgilerini textboxa basmayı sağlar
        private void gridPersonel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secili_Personel(e.RowIndex);
        }
        void secili_Personel(int str)
        {
            int i = str;
            DataGridViewRow row = gridPersonel.Rows[i];
            txtTC.Text = row.Cells["p_TC"].Value.ToString();
            txtAd.Text = row.Cells["p_Ad"].Value.ToString();
            txtSoyad.Text = row.Cells["p_Soyad"].Value.ToString();
            txtSifre.Text = row.Cells["p_Sifre"].Value.ToString();
            txtMail.Text = row.Cells["p_Mail"].Value.ToString();
            txtTelefon.Text = row.Cells["p_Telefon"].Value.ToString();
            combxYetki.Text = row.Cells["p_Yetki"].Value.ToString();
        }

        //Perseonel sil metodu
        private void btnPersonelsil_Click(object sender, EventArgs e)
        {
            string komut = "delete from tblpersonel where p_TC='"+txtTC.Text+"'";
            mysqlim.kaydet(komut);
            gridPersonel.DataSource = mysqlim.Listele("tblpersonel");
        }

        // imbde'den filmleri aratma
        private void btnFilmara_Click(object sender, EventArgs e)
        {
            if (txtFilmadi.Text != "" && txtFilmyili.Text != "")
                FilmAra();
            else
                MessageBox.Show("Film adını ve film yılını girip tekrar deneyin", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //imbdede film bilgilerini arayarak kullanıcıya film bilgierini dönderen metot örn : film adi film yili , film oyuncuları, film yönetmeni
        void FilmAra()
        {
            //this is a really simple api that i used :tears:
            string tit = txtFilmadi.Text;
            if (tit.Contains(" "))
                tit.Replace(" ", "+");
            WebClient webC = new WebClient();
            var movie = webC.DownloadString(string.Concat("http://www.omdbapi.com/?t=", tit, "&y=", txtFilmyili.Text, "&plot=short&r=json"));
            JObject jO = JObject.Parse(movie);
            if (!filmSonuc())
                MessageBox.Show("Film Bilgilerine Ulaşılamadı!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                VTtxtfilmadi.Text = jO["Title"].ToString();
                VTtxtfilmyili.Text = jO["Year"].ToString();
                VTtxtfilmsure.Text = jO["Runtime"].ToString();
                VTtxtyonetmen.Text = jO["Director"].ToString();
                VTtxtoyuncular.Text= jO["Actors"].ToString();
                VTtxtfilmturu.Text = jO["Genre"].ToString();
                VTpicboxfilm.ImageLocation=(jO["Poster"].ToString());
            }
        }

        //imbde webservisine bağlanarak film bilgilerine ulaşıp ulaşamadığı kontrolü
        private bool filmSonuc()
        {
            string tit = txtFilmadi.Text;
            WebClient webC = new WebClient();
            var movie = webC.DownloadString(string.Concat("http://www.omdbapi.com/?t=", tit, "&y=", comboxBilet.Text, "&plot=short&r=json"));
            JObject jO = JObject.Parse(movie);

            if ((string)jO["Response"].ToString() == "False")
                return false;
            else
                return true;
        }

        //filmleri girilen key'e göre arayıp bunları tekrar gride güncelleyen metot
        private void btnFilmlistele_Click(object sender, EventArgs e)
        {
            string sorgu;
            if (combobxfilm.Text == "Film adı")
            {
                sorgu = "select * from tblfilm where f_Adi like '%" + txtFilmara.Text + "%'";
                gridFilmler.DataSource = mysqlim.Secim(sorgu);
            }
            else if (combobxfilm.Text == "Oyuncu")
            {
                sorgu = "select * from tblfilm where f_Oyuncular like '%" + txtFilmara.Text + "%'";
                gridFilmler.DataSource = mysqlim.Secim(sorgu);
            }
            if (combobxfilm.Text == "Yönetmen")
            {
                sorgu = "select * from tblfilm where f_Yonetmen like '%" + txtFilmara.Text + "%'";
                gridFilmler.DataSource = mysqlim.Secim(sorgu);
            }
            else if (combobxfilm.Text == "Türü")
            {
                sorgu = "select * from tblfilm where f_Tur like '%" + txtFilmara.Text + "%'";
                gridFilmler.DataSource = mysqlim.Secim(sorgu);
            }
            else if (combobxfilm.Text == "Yılı")
            {
                sorgu = "select * from tblfilm where f_Yili like '%" + txtFilmara.Text + "%'";
                gridFilmler.DataSource = mysqlim.Secim(sorgu);
            }else if(combobxfilm.Text == "")
            {
                gridFilmler.DataSource = mysqlim.Listele("tblfilm");
            }
        }

        //Bilet arama yapan metot
        private void btnBiletara_Click(object sender, EventArgs e)
        {
            string sorgu;
            if (comboxBilet.Text == "Film adı")
            {
                sorgu = "select * from tblBilet where b_Film like '%" + txtBiletara.Text + "%'";
                gridBilet.DataSource = mysqlim.Secim(sorgu);
            }
        }

        //personel bilgilerini güncelleme
        private void btnPersonelGuncelle_Click(object sender, EventArgs e)
        {
            String komut = "update tblpersonel set p_Ad='" + txtAd.Text + "', p_Soyad='" + txtSoyad.Text + "', p_Sifre='" + txtSifre.Text + "', p_Mail='" + txtMail.Text + "', p_Telefon='" + txtTelefon.Text + "', p_Yetki='" + combxYetki.Text + "' where p_TC='" + txtTC.Text + "';";
            mysqlim.kaydet(komut);
            gridPersonel.DataSource = mysqlim.Listele("tblpersonel");
        }

        //imbdeden çekilen filmleri VT'nına ekleme
        private void btnFilmekle_Click(object sender, EventArgs e)
        {
            string komut = "insert into tblfilm (f_Adi,f_Yili,f_Sure,f_Yonetmen,f_Oyuncular,f_Tur,f_VGiris,f_VCikis) values ('" + VTtxtfilmadi.Text + "','" + VTtxtfilmyili.Text + "','"+VTtxtfilmsure.Text+"','" + VTtxtyonetmen.Text + "','" + VTtxtoyuncular.Text + "','" + VTtxtfilmturu.Text + "','" + VTdatetimegiris.Value.ToString("yyyy-MM-dd HH:mm") + "','" + VTdatetimecikis.Value.ToString("yyyy-MM-dd HH:mm") + "')";
            mysqlim.kaydet(komut);
            gridFilmler.DataSource = mysqlim.Listele("tblfilm");
        }

        private void btnSalonekle_Click(object sender, EventArgs e)
        {
            string komut = "insert into tblsalon (s_Id,s_Adi, s_Kapasite) values ('"+txtSalonno.Text+"','Salon "+txtSalonno.Text+"','"+txtKoltuksayi.Text+"')";
            mysqlim.kaydet(komut);
            
            txtKoltuksayi.Text = "";
            txtSalonno.Text = "";
            gridSalon.DataSource = mysqlim.Listele("tblsalon");

            
        }

        //seans ekleme işlemi yaptığı zaman bu seansa ve salona bağlı koltukların VT'nına eklenmesi
        void koltukekle(string salon,string seans)
        {
            string sorgu1 = "select *from tblsalon where s_Id=" +salon;
            int koltuksayi = mysqlim.sqlSayi(sorgu1, "s_Kapasite");
            int sirasayi = (koltuksayi / 10) + 1;
           
            int count = 1;
            for (int i = 0; i < sirasayi; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (count <= koltuksayi)
                    {
                        string kaydet = "insert into tblkoltuk (fk_Salonid,k_Seans,k_durum) values ('"+salon+"','"+ seans+"','boş')";
                        mysqlim.kaydet(kaydet);
                    }
                    count++;
                }
            }
        }

        //salon silme işlemi
        private void btnSalonsil_Click(object sender, EventArgs e)
        {
            string komut = "delete from tblsalon where s_Id='" + txtSalonno.Text + "'";
            mysqlim.kaydet(komut);
            txtKoltuksayi.Text = "";
            txtSalonno.Text = "";
            gridSalon.DataSource = mysqlim.Listele("tblsalon");
        }
        
        //salon tablosunda seçilen salonun bilgilerini textlere eklenmesi
        private void gridSalon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secili_Salon(e.RowIndex);
        }

        void secili_Salon(int str)
        {
            int i = str;
            DataGridViewRow row = gridSalon.Rows[i];
            txtSalonno.Text = row.Cells["s_Id"].Value.ToString();
            txtKoltuksayi.Text = row.Cells["s_Kapasite"].Value.ToString();
        }

        //vt'nında gönderilen sütun ve tablo adı altındaki bilgileri çekip combobax'a ekleyen kısım
        void combobxdoldur(string sutunadi, string tablo)
        {
            if (tablo == "tblfilm")
            {
                combobxSeansfilm.DataSource = mysqlim.combobxDoldur(sutunadi, tablo);
                combobxSeansfilm.DisplayMember =sutunadi;
            }else if (tablo=="tblsalon")
            {
                combobxSalon.DataSource = mysqlim.combobxDoldur(sutunadi, tablo);
                combobxSalon.DisplayMember = sutunadi;
                VTcombobxsalon.DataSource = mysqlim.combobxDoldur(sutunadi,tablo);
                VTcombobxsalon.DisplayMember = sutunadi;
            }else if (tablo == "tblseans")
            {
                combobxSeanssec.DataSource = mysqlim.combobxDoldur(sutunadi, tablo);
                combobxSeanssec.DisplayMember = sutunadi;
            }
            
        }

        // seans ekleme işlemi yapılan kısım
        private void btnSalonSeansEkle_Click(object sender, EventArgs e)
        {
            string komut = "insert into tblseans (seans_Saat,seans_Tarih, seans_Film, seans_Salon) values ('" + combxSeanssaat.Text + "','"+ datetimeSeans.Value.ToString("yyyy-MM-dd") + "','"+ combobxSeansfilm.Text + "','" + combobxSalon.Text + "')";
            mysqlim.kaydet(komut);
            koltukekle(combobxSalon.Text, combxSeanssaat.Text);
            txtKoltuksayi.Text = "";
            txtSalonno.Text = "";
            gridSeans.DataSource = mysqlim.Listele("tblseans");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //comboboxdaki seçilen salona göre o salona bağlı seansları seans comboboxına ekleyen kısım
        private void VTcombobxsalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            //seçilen salondaki seansları getiren kısım
            string sorgu = "SELECT seans_Saat FROM tblsalon JOIN tblseans ON '"+VTcombobxsalon.Text+"' = seans_Salon";
            combobxSeanssec.DataSource = mysqlim.Secim(sorgu);
            combobxSeanssec.DisplayMember = "seans_Saat";

        }

        //salon grubuna vt'nındaki koltuk sayısına ve koltuk durumuna(dolu,boş) gruba uygun bir şekilde eklenilmesi dinamik olaraka
        Button[,] btn = new Button[70, 70];
        void butonDoldur(string salon,string seans)
        {
            grupSalon.Controls.Clear();

            string sorgu1 = "select *from tblsalon where s_Id='" +salon+"'";
            int koltuksayi = mysqlim.sqlSayi(sorgu1, "s_Kapasite");
            int sirasayi = (koltuksayi / 10) + 1;
            int txt = 0;
            int count = 1;

            for (int i = 0; i < sirasayi; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (count <= koltuksayi)
                    {
                        string sorgu2 = "select *from tblkoltuk where fk_Salonid='" + salon +"' and k_Seans='"+seans+"' and k_Id="+count;
                        txt++;
                        btn[i, j] = new Button();
                        btn[i, j].Location = new Point(100 + j * 35, i * 35 + 15);
                        btn[i, j].Size = new Size(35, 35);
                        btn[i, j].UseVisualStyleBackColor = true;
                        btn[i, j].Name = "btn" + txt.ToString();
                        btn[i, j].FlatStyle = FlatStyle.Popup;
                        btn[i, j].Text = txt.ToString();
                        if ("boş" == mysqlim.sqlKelime(sorgu2, "k_durum") || "" == mysqlim.sqlKelime(sorgu2, "k_durum"))
                        {
                            btn[i, j].Image = Image.FromFile(@"image/kltSec.png");
                        }
                        else if ("dolu" == mysqlim.sqlKelime(sorgu2, "k_durum"))
                        {
                            btn[i, j].Image = Image.FromFile(@"image/kltSenin.png");
                        }
                        btn[i, j].Click += new EventHandler(this.button2_Click);
                        grupSalon.Controls.Add(btn[i, j]);
                    }
                    count++;
                }
            }
        }

        //dinamik olarak bütün koltukların clicklerinin bağlandığı kısım burdan hangi butonun seçildiğini anlayıp iptal etme işleminde buton resminin kontrolü
        int secildimi = 0;
        private void button2_Click(object sender, EventArgs e)
        {

            int satir, sutun;
            sutun = (((Button)sender).Location.X -100) / 35 ;
            satir = (((Button)sender).Location.Y - 15) / 35;

            if (secildimi != 0)
            {
                btn[satir, sutun].Image = Image.FromFile(@"image/kltSec.png");
                btnBiletkesdevam.Enabled = false;
                lblKoltukno.Text = btn[satir, sutun].Text;
                secildimi = 0;
            }
            else
            {
                btn[satir, sutun].Image = Image.FromFile("kltSenin.jpg");
                btnBiletkesdevam.Enabled = true;
                lblKoltukno.Text = btn[satir, sutun].Text;
                secildimi++;
            }
            
        }

        private void btnselonseans_Click(object sender, EventArgs e)
        {
            butonDoldur(VTcombobxsalon.Text, combobxSeanssec.Text);
        }

        //koltuğunu seçtikten sonra kullanıcıyı biletkesme tab sayfasına geçiren ve gerekli bilgileri aktarma
        private void btnBiletkesdevam_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(6);
            txtToplamucret.Text = "0";
        }

        private void radiobtnOgrenci_CheckedChanged(object sender, EventArgs e)
        {
            txtToplamucret.Text = "8 TL";
        }

        private void radiobtnNormal_CheckedChanged(object sender, EventArgs e)
        {
            txtToplamucret.Text = "12 TL";
        }

        //bilet satma işleminin kaydedilmesi
        private void btnBiletsat_Click(object sender, EventArgs e)
        {
            //seans tablosuna bağlanıp filmin adını çeken kısım
            string filmbul = "select *from tblseans where seans_Salon='"+VTcombobxsalon.Text+"' and seans_Saat='"+ combobxSeanssec.Text+ "'";
            string filmadi = mysqlim.sqlKelime(filmbul,"seans_Film");

            //koltuk bilgisine dolu olma kaydını yapma
            string kaydet = "update tblkoltuk set k_durum='dolu' where k_Id="+lblKoltukno.Text;
            mysqlim.kaydet(kaydet);


            //bilet kayıt yapan komut
            string biletKayit = "insert into tblbilet (b_Film,b_Salon,b_Seans,b_Koltuk,b_Personel,b_Tipi,b_Ucret) values ('"+filmadi+"','"+ VTcombobxsalon .Text+ "','"+ combobxSeanssec .Text+ "','"+lblKoltukno.Text+"','"+personelTC+"','Satış','"+txtToplamucret.Text+"')";
            mysqlim.kaydet(biletKayit);

            gridBilet.DataSource= mysqlim.Listele("tblbilet");

        }

        //bilet giridindeki seçili biletin tespit edilip silmek istenilmesi durumunda bilet idsinin alınması
        private void gridBilet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secili_Bilet(e.RowIndex);
        }

        void secili_Bilet(int str)
        {
            int i = str;
            DataGridViewRow row = gridBilet.Rows[i];
            lblBiletid.Text = row.Cells["b_Id"].Value.ToString();
            lblKoltukno.Text = row.Cells["b_Koltuk"].Value.ToString();
            combobxSeanssec.Text = row.Cells["b_Seans"].Value.ToString();
        }

        //seçili biletin idsinden faydalanılarak biletin iptal edilmesi ve koltuğun boşaltılması
        private void btnIptal_Click(object sender, EventArgs e)
        {
            string biletIptal = "delete from tblbilet WHERE b_Id=" + lblBiletid.Text;
            mysqlim.kaydet(biletIptal);
            string koltukBosalt = "update tblkoltuk set k_durum='boş' where k_Id="+lblKoltukno.Text+" and k_Seans='"+combobxSeanssec.Text+"'";
            mysqlim.kaydet(koltukBosalt);
            gridBilet.DataSource= mysqlim.Listele("tblbilet");
        }

        //biletin rezerve olarak kesilmesi
        private void btnRezerve_Click(object sender, EventArgs e)
        {
            //seans tablosuna bağlanıp filmin adını çeken kısım
            string filmbul = "select *from tblseans where seans_Salon='" + VTcombobxsalon.Text + "' and seans_Saat='" + combobxSeanssec.Text + "'";
            string filmadi = mysqlim.sqlKelime(filmbul, "seans_Film");

            //koltuk bilgisine dolu olma kaydını yapma
            string kaydet = "update tblkoltuk set k_durum='dolu' where k_Id=" + lblKoltukno.Text;
            mysqlim.kaydet(kaydet);


            //bilet kayıt yapan komut
            string biletKayit = "insert into tblbilet (b_Film,b_Salon,b_Seans,b_Koltuk,b_Personel,b_Tipi,b_Ucret) values ('" + filmadi + "','" + VTcombobxsalon.Text + "','" + combobxSeanssec.Text + "','" + lblKoltukno.Text + "','" + personelTC + "','Rezerv','" + txtToplamucret.Text + "')";
            mysqlim.kaydet(biletKayit);

            gridBilet.DataSource = mysqlim.Listele("tblbilet");
        }

        //burada filmin başlamasına 1 saat var ve müşteri rezerve işlemi yapmış ise bileti iptal eden kısım
        void biletKontrol()
        {
            //çok zekice birşeyler yaptık :P 
            //filmin zamanına 1 saat kalmış ve rezerv olan bilet hala alınmamış ise bileti iptal etmek
            string zamanKontrol = "select *from tblbilet where b_Tipi='Rezerv'";
            string saat = DateTime.Now.ToString("HH:mm:ss");
            string biletsaat = mysqlim.sqlKelime(zamanKontrol, "b_Seans");
            string biletid = mysqlim.sqlKelime(zamanKontrol, "b_Id");
            string rezerv = "01:00:00";

            //biletin tipi rezerv ve filmin oynmaasına 1 saat var ise biletin iptalini sağlıyoruz
            if (biletsaat != "")
            {
                if (Convert.ToDateTime(biletsaat) > Convert.ToDateTime((Convert.ToDateTime(saat) - Convert.ToDateTime(rezerv)).ToString()))
                {
                    string biletIptal = "delete from tblbilet WHERE b_Id=" + biletid;
                    mysqlim.kaydet(biletIptal);
                    gridBilet.DataSource = mysqlim.Listele("tblbilet");
                }
                else
                {

                }
            }
            gridBilet.DataSource= mysqlim.Listele("tblbilet");
        }

        //rezerve süresinin dolmasını tetikleme
        private void btnBiletkontrol_Click(object sender, EventArgs e)
        {
            biletKontrol();
            MessageBox.Show("Kontrol İşlemi Yapıldı");
        }
    }
}
