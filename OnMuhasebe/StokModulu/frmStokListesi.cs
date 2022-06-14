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
    public partial class frmStokListesi : DevExpress.XtraEditors.XtraForm
    {
        Classlar.clsStokTanitimKarti Stoklar = new Classlar.clsStokTanitimKarti();
        OnMuhasebe.Classlar.Ekranlar Ekranlar = new OnMuhasebe.Classlar.Ekranlar();
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();
        Classlar.clsStokTanitimKarti Stok = new Classlar.clsStokTanitimKarti();

        string SecilenId = "-1";
        public bool SecimIcinAc = false;

        public frmStokListesi()
        {
            InitializeComponent();
        }

        private void splitterControl1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void frmStokListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            Liste.DataSource = Stoklar.Listele(txtStokKodu.Text, txtStokAdi.Text, txtKod1.Text, txtKod2.Text, txtKod3.Text, txtKod4.Text, txtKod5.Text);
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
       
        private void btnArama_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtStokAdi.Text = "";
            txtStokKodu.Text = "";
            txtKod1.Text = "";
            txtKod2.Text = "";
            txtKod3.Text = "";
            txtKod4.Text = "";
            txtKod5.Text = "";
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (SecimIcinAc==true)
            {
                Sec();
                frmAnaSayfa.AraDegiskenString = SecilenId;
                this.Dispose();
            }
            else
            {

            }
            
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {

        }

        private void SagEkle_Click(object sender, EventArgs e)
        {
            Ekranlar.StokTanitimKartiAc();
        }

        private void SagGuncelle_Click(object sender, EventArgs e)
        {
            Sec();
            Ekranlar.StokTanitimKartiAc(true, SecilenId);

        }

        private void SagSil_Click(object sender, EventArgs e)
        {
            if (Mesajlar.Sor("Seçilen kaydı silmek istediğinizden emin misiniz ?") == true)
            {
                Sec();
               if(Stok.Sil(SecilenId)==true)
                {
                    gridView1.DeleteRow(gridView1.FocusedRowHandle);
                }
               
            }
        }

        private void SagHareketler_Click(object sender, EventArgs e)
        {
            Sec();
            Ekranlar.StokHareketKayitleri(true, SecilenId);
        }
    }
}