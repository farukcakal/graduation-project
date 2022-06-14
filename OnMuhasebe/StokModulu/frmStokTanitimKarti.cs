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
    public partial class frmStokTanitimKarti : DevExpress.XtraEditors.XtraForm
    {
        string UrunId;
        Boolean Edit = false;
        Classlar.clsStokTanitimKarti Stok = new Classlar.clsStokTanitimKarti();
        Classlar.clsStokKod1 StokKod1 = new Classlar.clsStokKod1();
        Classlar.clsStokKod2 StokKod2 = new Classlar.clsStokKod2();
        Classlar.clsStokKod3 StokKod3 = new Classlar.clsStokKod3();
        Classlar.clsStokKod4 StokKod4 = new Classlar.clsStokKod4();
        Classlar.clsStokKod5 StokKod5 = new Classlar.clsStokKod5();
        OnMuhasebe.Classlar.Ekranlar Ekranlar = new OnMuhasebe.Classlar.Ekranlar();
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();
        public frmStokTanitimKarti()
        {
            InitializeComponent();
        }

        private void btnKod1Sec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            btnKod1Sec.Text = StokKod1.KoduAl(Ekranlar.StokKod1Ac(true));
        }

        private void btnKod2Sec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            btnKod2Sec.Text = StokKod2.KoduAl(Ekranlar.StokKod2Ac(true));
        }

        private void btnKod3Sec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            btnKod3Sec.Text = StokKod3.KoduAl(Ekranlar.StokKod3Ac(true));
        }

        private void btnKod4Sec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            btnKod4Sec.Text = StokKod4.KoduAl(Ekranlar.StokKod4Ac(true));
        }

        private void btnKod5Sec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            btnKod5Sec.Text = StokKod5.KoduAl(Ekranlar.StokKod5Ac(true));
        }

        private void frmStokTanitimKarti_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(Edit == true)
            {
                Stok.Guncelle(UrunId, txtStokKodu.Text, txtStokAdi.Text, txtStokAdiIng.Text, StokKod1.IdAl(btnKod1Sec.Text), StokKod2.IdAl(btnKod2Sec.Text), StokKod3.IdAl(btnKod3Sec.Text), StokKod4.IdAl(btnKod4Sec.Text), StokKod5.IdAl(btnKod5Sec.Text), txtBirim.Text, txtBarkod.Text, txtAlisKdv.Text, txtSatisKdv.Text, txtAlisFiyati1.Text, txtAlisFiyati2.Text, txtSatisFiyati1.Text, txtSatisFiyati2.Text, frmAnaSayfa.UserId);
                Temizle();
            }
            else
            {
                Stok.Ekle(txtStokKodu.Text, txtStokAdi.Text, txtStokAdiIng.Text, StokKod1.IdAl(btnKod1Sec.Text), StokKod2.IdAl(btnKod2Sec.Text), StokKod3.IdAl(btnKod3Sec.Text), StokKod4.IdAl(btnKod4Sec.Text), StokKod5.IdAl(btnKod5Sec.Text), txtBirim.Text, txtBarkod.Text, txtAlisKdv.Text, txtSatisKdv.Text, txtAlisFiyati1.Text, txtAlisFiyati2.Text, txtSatisFiyati1.Text, txtSatisFiyati2.Text, frmAnaSayfa.UserId);
                Temizle();
            }
        }
        void Temizle()
        {
            txtStokAdi.Text = "";
            txtStokAdiIng.Text = "";
            txtStokKodu.Text = "";
            txtSatisKdv.Text = "";
            txtAlisKdv.Text = "";
            txtAlisFiyati1.Text = "";
            txtBarkod.Text = "";
            txtBirim.SelectedIndex = -1;
            txtAlisFiyati2.Text = "";
            txtSatisFiyati1.Text = "";
            txtSatisFiyati2.Text = "";
            btnKod1Sec.Text = "";
            btnKod2Sec.Text = "";
            btnKod3Sec.Text = "";
            btnKod4Sec.Text = "";
            btnKod5Sec.Text = "";
        }

        private void btnStokSec_Click(object sender, EventArgs e)
        {
            UrunId = Ekranlar.StokListesiAc(true);
            if(UrunId != "")
            {
                Ac(UrunId);
            }
        }
        public void Ac(string Id)
        {
            UrunId = Id;
            DataRow Satir = Stok.Ac(UrunId);
            txtStokKodu.Text = Satir["STOKKODU"].ToString();
            txtStokAdi.Text = Satir["STOKADI"].ToString();
            txtStokAdiIng.Text = Satir["INGILIZCEISIM"].ToString();
            txtAlisFiyati1.Text = Satir["ALISFIYAT1"].ToString();
            txtAlisFiyati2.Text = Satir["ALISFIYAT2"].ToString();
            txtAlisKdv.Text = Satir["ALISKDV"].ToString();
            txtSatisKdv.Text = Satir["SATISKDV"].ToString();
            txtSatisFiyati1.Text = Satir["SATISFIYAT1"].ToString();
            txtSatisFiyati2.Text = Satir["SATISFIYAT2"].ToString();
            btnKod1Sec.Text = Satir["KOD1"].ToString();
            btnKod2Sec.Text = Satir["KOD2"].ToString();
            btnKod3Sec.Text = Satir["KOD3"].ToString();
            btnKod4Sec.Text = Satir["KOD4"].ToString();
            btnKod5Sec.Text = Satir["KOD5"].ToString();
            txtBarkod.Text = Satir["BARKOD"].ToString();
            txtBirim.Text = Satir["BIRIM"].ToString();
            Edit = true;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(Mesajlar.Sor("Seçilen kaydı silmek istediğinizden emin misiniz ?") == true)
            {
                Stok.Sil(UrunId);
                Temizle();
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Edit = false;
            Temizle();
        }
    }
}