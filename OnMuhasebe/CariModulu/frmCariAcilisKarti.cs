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
    public partial class frmCariAcilisKarti : DevExpress.XtraEditors.XtraForm
    {        
        public Boolean Edit = false;
        public string SecilenId;
        string CariId = "-1";
        string SecilenCariKodu = "";
        string SecilenAcilisKartiId = "-1";
        OnMuhasebe.Classlar.Ekranlar ekranlar = new OnMuhasebe.Classlar.Ekranlar();
        Classlar.clsCariTanitimKarti Cari = new Classlar.clsCariTanitimKarti();
        Classlar.clsCariHareketleri Hareketler = new Classlar.clsCariHareketleri();
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();

        public frmCariAcilisKarti()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            CariSec();
        }
        void CariSec(Boolean Ac=false)
        {
            if (Ac==false)
            {
                CariId = ekranlar.CariListesiAc();
            }
            //CariId = ekranlar.CariListesiAc();
            DataRow Satir = Cari.Ac(CariId);
            SecilenCariKodu = Satir["CARIKODU"].ToString();
            txtCariIsim.Text = Satir["CARIISIM"].ToString();
            txtCariKodu.Text = SecilenCariKodu;
        }

        public void Ac(string id)
        {
            Edit = true;
            SecilenId = id;
            DataRow Satir = Hareketler.CariAcilisKartiAc(SecilenId);
            txtAciklama.Text = Satir["ACIKLAMA"].ToString();
            txtBelgeNo.Text = Satir["BELGENO"].ToString();
            string CariKodu = Satir["CARIKODU"].ToString();
            SecilenAcilisKartiId = Satir["ID"].ToString();
            CariId = Cari.CariIdAl(CariKodu);
            CariSec(true);

            Decimal Borc, Alacak;
            Borc = Convert.ToDecimal(Satir["BORC"].ToString());
            Alacak = Convert.ToDecimal(Satir["ALACAK"].ToString());
            if (Borc>0)
            {
                txtTutar.Text = Borc.ToString();
                radioBorc.Checked = true;
            }
            else
            {
                txtTutar.Text = Alacak.ToString();
                radioAlacak.Checked = true;
            }
            txtTarih.EditValue= Satir["TARIH"].ToString();

        }
        void Kaydet()
        {
            decimal Borc, Alacak;
            if (radioAlacak.Checked == true)
            {
                Alacak = Convert.ToDecimal(txtTutar.Text);
                Borc = 0;
            }
            else
            {
                Borc = Convert.ToDecimal(txtTutar.Text);
                Alacak = 0;
            }
            if (Edit==true)
            {
                Hareketler.CariAcilisKartiGuncelle(SecilenId,txtCariKodu.Text, txtBelgeNo.Text, Borc, Alacak, txtTarih.EditValue.ToString(), txtAciklama.Text);
            }
            else
            {
                Hareketler.CariAcilisKarti(txtCariKodu.Text, txtBelgeNo.Text, Borc, Alacak, txtTarih.EditValue.ToString(), txtAciklama.Text);
            }
            this.Close();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }
        void Temizle()
        {
            txtAciklama.Text = "";
            txtBelgeNo.Text = "";
            txtCariIsim.Text = "";
            txtCariKodu.Text = "";
            txtTarih.EditValue = DateTime.Now.ToShortDateString();
            txtTutar.Text = "0";
            Edit = false;
            txtBelgeNo.Focus();
        }
        private void frmCariAcilisKarti_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Mesajlar.Sor("Açılış Kartını Silmek İstediğinizden Emin misiniz?") == true)
            {
                if (Hareketler.CariAcilisKartiSil(SecilenAcilisKartiId)==true)
                {
                    Temizle();
                }
                else
                {
                    Mesajlar.Hata();
                }
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}