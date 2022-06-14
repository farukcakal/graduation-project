using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace OnMuhasebe.CariModulu.Classlar
{
    class clsCariHareketleri
    {
        OnMuhasebe.Classlar.Veritabani Dbase = new OnMuhasebe.Classlar.Veritabani();
        OnMuhasebe.Classlar.Formatlar Formatlar = new OnMuhasebe.Classlar.Formatlar();
        public DataTable Listele(string CariKodu)
        {
            string Sql = "SELECT * FROM VWCARIHAR WHERE CARIKODU='" + CariKodu + "'";
            return Dbase.TabloCek(Sql);
        }
        public Boolean CariAcilisKarti(string CariKodu, string BelgeNo, decimal Borc, decimal Alacak, string Tarih, string Aciklama)
        {
            try
            {
                string Sql = "EXECUTE SP_CARIHAR_EKLE '" + CariKodu + "', '" + BelgeNo + "',-1,'" + Formatlar.IngilizceTarihFormati(Tarih) + "','" + Borc.ToString().Replace(",", ".") + "','" + Alacak.ToString().Replace(",", ".") + "' ,'" + Aciklama + "','" + Formatlar.IngilizceTarihFormati(Tarih) + "' ,'A' ," + OnMuhasebe.frmAnaSayfa.UserId;
                Dbase.Isle(Sql);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
        public Boolean CariAcilisKartiGuncelle(string Id, string CariKodu, string BelgeNo, decimal Borc, decimal Alacak, string Tarih, string Aciklama)
        {
            try
            {
                string Sql = "EXECUTE SP_CARIHAR_GUNCELLE "+ Id +",'" + CariKodu + "','" + BelgeNo + "','" + Formatlar.IngilizceTarihFormati(Tarih) + "','" + Borc.ToString().Replace(",", ".") + "','" + Alacak.ToString().Replace(",", ".") + "' ,'" + Aciklama + "','" + Formatlar.IngilizceTarihFormati(Tarih) + "' ,'A' ," + OnMuhasebe.frmAnaSayfa.UserId;
                //MessageBox.Show(Sql);
                Dbase.Isle(Sql);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public Boolean CariAcilisKartiSil(string Id)
        {
            try
            {
                string Sql = "EXEC SP_CARIHAR_SIL " + Id;
                Dbase.Isle(Sql);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
        public DataRow CariAcilisKartiAc(string id)
        {
            string sql = "SELECT TOP 1 * FROM VWCARIHAR WHERE ID =" + id;
            return Dbase.Satir(sql);
        }
        public DataRow CariBakiye(string CariKodu)
        {
            string sql = "SELECT * FROM VWCARIBAKIYE WHERE CARIKODU='" + CariKodu + "'";
            return Dbase.SatirCek(sql);
        }
    }
}
