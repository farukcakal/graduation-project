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
    public partial class frmCariHareketler : DevExpress.XtraEditors.XtraForm
    {
        string SecilenId="-1";
        string SecilenTip = "";
        OnMuhasebe.Classlar.Ekranlar ekranlar = new OnMuhasebe.Classlar.Ekranlar();
        Classlar.clsCariTanitimKarti Cari = new Classlar.clsCariTanitimKarti();
        Classlar.clsCariHareketleri Hareketler = new Classlar.clsCariHareketleri();
        public string CariId, SecilenCariKodu;
        public frmCariHareketler()
        {
            InitializeComponent();
        }

        private void btn_Carihareket_Click(object sender, EventArgs e)
        {
            CariSec();
        }
        void CariSec()
        {
            CariId = ekranlar.CariListesiAc();
            DataRow Satir = Cari.Ac(CariId);
            SecilenCariKodu= Satir["CARIKODU"].ToString();
            txtCariIsim.Text = Satir["CARIISIM"].ToString();
            txtCariKodu.Text = SecilenCariKodu;
            GetCariHareketleri();
        }
        void GetCariHareketleri()
        {
            Liste.DataSource = Hareketler.Listele(SecilenCariKodu);
            GetCariBakiye(SecilenCariKodu);
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (SecilenTip=="A")
            {
                ekranlar.CariAcilisKarti(true, SecilenId);
            }
            else
            {
                MessageBox.Show("Cari Değildir!");
            }
        }


        private void CariHareketKayıtları_Load(object sender, EventArgs e)
        {

        }
        void GetCariBakiye(string CariKodu)
        {
            DataRow Satir = Hareketler.CariBakiye(CariKodu);
            txtToplamAlacak.Text = Satir["ALACAK"].ToString();
            txtToplamBorc.Text = Satir["BORC"].ToString();
            txtBakiye.Text = Satir["BAKIYE"].ToString();

            decimal CariBakiye = Convert.ToDecimal(txtBakiye.Text);
            if (CariBakiye>0)
            {
                txtBakiye.BackColor = Color.MediumSeaGreen;
            }
            else
            {
                txtBakiye.BackColor = Color.LightCoral;

            }

        }

        private void btnTarihListele_Click(object sender, EventArgs e)
        {
        }
            
        void Sec()
        {
            try
            {
                SecilenId = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
                SecilenTip = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TIPI").ToString();
            }
            catch (Exception)
            {
                SecilenId = "-1";
            }            
        }
        
    }
}