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
    public partial class frmGiris : Form
    {
        Fonksiyonlar.VTBaglanti myConn = new Fonksiyonlar.VTBaglanti();
        public frmGiris()
        {
            InitializeComponent();
        }

        // kulanıcının yetki tipini kontrol edip yetkisine göre form açma  
        private void btnGiris_Click(object sender, EventArgs e)
        {
            int giris = myConn.giris(txtPersonelTC.Text,txtSifre.Text);
            if(giris == 1)
            {
                frmAdmin frm = new frmAdmin(txtPersonelTC.Text);
                frm.ShowDialog();
            }else if(giris == 2)
            {
                frmKasiyer frm = new frmKasiyer(txtPersonelTC.Text);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Personel Kimlik numarası veya şifre yanlış !", "HATA OLUŞTU");
            }
            myConn.myConn.Close();
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
            myConn.mysqlBaglan();
        }
    }
}
