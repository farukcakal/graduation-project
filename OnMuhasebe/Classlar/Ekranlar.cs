using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnMuhasebe.Classlar
{
    class Ekranlar
    {
        /*STOK FORMLARI*/
        public string StokKod1Ac(Boolean Sec)
        {
            StokModulu.frmStokKod1 frm = new StokModulu.frmStokKod1();

            if(Sec == true)
            {
                frm.SecimIcinAcildiMi = true;
                frm.ShowDialog();
                return frmAnaSayfa.AraDegiskenString;
            }
            return "";
        }
        public string StokKod2Ac(Boolean Sec)
        {
            StokModulu.frmStokKod2 frm = new StokModulu.frmStokKod2();

            if (Sec == true)
            {
                frm.SecimIcinAcildiMi = true;
                frm.ShowDialog();
                return frmAnaSayfa.AraDegiskenString;
            }
            return "";
        }
        public string StokKod3Ac(Boolean Sec)
        {
            StokModulu.frmStokKod3 frm = new StokModulu.frmStokKod3();

            if (Sec == true)
            {
                frm.SecimIcinAcildiMi = true;
                frm.ShowDialog();
                return frmAnaSayfa.AraDegiskenString;
            }
            return "";
        }
        public string StokKod4Ac(Boolean Sec)
        {
            StokModulu.frmStokKod4 frm = new StokModulu.frmStokKod4();

            if (Sec == true)
            {
                frm.SecimIcinAcildiMi = true;
                frm.ShowDialog();
                return frmAnaSayfa.AraDegiskenString;
            }
            return "";
        }
        public string StokKod5Ac(Boolean Sec)
        {
            StokModulu.frmStokKod5 frm = new StokModulu.frmStokKod5();

            if (Sec == true)
            {
                frm.SecimIcinAcildiMi = true;
                frm.ShowDialog();
                return frmAnaSayfa.AraDegiskenString;
            }
            return "";
        }
        public void StokTanitimKartiAc(Boolean Edit=false,string UrunId="-1")
        {
            StokModulu.frmStokTanitimKarti frm = new StokModulu.frmStokTanitimKarti();
            if (Edit==true)
            {
                frm.Ac(UrunId);

            }
            frm.ShowDialog();
        }
        public string StokListesiAc(Boolean Sec=false)
        {
          OnMuhasebe.StokModulu.frmStokListesi frm = new StokModulu.frmStokListesi();
            if (Sec==true)
            {
                frm.SecimIcinAc = true;
                frm.ShowDialog();
                return frmAnaSayfa.AraDegiskenString;
            }
            else
            {
                frm.SecimIcinAc = false;
                /*frm.MdiParent = OnMuhasebe.frmAnaSayfa.ActiveForm;
                frm.Show();*/
                frm.ShowDialog();
                return "";

            }
            
          
        }

        public void StokHareketKayitleri(Boolean StokGonder=false,string UrunId="-1")
        {
            OnMuhasebe.StokModulu.frmStokHareketleri1 frm = new StokModulu.frmStokHareketleri1();
            if (StokGonder==true)
            {
                frm.Ac(UrunId);
            }
            frm.MdiParent = OnMuhasebe.frmAnaSayfa.ActiveForm;
            frm.Show();
        }
        public void StokAcillisKarti(string Id="-1",Boolean Ac=false)
        {
            OnMuhasebe.StokModulu.frmStokAcilisKarti frm = new StokModulu.frmStokAcilisKarti();
            if (Ac==true)
            {
                frm.Ac(Id);
            }
            frm.ShowDialog();

        }
        public void TopluStokAcma()
        {
            OnMuhasebe.StokModulu.frmTopluStokAcma frm = new StokModulu.frmTopluStokAcma();
            frm.MdiParent = OnMuhasebe.frmAnaSayfa.ActiveForm;
            frm.Show();

        }
        public void TopluStokGuncelle()
        {
            OnMuhasebe.StokModulu.frmTopluStokGuncelle frm = new StokModulu.frmTopluStokGuncelle();
            frm.MdiParent = OnMuhasebe.frmAnaSayfa.ActiveForm;
            frm.Show();

        }



        public void CariTanitimKartiAc()
        {
            OnMuhasebe.CariModulu.frmCariTanitimKarti frm = new CariModulu.frmCariTanitimKarti();
            frm.ShowDialog();
        }
        public string CariListesiAc()
        {
            OnMuhasebe.CariModulu.frmCariListesi frm = new CariModulu.frmCariListesi();
            frm.ShowDialog();
            return frmAnaSayfa.AraDegiskenString;
        }

        public void CariHareketKayitlari(Boolean Dialog)
        {
            OnMuhasebe.CariModulu.frmCariHareketler frm = new CariModulu.frmCariHareketler();
            if (Dialog==true)
            {
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = OnMuhasebe.frmAnaSayfa.ActiveForm;
                frm.Show();
            }
        }

        public void CariAcilisKarti(Boolean Ac=false,string Id="-1")
        {
            OnMuhasebe.CariModulu.frmCariAcilisKarti frm = new CariModulu.frmCariAcilisKarti();
            if (Ac==true)
            {
                frm.Ac(Id);
            }
            frm.ShowDialog();
        }

        public void SatisFaturasiAc()
        {
            OnMuhasebe.FaturaModulu.frmSatisFaturasi frm = new FaturaModulu.frmSatisFaturasi();
            frm.MdiParent = OnMuhasebe.frmAnaSayfa.ActiveForm;
            frm.Show();
        }
        public string SatisFaturasiListesi()
        {
            FaturaModulu.Satis.frmSatisFaturasiListesi frm = new FaturaModulu.Satis.frmSatisFaturasiListesi();
            frm.ShowDialog();
            return frmAnaSayfa.AraDegiskenString;
        }

        public void ServerAyarlari()
        {
            frmServerAyar frm = new frmServerAyar();
            frm.ShowDialog();
        }

        public void Hakkimizda()
        {
            frmHakkimizda frm = new frmHakkimizda();
            frm.ShowDialog();
        }
    }
}
