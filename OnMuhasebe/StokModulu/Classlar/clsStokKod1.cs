using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace OnMuhasebe.StokModulu.Classlar
{
    class clsStokKod1
    {
        OnMuhasebe.Classlar.Veritabani DBase = new OnMuhasebe.Classlar.Veritabani();
        public DataTable Listele()
        {
            string sql = "SELECT * FROM TBLSTOKKOD1 ORDER BY KOD";
            DataTable tablo = DBase.TabloCek(sql);
            return tablo;
        }
        public void Ekle(string Kod, string Aciklama, string UserId)
        {
            string sql = "EXECUTE SP_STOKKOD1_EKLE '" + Kod + "','" + Aciklama + "'," + UserId;
            DBase.Isle(sql);
        }
        public void Sil(string Id)
        {
            string sql = "EXECUTE SP_STOKKOD1_SIL " + Id;
            DBase.Isle(sql);
        }
        public void Guncelle(string Id, string Kod, string Aciklama, string UserId)
        {
            string sql = "EXECUTE SP_STOKKOD1_GUNCELLE '"+ Id + "','" + Kod + "','" + Aciklama + "'," + UserId;
            DBase.Isle(sql);
        }
        public DataRow Ac (string Id)
        {
            return DBase.Satir("SELECT * FROM TBLSTOKKOD1 WHERE ID = " + Id);
        }
        public String KoduAl(string Id)
        {
            return Ac(Id)["KOD"].ToString();
        }
        public String IdAl(string Kod,Boolean YoksaAcilsinMi=false,string UserId="-1")
        {
            try
            {
                return DBase.SatirCek("SELECT * FROM TBLSTOKKOD1 WHERE KOD ='" + Kod + "'")["ID"].ToString();
            }
            catch (Exception)
            {
                if (YoksaAcilsinMi==true)
                {
                    Ekle(Kod, Kod, UserId);
                    return IdAl(Kod, false, UserId);

                }
                else
                {
                    return "-1";
                }
            }
        }
    }
}
