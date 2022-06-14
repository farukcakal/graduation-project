using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnMuhasebe.CariModulu
{
    public partial class frmCariListesi : DevExpress.XtraEditors.XtraForm
    {
        Classlar.clsCariTanitimKarti Cari = new Classlar.clsCariTanitimKarti();
        string SecilenId = "-1";

        public frmCariListesi()
        {
            InitializeComponent();
        }

        private void frmCariListesi_Load(object sender, EventArgs e)
        {
            Listele();

        }
        void Listele()
        {
            Liste.DataSource = Cari.Listele(txtCariKodu.Text,txtCariAdi.Text,txtIlce.Text,txtTc.Text,txtTipi.Text); 
        }
        void Sec()
        {
            try
            {
                SecilenId = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            }
            catch (Exception)
            {

                SecilenId = "-1";
            }
            


        }
        void Temizle()
        {

            txtTipi.Text = "";
            txtTc.Text = "";
            txtIl.Text = "";
            txtIlce.Text = "";
            txtCariKodu.Text = "";
            txtCariAdi.Text = "";

        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            frmAnaSayfa.AraDegiskenString = SecilenId;
            this.Dispose();

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();

        }
    }
}