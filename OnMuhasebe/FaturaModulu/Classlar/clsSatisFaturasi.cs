using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace OnMuhasebe.FaturaModulu.Classlar
{
    class clsSatisFaturasi
    {
        OnMuhasebe.Classlar.Veritabani Dbase = new OnMuhasebe.Classlar.Veritabani();
        OnMuhasebe.Classlar.Formatlar Formatlar = new OnMuhasebe.Classlar.Formatlar();
        StokModulu.Classlar.clsStokHareketleri StokHareketleri = new StokModulu.Classlar.clsStokHareketleri();
         
        
        public Boolean Ekle(string FaturaNo, string CariKodu, string Tarih, string VadeTarihi, string GenelToplam, string Turu, string Aciklama, DataTable Detaylar)
        {
            try
            {
                string Tipi = "S";
                string sql = "EXECUTE SP_FATURA_EKLE '" + FaturaNo + "','" + CariKodu + "','" + Formatlar.IngilizceTarihFormati(Tarih) + "','" + Formatlar.IngilizceTarihFormati(VadeTarihi) + "','" + GenelToplam.Replace(",", ".") + "','" + Turu + "','" + Tipi + "','" + Aciklama + "'," + frmAnaSayfa.UserId.ToString();
                Dbase.Isle(sql);
                StokHareketleri.Ekle(FaturaNo, "G", Detaylar, Formatlar.IngilizceTarihFormati(Tarih), Tipi);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        public Boolean Guncelle(string Id, string FaturaNo, string CariKodu, string Tarih, string VadeTarihi, string GenelToplam, string Turu, string Aciklama, DataTable Detaylar)
        {
            try
            {
                string Tipi = "S";
                string sql = "EXECUTE SP_FATURA_GUNCELLE '" + Id + ",'" + FaturaNo + "','" + CariKodu + "','" + Formatlar.IngilizceTarihFormati(Tarih) + "','" + Formatlar.IngilizceTarihFormati(VadeTarihi) + "','" + GenelToplam.Replace(",", ".") + "','" + Turu + "','" + Tipi + "','" + Aciklama + "'," + frmAnaSayfa.UserId.ToString();
                Dbase.Isle(sql);
                if (FaturaDetaylariniSil(FaturaNo) == true)
                {
                    StokHareketleri.Ekle(FaturaNo, "G", Detaylar, Formatlar.IngilizceTarihFormati(Tarih), Tipi);
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
         public void Sil(string Id)
        {
            string sql = "EXECUTE SP_FATURA_SIL " + Id;
            Dbase.Isle(sql);
        }
        public DataTable Listele(string CariKodu, string CariAdi, string FaturaNo)
        {
            string sql = "SELECT * FROM VWFATURALAR WHERE CARIKODU LIKE '%" + CariKodu + "%' AND CARIISIM LIKE '%" + CariAdi + "%' AND FATURANO LIKE '%" + FaturaNo + "%'";
            return Dbase.TabloCek(sql);
        }
        public DataRow Ac(string FaturaNo)
        {
            string sql = "SELECT TOP 1 * FROM VWFATURALAR WHERE FATURANO = '" + FaturaNo + "'";
            return Dbase.Satir(sql);
        }

        public DataTable KalemleriAc(string FaturaNo)
        {
            string sql = "SELECT * FROM VWSTOKHAR WHERE FATURANO = '" + FaturaNo + "'";
            return Dbase.TabloCek(sql);
        }

        public Boolean FaturaDetaylariniSil(string Faturano)
        {
            try
            {
                string sql = "EXECUTE SP_FATURAKALEMLERI_SIL'" + Faturano + "'";
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