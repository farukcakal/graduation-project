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
    public partial class frmStokKod4 : DevExpress.XtraEditors.XtraForm
    {
        Classlar.clsStokKod4 Kod4 = new Classlar.clsStokKod4();
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();
        string SecilenId = "-1";
        Boolean Edit = false;
        public Boolean SecimIcinAcildiMi = false;
        public frmStokKod4()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Temizle();
            txtKod.Focus();
            Edit = false;
        }

        private void frmStokKod4_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            Liste.DataSource = Kod4.Listele();
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
                Kod4.Guncelle(SecilenId ,txtKod.Text, txtAciklama.Text,"-1");
            }
            else
            {
                Kod4.Ekle(txtKod.Text, txtAciklama.Text, "-1");
            }
            Listele();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(Mesajlar.Sor("Seçilen kaydı silmek istediğinizden emin misiniz ?") == true)
            {
                Sec();
                Kod4.Sil(SecilenId);
                Listele();
                Temizle();
            }
            
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (SecimIcinAcildiMi == true)
            {
                Sec();
                frmAnaSayfa.AraDegiskenString = SecilenId;
                this.Dispose();
            }
            else
            {
                Sec();
                DataRow Satir = Kod4.Ac(SecilenId);
                txtAciklama.Text = Satir["ACIKLAMA"].ToString();
                txtKod.Text = Satir["KOD"].ToString();
                Edit = true;
            }

        }
    }
}