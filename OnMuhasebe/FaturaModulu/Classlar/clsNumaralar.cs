using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnMuhasebe.FaturaModulu.Classlar
{
    class clsNumaralar
    {
        OnMuhasebe.Classlar.Veritabani Dbase = new OnMuhasebe.Classlar.Veritabani();
        Classlar.clsFaturaParamtreleri Parametreler = new clsFaturaParamtreleri();

        //public string GetYeniSatisFaturasiNumarasi()
        //{
        //    string Numara = SatisFaturasiNumarasi();
        //    int Yeni;

        //    Numara = Numara.Substring(Parametreler.GetSatisFaturasiBasKar().Length, Numara.Length - Parametreler.GetSatisFaturasiBasKar().Length);
        //    Yeni = Convert.ToInt32(Numara);
             
        //    string Sifirlar = "";

        //    int uz = Parametreler.GetSatisFaturasiUzun();
        //    int bas_uzunluk = Parametreler.GetSatisFaturasiBasKar().Length;
        //    int yeni_uzunluk = Yeni.ToString().Length;

        //    int sayac = uz - bas_uzunluk - yeni_uzunluk;

        //    for (int i = 0; i < sayac; i++)
        //    {
        //        Sifirlar += "0";
        //    }

        //    Numara = Parametreler.SatisFaturasiBasKar + Sifirlar + (Yeni + 1);

        //    return Numara;
        //}

        string SatisFaturasiNumarasi()
        {
            string sql = "SELECT dbo.FN_FATURANUMARASI('S') AS NUMARA";
            string Numara = Dbase.Satir(sql)["NUMARA"].ToString();
            return Numara;
        }
        string SatisIadeNumarasi()
        {
            string sql = "SELECT dbo.FN_FATURANUMARASI('SI') AS NUMARA";
            string Numara = Dbase.Satir(sql)["NUMARA"].ToString();
            return Numara;
        }
        string AlisNumarasi()
        {
            string sql = "SELECT dbo.FN_FATURANUMARASI('A') AS NUMARA";
            string Numara = Dbase.Satir(sql)["NUMARA"].ToString();
            return Numara;
        }
        string AlisIadeNumarasi()
        {
            string sql = "SELECT dbo.FN_FATURANUMARASI('AI') AS NUMARA";
            string Numara = Dbase.Satir(sql)["NUMARA"].ToString();
            return Numara;
        }
    }
}
