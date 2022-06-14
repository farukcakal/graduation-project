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

namespace OnMuhasebe.StokModulu
{
    public partial class frmStokKod1 : DevExpress.XtraEditors.XtraForm
    {
        Classlar.clsStokKod1 Kod1 = new Classlar.clsStokKod1();
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();
        string SecilenId = "-1";
        Boolean Edit = false;
        public Boolean SecimIcinAcildiMi = false;
        public frmStokKod1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Temizle();
            txtKod.Focus();
            Edit = false;
        }

        private void frmStokKod1_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            Liste.DataSource = Kod1.Listele();
        }
        void Temizle()
        {
            txtAciklama.Text = "";
            txtKod.Text = "";
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
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(Edit == true)
            {
                Kod1.Guncelle(SecilenId ,txtKod.Text, txtAciklama.Text,"-1");
            }
            else
            {
                Kod1.Ekle(txtKod.Text, txtAciklama.Text, "-1");
            }
            Listele();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(Mesajlar.Sor("Seçilen kaydı silmek istediğinizden emin misiniz ?") == true)
            {
                Sec();
                Kod1.Sil(SecilenId);
                Listele();
                Temizle();
            }
            
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if(SecimIcinAcildiMi == true)
            {
                Sec();
                frmAnaSayfa.AraDegiskenString = SecilenId;
                this.Dispose();
            }
            else
            {
                Sec();
                DataRow Satir = Kod1.Ac(SecilenId);
                txtAciklama.Text = Satir["ACIKLAMA"].ToString();
                txtKod.Text = Satir["KOD"].ToString();
                Edit = true;
            }
        }
    }
}