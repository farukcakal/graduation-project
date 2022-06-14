using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace OnMuhasebe.CariModulu.Classlar
{
    class clsCariTanitimKarti
    {
        OnMuhasebe.Classlar.Veritabani Dbase = new OnMuhasebe.Classlar.Veritabani();
        public DataTable Listele(string CariKodu,string CariAdi,string Ilce,string Tc,string Tipi) 
        {
            string sql = "SELECT * FROM TBLCARILER WHERE CARIKODU LIKE '%" + CariKodu + "%' AND CARIISIM LIKE '%" + CariAdi + "%' AND ILCE LIKE '%" + Ilce + "%' AND TC LIKE '%" + Tc + "%' AND TIPI LIKE'%" + Tipi + "%'";
            DataTable tablo = Dbase.TabloCek(sql);
            return tablo;
        }
        public void Ekle(string CariKodu, string CariIsim, string Adres, string Il, string Ilce, string Ulke, string Telefon, string Fax, string EMail, string Web, string Tc, string PostaKodu, string VergiDairesi, string VergiNumarasi, string Tipi, string UserId)
        {
            string sql = "EXECUTE SP_CARI_EKLE    '"+CariKodu+"' ,'"+CariIsim+"'  ,'"+Adres+"'  ,'"+Il+"'  ,'"+Ilce+"'  ,'"+Ulke+"'  ,'"+Telefon+"'  ,'"+Fax+"'  ,'"+EMail+"'  ,'"+Web+"'  ,'"+Tc+"'  ,'"+PostaKodu+"'  ,'"+VergiDairesi+"'  ,'" + VergiNumarasi + "','" + Tipi+"'  ,'"+UserId+"'  ";
            Dbase.Isle(sql);
        
        }
        public void Guncelle(string Id,string CariKodu, string CariIsim, string Adres, string Il, string Ilce, string Ulke, string Telefon, string Fax, string VergiDairesi, string VergiNumarasi, string Tc, string PostaKodu, string EMail, string Web, string Tipi, string UserId)
        {
            string sql = "EXECUTE SP_CARI_GUNCELLE " + Id + ",'" + CariKodu +  "','" + CariIsim + "','" + Adres + "','"+ Il + "','" + Ilce + "','" + Ulke + "','" + Telefon + "','" + Fax + "','" + EMail + "','" + Web + "','" + Tc + "','" + PostaKodu + "','" + VergiDairesi + "','" + VergiNumarasi + "','" + Tipi + "'," + UserId;
            Dbase.Isle(sql);

        }
        public void Sil(string Id)
        {
            string sql = "EXECUTE SP_CARI_SIL " + Id;
            Dbase.Isle(sql); 

        }
        public DataRow Ac(string Id)
        {
            string sql = "SELECT TOP 1 * FROM TBLCARILER WHERE ID=" + Id;
            return Dbase.Satir(sql);
        }
        
        public string CariIdAl(string CariKodu)
        {
            string sql = "SELECT TOP 1 * FROM TBLCARILER WHERE CARIKODU='" + CariKodu +"'";
            return Dbase.Satir(sql)["ID"].ToString();
        }
    }
}
