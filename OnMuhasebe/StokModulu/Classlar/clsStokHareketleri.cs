using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
namespace OnMuhasebe.StokModulu.Classlar
{
    class clsStokHareketleri
    {
        OnMuhasebe.Classlar.Veritabani Dbase = new OnMuhasebe.Classlar.Veritabani();
        OnMuhasebe.Classlar.Formatlar formatlar = new OnMuhasebe.Classlar.Formatlar();

        public void Ekle(string FaturaNo, string GcKodu, DataTable Liste, string Tarih, string Tipi)
        {
            string StokKodu;
            int Miktar;
            decimal Fiyat, Isk1, Isk2, Kdv;

            for (int i = 0; i < Liste.Rows.Count; i++)
            {
                StokKodu = Liste.Rows[i]["STOKKODU"].ToString();
                Miktar = Convert.ToInt32(Liste.Rows[i]["MIKTAR"].ToString());
                Fiyat = Convert.ToDecimal(Liste.Rows[i]["BIRIMFIYAT"].ToString());
                Isk1 = Convert.ToDecimal(Liste.Rows[i]["ISK1"].ToString());
                Isk2 = Convert.ToDecimal(Liste.Rows[i]["ISK2"].ToString());
                Kdv = Convert.ToDecimal(Liste.Rows[i]["KDV"].ToString());

                string sql = "EXECUTE SP_STOKHAR_EKLE '" + FaturaNo + "','" + StokKodu + "','" + GcKodu + "'," + Miktar + "," + Fiyat.ToString().Replace(",", ".") + "," + Isk1.ToString().Replace(",", ".") + "," + Isk2.ToString().Replace(",", ".") + "," + Kdv.ToString().Replace(",", ".") + ",'" + Tipi + "','" + Tarih + "'," + frmAnaSayfa.UserId;
                Dbase.Isle(sql);
            }
            
        }
        public DataTable Listele(string StokKodu)
        {
            string Sql = "SELECT * FROM VWSTOKHAR WHERE STOKKODU='" + StokKodu + "' ORDER BY TARIH ASC";
            return Dbase.TabloCek(Sql);

        }
        public DataRow StokBakiye(string StokKodu)
        {
            string Sql = "SELECT * FROM VWSTOKBAKIYE WHERE STOKKODU='" + StokKodu + "'";
            return Dbase.SatirCek(Sql);

        }
        public Boolean StokAcilisKarti(string BelgeNo, string StokKodu, string GcKodu, string Miktar, string Fiyat, string Kdv, string Tarih)
        {
            try
            {
                string Sql = "EXECUTE SP_STOKHAR_EKLE '" + BelgeNo + "','" + StokKodu + "','" + GcKodu + "','" + Miktar + "'," + Fiyat.Replace(",", ".").ToString() + ",0,0,'" + Kdv.Replace(",",".") + "',A,'" + formatlar.IngilizceTarihFormati(Tarih) + "'," + OnMuhasebe.frmAnaSayfa.UserId;
                Dbase.Isle(Sql);
                return true;

            }
            catch (Exception)
            {

                return false;

            }
            

        }
        public Boolean StokAcilisKartiGuncelle(string Id, string BelgeNo, string StokKodu, string GcKodu, string Miktar, string Fiyat, string Kdv, string Tarih)
        {
            try
            {
                string Sql = "EXECUTE SP_STOKHAR_GUNCELLE '" +Id+ BelgeNo + "','" + StokKodu + "','" + GcKodu + "','" + Miktar + "'," + Fiyat.Replace(",", ".").ToString() + ",0,0,'" + Kdv.Replace(",", ".") + "',A,'" + formatlar.IngilizceTarihFormati(Tarih) + "'," + OnMuhasebe.frmAnaSayfa.UserId;
                Dbase.Isle(Sql);
                return true;

            }
            catch (Exception)
            {

                return false;

            }


        }
        public DataRow StokAcilisKartiAc(string Id)
        {
            string Sql = "SELECT top 1 * FROM VWSTOKHAR WHERE ID" + Id;
            return Dbase.SatirCek(Sql);
        }
        public Boolean StokAcilisKartiSil(string ıd)
        {
            try
            {
                string sql = "EXECUTE SP_STOKHAR_SIL " + ıd;
                Dbase.Isle(sql);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
