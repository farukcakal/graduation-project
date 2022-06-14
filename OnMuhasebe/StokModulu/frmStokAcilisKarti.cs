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
    public partial class frmStokAcilisKarti : DevExpress.XtraEditors.XtraForm
    {
        Classlar.clsStokHareketleri Hareketler = new Classlar.clsStokHareketleri();
        OnMuhasebe.Classlar.Ekranlar Ekranlar = new OnMuhasebe.Classlar.Ekranlar();
        Classlar.clsStokTanitimKarti Stok = new Classlar.clsStokTanitimKarti();
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();
        Boolean Edit = false;
        string AcılanId = "-1";
        string UrunId;
        string StokGirisKdv, StokCikisKdv;
        public frmStokAcilisKarti()
        {
            InitializeComponent();
        }

        private void lbl_Cari_Ismi_Hareket_Click(object sender, EventArgs e)
        {

        }



        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string GcKodu, Kdv;
            if (radioCikis.Checked == true)
            {
                GcKodu = "C";
                Kdv = StokCikisKdv;
            }
            else
            {
                GcKodu = "G";
                Kdv = StokGirisKdv;
            }
            if (Edit == true)
            {
                if (Hareketler.StokAcilisKartiGuncelle(AcılanId, txtBelgeNo.Text, txtStokKodu.Text, GcKodu, txtMiktar.Text, txtStokFiyat.Text, Kdv, txtTarih.EditValue.ToString())==true)
                {
                    Mesajlar.Bilgi("Açılış Kartı Başarılı Bir Şekilde Güncellenmiştir.");
                    this.Close();
                }
                else
                {
                    Mesajlar.Hata();
                }
            }
            else
            {
                if (Hareketler.StokAcilisKarti(txtBelgeNo.Text, txtStokKodu.Text, GcKodu, txtMiktar.Text, txtStokFiyat.Text, Kdv, txtTarih.EditValue.ToString())==true)
                {
                    Mesajlar.Bilgi("Açılış Kartı Başarılı Bir Şekilde Kaydedilmiştir.");
                }
                else
                {
                    Mesajlar.Hata();
                }

            }

        }

        private void frmStokAcilisKarti_Load(object sender, EventArgs e)
        {

        }
        public void Ac(string Id)
        {
            AcılanId = Id;
            DataRow Satir = Hareketler.StokAcilisKartiAc(Id);
            txtBelgeNo.Text = Satir["FATURANO"].ToString();
            txtStokFiyat.Text =Convert.ToDecimal(Satir["BRIMFIYAT"].ToString()).ToString("0.00");
            txtMiktar.Text = Satir["MIKTAR"].ToString();
            txtStokIsmi.Text = Satir["STOKADI"].ToString();
            txtStokKodu.Text = Satir["STOKKODU"].ToString();
            txtTarih.Text =Convert.ToDateTime(Satir["TARIH"].ToString()).ToShortDateString();
            StokGirisKdv = Satir["KDV"].ToString();
            StokCikisKdv = Satir["KDV"].ToString();
            string GcKodu = Satir["GCKOD"].ToString();
            if (GcKodu=="G")
            {
                radioGiris.Checked = true;

            }
            else
            {
                radioCikis.Checked = true;
            }
            Edit = true;

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (txtBelgeNo.Text != "")
            {
                if (Mesajlar.Sor("İşlemi İptal Etmek İstediğinize Emin misiniz?") == true)
                {
                    this.Close();
                }
            }
           
            
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            if (txtBelgeNo.Text!="")
            {
                if (Mesajlar.Sor("Yeni Açılış Kartı Açmak İstediğinize Emin misiniz?")==true)
                {
                    Yeni();
                }
            }
        }
        void Yeni()
        {
            txtBelgeNo.Text = "";
            txtStokFiyat.Text = "";
            txtMiktar.Text = "";
            txtStokIsmi.Text = "";
            txtStokKodu.Text = "";
            txtTarih.Text = DateTime.Now.ToShortDateString();
            Edit = false;
            txtBelgeNo.Focus();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Mesajlar.Sor("Stok Açılış Kartını Silmek İstediginizden Emin misiniz?") == true)
            {
                if (Hareketler.StokAcilisKartiSil(AcılanId) == true)
                {
                    Mesajlar.Bilgi("Stok Açılış Kartı Başarılı Bir Şekilde Silinmiştir");
                    this.Close();
                }
            }
            else
            {
                Mesajlar.Hata();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            UrunId = Ekranlar.StokListesiAc(true);
            if (UrunId != "")
            {
                DataRow Satir = Stok.Ac(UrunId);
                txtStokKodu.Text = Satir["STOKKODU"].ToString();
                txtStokIsmi.Text = Satir["STOKADI"].ToString();
                StokGirisKdv = Satir["ALISKDV"].ToString();
                StokCikisKdv = Satir["SATISKDV"].ToString();
            }
        }
    }
}