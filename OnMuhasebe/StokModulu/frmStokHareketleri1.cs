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
    public partial class frmStokHareketleri1 : DevExpress.XtraEditors.XtraForm
    {
        Classlar.clsStokHareketleri Hareketler = new Classlar.clsStokHareketleri();
        OnMuhasebe.Classlar.Ekranlar Ekranlar = new OnMuhasebe.Classlar.Ekranlar();
        Classlar.clsStokTanitimKarti Stok = new Classlar.clsStokTanitimKarti();
        string SecilenStokKodu = "";
        string UrunId;
        public frmStokHareketleri1()
        {
            InitializeComponent();
        }

        private void frmStokHareketleri1_Load(object sender, EventArgs e)
        {

        }   
        void Listele()
        {
            Liste.DataSource = Hareketler.Listele(SecilenStokKodu);
        }
        private void btn_StokHareket_Click(object sender, EventArgs e)
        {
            StokSec();
        }
        void StokSec()
        {
            UrunId = Ekranlar.StokListesiAc(true);
            if (UrunId != "")
            {
                Ac(UrunId);
            }
        }
        public void Ac(string Id)
        {
            UrunId = Id;
            DataRow Satir = Stok.Ac(UrunId);
            SecilenStokKodu = Satir["STOKKODU"].ToString();
            txtStokKodu.Text = SecilenStokKodu;
            txtStokIsmi.Text = Satir["STOKADI"].ToString();
            Listele();
            GetStokBakiye(SecilenStokKodu);
        }

        void GetStokBakiye(string StokKodu)
        {
            DataRow Satir = Hareketler.StokBakiye(StokKodu);
            txtToplamCikis.Text = Satir["CIKIS"].ToString();
            txtToplamGiris.Text = Satir["GIRIS"].ToString();
            txtBakiye.Text = Satir["BAKIYE"].ToString();

        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            string Tipi = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TIPI").ToString();
            if (Tipi == "A")
            {
                string AcilisKartiId = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
                Ekranlar.StokAcillisKarti(AcilisKartiId, true);
            }
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBakiye_TextChanged(object sender, EventArgs e)
        {

        }
    }
}