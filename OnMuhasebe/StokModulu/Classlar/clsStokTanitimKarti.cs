using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace OnMuhasebe.StokModulu.Classlar
{
    class clsStokTanitimKarti
    {
        OnMuhasebe.Classlar.Veritabani Dbase = new OnMuhasebe.Classlar.Veritabani();
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();

        public DataTable Listele(string StokKodu, string StokAdi, string Kod1, string Kod2, string Kod3, string Kod4, string Kod5)
        {
            string sql = "SELECT * FROM VWSTOKLAR WHERE STOKKODU LIKE'%" + StokKodu + "%' AND STOKADI LIKE'%" + StokAdi + "%' AND KOD1 LIKE'%" + Kod1 + "' AND KOD2 LIKE'%" + Kod2 + "' AND KOD3 LIKE'%" + Kod3 + "' AND KOD4 LIKE'%" + Kod4 + "' AND KOD5 LIKE'%" + Kod5 + "%'";
            DataTable dt = Dbase.TabloCek(sql);
            return dt;
        }
        public void Ekle(string StokKodu, string StokAdi, string IngIsim, string Kod1, string Kod2, string Kod3, string Kod4, string Kod5, string Birim, string Barkod, string AlisKdv, string SatisKdv, string AlisFiyat1, string AlisFiyat2, string SatisFiyat1, string SatisFiyat2, string UserId)
        {
            string sql = "EXECUTE SP_STOKEKLE '" + StokKodu + "','" + StokAdi + "','" + IngIsim + "','" + Kod1 + "','" + Kod2 + "','" + Kod3 + "','" + Kod4 + "','" + Kod5 + "','" + Birim + "','" + Barkod + "'," + AlisKdv.Replace(",",".").ToString() + "," + SatisKdv.Replace(",",".").ToString() + "," + AlisFiyat1.Replace(",", ".").ToString() + "," + AlisFiyat2.Replace(",", ".").ToString() + "," + SatisFiyat1.Replace(",", ".").ToString() + "," + SatisFiyat2.Replace(",", ".").ToString() + "," + UserId;
            Dbase.Isle(sql);
        }
        public void Guncelle(string Id, string StokKodu, string StokAdi, string IngIsim, string Kod1, string Kod2, string Kod3, string Kod4, string Kod5, string Birim, string Barkod, string AlisKdv, string SatisKdv, string AlisFiyat1, string AlisFiyat2, string SatisFiyat1, string SatisFiyat2, string UserId)
        {
            string sql = "EXECUTE SP_STOKGUNCELLE "+Id+",'" + StokKodu + "','" + StokAdi + "','" + IngIsim + "','" + Kod1 + "','" + Kod2 + "','" + Kod3 + "','" + Kod4 + "','" + Kod5 + "','" + Birim + "','" + Barkod + "'," + AlisKdv.Replace(",", ".").ToString() + "," + SatisKdv.Replace(",", ".").ToString() + "," + AlisFiyat1.Replace(",", ".").ToString() + "," + AlisFiyat2.Replace(",", ".").ToString() + "," + SatisFiyat1.Replace(",", ".").ToString() + "," + SatisFiyat2.Replace(",", ".").ToString() + "," + UserId;
            Dbase.Isle(sql);
        }
        public DataRow Ac(string Id)
        {
            string sql = "SELECT * FROM VWSTOKLAR WHERE ID=" + Id;
            return Dbase.Satir(sql);
        }
        public Boolean Sil(string Id)
        {
            if (StokHareketiVarMi(Id)==true)
            {
                Mesajlar.Uyari("Hareket görmüş Stok Kartını Silemezsiniz.");
                return false;
                    
            }
            else
            {
                string sql = "EXECUTE SP_STOKSIL " + Id;
                Dbase.Isle(sql);
                return true;
            }
            
           
        }

        string StokKoduAl(string id)
        {
            string sql = "SELECT STOKKODU FROM TBLSTOKLAR WHERE ID=" + id;
            return Dbase.SatirCek(sql)["STOKKODU"].ToString();
        }
        public Boolean StokHareketiVarMi(string Id)
        {
            string StokKodu =StokKoduAl(Id) ;

            string sql = "SELECT COUNT(*) AS ADET FROM VWSTOKHAR WHERE STOKKODU='" + StokKodu + "'";
            int Adet =Convert.ToInt32(Dbase.SatirCek(sql)["ADET"].ToString());
            if (Adet > 0)
            return true;
            return false;
        }

    }
}
