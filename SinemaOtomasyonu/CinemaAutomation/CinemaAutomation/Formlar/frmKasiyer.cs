using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaAutomation.Formlar
{
    public partial class frmKasiyer : Form
    {
        Fonksiyonlar.VTBaglanti mysqlim = new Fonksiyonlar.VTBaglanti();

        string PersonelTC;
        public frmKasiyer(string personel)
        {
            InitializeComponent();
            PersonelTC = personel;
        }

        private void frmKasiyer_Load(object sender, EventArgs e)
        {
            //formun yüklenmesi durumun tablonun listelenmesi
            gridBilet.DataSource = mysqlim.Listele("tblbilet");
            //form yüklenmesi durumunda salon id nin comboboxa eklenmesi
            combobxdoldur("s_Id", "tblsalon");
            //rezerve biletlerin kontrol edilerek 1 saaat ten az zaman kalan biletlerin silinmesi
            biletKontrol();
        }

        //bilet arama işlemi
        private void btnBiletara_Click(object sender, EventArgs e)
        {
            string sorgu;
            if (comboxBilet.Text == "Film adı")
            {
                sorgu = "select * from tblBilet where b_Film like '%" + txtBiletara.Text + "%'";
                gridBilet.DataSource = mysqlim.Secim(sorgu);
            }
        }

        //seçili biletin tespit edilip kullanılmak için id'sinin label'a eklenmesi
        private void gridBilet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secili_Bilet(e.RowIndex);
        }

        void secili_Bilet(int str)
        {
            int i = str;
            DataGridViewRow row = gridBilet.Rows[i];
            lblBiletid.Text = row.Cells["b_Id"].Value.ToString();
        }

        //idsi belirlenmiş biletin iptali
        private void btnIptal_Click(object sender, EventArgs e)
        {
            string biletIptal = "delete from tblbilet WHERE b_Id=" + lblBiletid.Text;
            mysqlim.kaydet(biletIptal);
            gridBilet.DataSource = mysqlim.Listele("tblbilet");
        }

        private void btnselonseans_Click(object sender, EventArgs e)
        {
            butonDoldur(VTcombobxsalon.Text, combobxSeanssec.Text);
        }

        //VT'nındaki koltukların durumunnun(dolu,boş) kontrol edilerek dinamik olarak koltukların eklenmesi
        Button[,] btn = new Button[70, 70];
        void butonDoldur(string salon, string seans)
        {
            grupSalon.Controls.Clear();

            string sorgu1 = "select *from tblsalon where s_Id='" + salon + "'";
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
                        string sorgu2 = "select *from tblkoltuk where fk_Salonid='" + salon + "' and k_Seans='" + seans + "' and k_Id=" + count;
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
                            btn[i, j].Image = Image.FromFile(@"C:\Users\Abdullah\Documents\Visual Studio 2015\Projects\CinemaAutomation\CinemaAutomation\kltSec.png");
                        }
                        else if ("dolu" == mysqlim.sqlKelime(sorgu2, "k_durum"))
                        {
                            btn[i, j].Image = Image.FromFile(@"C:\Users\Abdullah\Documents\Visual Studio 2015\Projects\CinemaAutomation\CinemaAutomation\kltSenin.png");
                        }
                        btn[i, j].Click += new EventHandler(this.button2_Click);
                        grupSalon.Controls.Add(btn[i, j]);
                    }
                    count++;
                }
            }
        }

        //seçili koltuğun tespit edilmesi
        int secildimi = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            int satir, sutun;
            sutun = (((Button)sender).Location.X - 100) / 35;
            satir = (((Button)sender).Location.Y - 15) / 35;

            if (secildimi != 0)
            {
                btn[satir, sutun].Image = Image.FromFile(@"C:\Users\Abdullah\Documents\Visual Studio 2015\Projects\CinemaAutomation\CinemaAutomation\kltSec.png");
                btnBiletkesdevam.Enabled = false;
                lblKoltukno.Text = btn[satir, sutun].Text;
                secildimi = 0;
            }
            else
            {
                btn[satir, sutun].Image = Image.FromFile(@"C:\Users\Abdullah\Documents\Visual Studio 2015\Projects\CinemaAutomation\CinemaAutomation\kltSatildi.png");
                btnBiletkesdevam.Enabled = true;
                lblKoltukno.Text = btn[satir, sutun].Text;
                secildimi++;
            }

        }

        //salon comboboxının doldurulması
        void combobxdoldur(string sutunadi, string tablo)
        {
            if (tablo == "tblsalon")
            {
                VTcombobxsalon.DataSource = mysqlim.combobxDoldur(sutunadi, tablo);
                VTcombobxsalon.DisplayMember = sutunadi;
            }

        }

        //koltuk seçildikten sonra bilet kesme işlemine devam etmesi için kullanıcının bilet kes sayfaasına geçirilmesi
        private void btnBiletkesdevam_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
            txtToplamucret.Text = "0";
        }

        //Bilet satma işlemi
        private void btnBiletsat_Click(object sender, EventArgs e)
        {
            //seans tablosuna bağlanıp filmin adını çeken kısım
            string filmbul = "select *from tblseans where seans_Salon='" + VTcombobxsalon.Text + "' and seans_Saat='" + combobxSeanssec.Text + "'";
            string filmadi = mysqlim.sqlKelime(filmbul, "seans_Film");

            //koltuk bilgisine dolu olma kaydını yapma
            string kaydet = "update tblkoltuk set k_durum='dolu' where k_Id=" + lblKoltukno.Text;
            mysqlim.kaydet(kaydet);


            //bilet kayıt yapan komut
            string biletKayit = "insert into tblbilet (b_Film,b_Salon,b_Seans,b_Koltuk,b_Personel,b_Tipi,b_Ucret) values ('" + filmadi + "','" + VTcombobxsalon.Text + "','" + combobxSeanssec.Text + "','" + lblKoltukno.Text + "','" + PersonelTC + "','Satış','" + txtToplamucret.Text + "')";
            mysqlim.kaydet(biletKayit);

            gridBilet.DataSource = mysqlim.Listele("tblbilet");
        }

        //seçilen salondaki seansları seans comboboxına eklenmesi
        private void VTcombobxsalon_SelectedIndexChanged(object sender, EventArgs e)
        { 
            string sorgu = "SELECT seans_Saat FROM tblsalon JOIN tblseans ON '" + VTcombobxsalon.Text + "' = seans_Salon";
            combobxSeanssec.DataSource = mysqlim.Secim(sorgu);
            combobxSeanssec.DisplayMember = "seans_Saat";
        }

        //radio butnlardan seçili olan ile ücretin belirlenmesi
        private void radiobtnNormal_CheckedChanged(object sender, EventArgs e)
        {
            txtToplamucret.Text = "12 TL";
        }

        private void radiobtnOgrenci_CheckedChanged(object sender, EventArgs e)
        {
            txtToplamucret.Text = "8 TL";
        }

        //rezerve işlemi yapılan biletiern 1 saatten az süre kalması durumunda iptal edilmesi
        void biletKontrol()
        {
            //çok zekice birşeyler yaptık :P 
            //filmin zamanına 1 saat kalmış ve rezerv olan bilet hala alınmamış ise bileti iptal etmek
            string zamanKontrol = "select *from tblbilet where b_Tipi='rezerv'";
            string saat = DateTime.Now.ToString("HH:mm:ss");
            string biletsaat = mysqlim.sqlKelime(zamanKontrol,"b_Seans");
            string biletid = mysqlim.sqlKelime(zamanKontrol,"b_Id");
            string rezerv = "01:00:00";

            //biletin tipi rezerv ve filmin oynmaasına 1 saat var ise biletin iptalini sağlıyoruz
            if (biletsaat!="")
            {
                if (Convert.ToDateTime(biletsaat) < Convert.ToDateTime((Convert.ToDateTime(saat) - Convert.ToDateTime(rezerv)).ToString()))
                {
                    string biletiptal = "delete from tblbilet where b_Id=" + biletid;
                    mysqlim.kaydet(biletiptal);
                }
                else
                {

                }
            }
            gridBilet.DataSource = mysqlim.Listele("tblbilet");
        }

        //bilet iptal işlemi
        private void btnBiletiptal_Click(object sender, EventArgs e)
        {
            biletKontrol();
            MessageBox.Show("Kontrol İşlemi Yapıldı");
        }

        //bilet rezervasyon işlemi
        private void btnRezerve_Click(object sender, EventArgs e)
        {
            //seans tablosuna bağlanıp filmin adını çeken kısım
            string filmbul = "select *from tblseans where seans_Salon='" + VTcombobxsalon.Text + "' and seans_Saat='" + combobxSeanssec.Text + "'";
            string filmadi = mysqlim.sqlKelime(filmbul, "seans_Film");

            //koltuk bilgisine dolu olma kaydını yapma
            string kaydet = "update tblkoltuk set k_durum='dolu' where k_Id=" + lblKoltukno.Text;
            mysqlim.kaydet(kaydet);


            //bilet kayıt yapan komut
            string biletKayit = "insert into tblbilet (b_Film,b_Salon,b_Seans,b_Koltuk,b_Personel,b_Tipi,b_Ucret) values ('" + filmadi + "','" + VTcombobxsalon.Text + "','" + combobxSeanssec.Text + "','" + lblKoltukno.Text + "','" + PersonelTC + "','Rezerv','" + txtToplamucret.Text + "')";
            mysqlim.kaydet(biletKayit);

            gridBilet.DataSource = mysqlim.Listele("tblbilet");
        }
    }
}
