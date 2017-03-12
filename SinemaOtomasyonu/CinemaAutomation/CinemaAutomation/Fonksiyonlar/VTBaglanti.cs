using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using  MySql.Data.MySqlClient;

namespace CinemaAutomation.Fonksiyonlar
{
    class VTBaglanti
    {
        public MySqlConnection myConn;
        public MySqlDataAdapter dataAdapter;
        public DataSet dataSet1;
        public DataTable tablo;
        public MySqlCommand cmd;
        MySqlDataReader dr;

        //local host ile bağlantımı sağlayan metot
        public void mysqlBaglan()
        {
            string connect = @"server=localhost;database=cinema;uid=root;password=;";

            try
            {
                myConn = new MySqlConnection(connect);
                myConn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //tablo adı ve verin sutun ile o sütundaki verileri tablo olarak dönderen metot
        public DataTable combobxDoldur(string sutun, string tabl)
        {
            string table = tabl;
            string column = sutun;
            mysqlBaglan();
            try
            {
                string cmd = @"select " + column + " from " + table + "";
                dataAdapter = new MySqlDataAdapter(cmd, myConn);
                dataSet1 = new DataSet();
                dataAdapter.Fill(dataSet1);
                tablo = dataSet1.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return tablo;
        }

        //gelen sql ifadesini kayda alan metot
        public void kaydet(string komut)
        {
            mysqlBaglan();
            try
            {
                cmd = new MySqlCommand(komut, myConn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //tablo adini girdi olarak alıp tabloyu listeleyen metot
        public DataTable Listele(string tabloadi)
        {
            string komut = @"select * from "+tabloadi;
            mysqlBaglan();
            try
            {
                dataAdapter = new MySqlDataAdapter(komut, myConn);
                dataSet1 = new DataSet();
                dataAdapter.Fill(dataSet1);
                tablo = dataSet1.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return tablo;
        }
       
        //tablo adı sutun ve aranilan key verimesi durumunda tabloya gelecek olan veriyi dönen metot
        public DataTable Ara(string tabloadi,string sutun , string key)
        {
            string komut = @"select * from "+tabloadi+" where "+sutun+" like '%"+key+"%'";
            
            mysqlBaglan();
            try
            {
                dataAdapter = new MySqlDataAdapter(komut, myConn);
                dataSet1 = new DataSet();
                dataAdapter.Fill(dataSet1);
                tablo = dataSet1.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return tablo;
        }

        //Sisteme yetkisine göre giriş vermek için hazırlanılan metod
        public int giris(string tc, string sifre)
        {
            mysqlBaglan();
            try
            {
                cmd = new MySqlCommand("select * from tblpersonel where p_TC='" + tc + "' and p_Sifre='" + sifre + "'", myConn);

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["p_Yetki"].ToString() == "admin")
                    {
                        return 1;
                    }
                    else return 2;
                }
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return 0;
        }

        //Gelen select sorgusunu çalışıtran metot
        public DataTable Secim(string sorgu)
        {
            try
            {
                dataAdapter = new MySqlDataAdapter(sorgu, myConn);
                dataSet1 = new DataSet();
                dataAdapter.Fill(dataSet1);
                tablo = dataSet1.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return tablo;
        }

        //sql ifadesini ve sutunun adını verdikten sonra o sütundaki sayiyi geri dönen metot
        public int sqlSayi(string sqlAsk, string Sutun)
        {
            int sonuc = 0;
            mysqlBaglan();
            try
            {
                cmd = new MySqlCommand(sqlAsk, myConn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    sonuc = Convert.ToInt32(dr[Sutun].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return sonuc;
        }

        //sql ifadesini ve sutunu verdikten sonra kullanıcıya o sütündaki kelimeyi dönen metot
        public string sqlKelime(string sorgu, string sutun)
        {
            string kelime = "";
            mysqlBaglan();
            try
            {
                cmd = new MySqlCommand(sorgu, myConn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    kelime = (dr[sutun].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return kelime;
        }
    }
}
