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
    }
}
