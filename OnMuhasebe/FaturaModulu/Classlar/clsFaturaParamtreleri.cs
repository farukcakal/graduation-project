using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace OnMuhasebe.FaturaModulu.Classlar
{
    class clsFaturaParamtreleri
    {
        OnMuhasebe.Classlar.Veritabani Dbase = new OnMuhasebe.Classlar.Veritabani();
        public string SatisFaturasiBasKar, SatisFaturasiUzun;
        public string SatisIadeFaturasiBasKar, SatisIadeFaturasiUzun;
        public string AlisFaturasiBasKar, AlisFaturasiUzun;
        public string AlisIadeFaturasiBasKar, AlisIadeFaturasiUzun;

        public clsFaturaParamtreleri()
        {
            string sql = "SELECT * FROM TBLFATPARAMETRE ORDER BY ID DESC";
            DataRow Par = Dbase.Satir(sql);
            SatisFaturasiBasKar = Par["SF_BAS_KAR"].ToString();
            SatisFaturasiUzun = Par["SF_UZN"].ToString();
            SatisIadeFaturasiBasKar = Par["SI_BAS_KAR"].ToString();
            SatisIadeFaturasiUzun = Par["SI_UZN"].ToString();
            AlisFaturasiBasKar = Par["AF_BAS_KAR"].ToString();
            AlisFaturasiUzun = Par["AF_UZN"].ToString();
            AlisIadeFaturasiBasKar = Par["AI_BAS_KAR"].ToString();
            AlisIadeFaturasiUzun = Par["AI_UZN"].ToString();
        }
        public string GetSatisFaturasiBasKar()
        {
            return SatisFaturasiBasKar;
        }
        public int GetSatisFaturasiUzun()
        {
            return Convert.ToInt32(SatisFaturasiUzun);
        }
        public string GetSatisIadeFaturasiBasKar()
        {
            return SatisIadeFaturasiBasKar;
        }
        public int GetSatisIadeFaturasiUzun()
        {
            return Convert.ToInt32(SatisIadeFaturasiUzun);
        }

        public string GetAlisFaturasiBasKar()
        {
            return AlisFaturasiBasKar;
        }
        public int GetAlisFaturasiUzun()
        {
            return Convert.ToInt32(AlisFaturasiUzun);
        }
        public string GetAlisIadeFaturasiBasKar()
        {
            return AlisIadeFaturasiBasKar;
        }
        public int GetAlisIadeFaturasiUzun()
        {
            return Convert.ToInt32(AlisIadeFaturasiUzun);
        }

    }
}
