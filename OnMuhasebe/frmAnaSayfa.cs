using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OnMuhasebe
{
    public partial class frmAnaSayfa : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        /*Temel Erişim Değişkenleri*/
        public static string AraDegiskenString;
        public static string UserId = "-1";
        /*Temel Erişim Değişkenleri*/

        OnMuhasebe.Classlar.Ekranlar Ekranlar = new Classlar.Ekranlar();
        Classlar.Mesajlar Mesajlar = new Classlar.Mesajlar();
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Ekranlar.StokTanitimKartiAc();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
            frmMasaustu frm = new frmMasaustu();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Ekranlar.CariTanitimKartiAc();
            
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Ekranlar.SatisFaturasiAc();
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void barCariAcilisKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            


        }

        private void barStokAcilisKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            

        }

        private void barStokListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Ekranlar.StokListesiAc(false);
        }

        private void barTopluStokAcma_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            

        }

        private void barTopluStokGuncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            

        }

        private void barStokHareket_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Ekranlar.StokHareketKayitleri();
        }

        private void barTopluStok_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Ekranlar.TopluStokAcma();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Ekranlar.TopluStokGuncelle();
        }

        private void barStokAcilis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Ekranlar.StokAcillisKarti();
        }

        private void barButtonItem7_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Ekranlar.CariHareketKayitlari(false);
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Ekranlar.CariAcilisKarti();
        }

        private void barAyarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Ekranlar.ServerAyarlari();
        }

        private void barHakkinda_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Ekranlar.Hakkimizda();
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Ekranlar.CariListesiAc();
        }
    }
}
