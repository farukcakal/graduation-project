using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OnMuhasebe.Classlar
{
    class Veritabani
    {
        Mesajlar Mesajlar = new Mesajlar();
        Ekranlar Ekranlar = new Ekranlar();
        public SqlConnection Baglan()
        {
            string provider = "Data Source=" + OnMuhasebe.Properties.Settings.Default.ServerIpAdresi + ";Initial Catalog=" + OnMuhasebe.Properties.Settings.Default.Veritabani + ";Persist Security Info=True;User ID=" + OnMuhasebe.Properties.Settings.Default.VeritabaniKullanici + ";Password=" + OnMuhasebe.Properties.Settings.Default.VeritabaniSifre;
            SqlConnection conn = new SqlConnection(provider);
            try
            {
                conn.Open();
                
            }
            catch (Exception)
            {
                Mesajlar.Uyari("Veritabanı bağlantısı kurulamadı. Veritabanı bağlantı ayarları menüsüne yönlendiriliyorsunuz.");
                Ekranlar.ServerAyarlari();
            }
            return conn;

        }
        public DataTable TabloCek(string sql)
        {
            DataTable tb = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter(sql, this.Baglan());
            adap.Fill(tb);
            return tb;
        }

        public DataRow SatirCek(string sql) 
            {
            try
            {
                DataRow satir = TabloCek(sql).Rows[0];
                return satir;
            }
            catch (Exception)
            {

                throw;
            }


            } 
        public DataRow Satir(string sql)
        {
            try
            {
                //MessageBox.Show(sql);
                DataRow satir = TabloCek(sql).Rows[0];
                return satir;
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        public void Isle(string sql)
        {
            SqlCommand islem = new SqlCommand(sql, this.Baglan());
           // MessageBox.Show(sql);
            islem.ExecuteNonQuery();
        }
    }
}
