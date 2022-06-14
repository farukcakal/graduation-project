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

namespace OnMuhasebe.FaturaModulu.Satis
{
    public partial class frmSatisFaturasiListesi : DevExpress.XtraEditors.XtraForm
    {
        Classlar.clsSatisFaturasi SatisFaturasi = new Classlar.clsSatisFaturasi();
        string SecilenId;
        public frmSatisFaturasiListesi()
        {
            InitializeComponent();
        }
        void Listele()
        {
            Liste.DataSource = SatisFaturasi.Listele(txtCariKodu.Text, txtCariAdi.Text, txtFaturaNo.Text);
            
        }
        private void frmSatisFaturasiListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            Listele();
        }

        void Sec()
        {
            try
            {
                SecilenId = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "FATURANO").ToString();
            }
            catch (Exception)
            {
                SecilenId = "-1";
            }
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            frmAnaSayfa.AraDegiskenString = SecilenId;
            this.Dispose();
        }
    }
}