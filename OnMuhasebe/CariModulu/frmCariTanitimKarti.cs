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
using System.Data.SqlClient;

namespace OnMuhasebe.CariModulu
{
    public partial class frmCariTanitimKarti : DevExpress.XtraEditors.XtraForm
    {
        Classlar.clsCariTanitimKarti Cari = new Classlar.clsCariTanitimKarti();
        OnMuhasebe.Classlar.Ekranlar ekranlar = new OnMuhasebe.Classlar.Ekranlar();
        OnMuhasebe.Classlar.Mesajlar mesajlar = new OnMuhasebe.Classlar.Mesajlar();
        string CariId;
        Boolean Edit = false;


        public frmCariTanitimKarti()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void frmCariTanitimKarti_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string Tipi = "Alici";

            if (radioAlici.Checked==true)
            {
                Tipi = "ALICI";
            }
            else if (radioSatici.Checked==true)
            {
                Tipi = "SATICI";

            }
            else
            {
                Tipi = "DİĞER";

            }
            if (Edit==true)
            {
                Cari.Guncelle(CariId, txtCariKodu.Text, txtCariIsim.Text, txtAdres.Text, txtIl.Text, txtIlce.Text, txtUlke.Text, txtTelefon.Text, txtFax.Text, txtVD.Text, txtVKN.Text, txtTCKN.Text, txtPostaKodu.Text, txtEmail.Text, txtWeb.Text, Tipi, frmAnaSayfa.UserId);
                Temizle();

            }
            else
            {
                Cari.Ekle(txtCariKodu.Text, txtCariIsim.Text, txtAdres.Text, txtIl.Text, txtIlce.Text, txtUlke.Text, txtTelefon.Text, txtFax.Text, txtEmail.Text, txtWeb.Text, txtTCKN.Text, txtPostaKodu.Text, txtVD.Text, txtVKN.Text, Tipi, frmAnaSayfa.UserId);
                Temizle();

            }
            Edit = false;
            Temizle();


          
        }
       void Temizle()
        {
            txtAdres.Text = "";
            txtCariIsim.Text = "";
            txtCariKodu.Text = "";
            txtEmail.Text = "";
            txtFax.Text = "";
            txtIl.Text = "";
            txtIlce.Text = "";
            txtPostaKodu.Text = "";
            txtTCKN.Text = "";
            txtTelefon.Text = "";
            txtUlke.Text = "";
            txtVD.Text = "";
            txtVKN.Text = "";
            txtWeb.Text = "";
        }
        private void btnSec_Click(object sender, EventArgs e)
        {
            CariId = txtCariKodu.Text = ekranlar.CariListesiAc();
            DataRow Satir = Cari.Ac(CariId);
            txtAdres.Text = Satir["Adres"].ToString();
            txtCariIsim.Text= Satir["CARIISIM"].ToString();
            txtCariKodu.Text=Satir["CARIKODU"].ToString();
            txtEmail.Text = Satir["EMAIL"].ToString();
            txtFax.Text = Satir["FAX"].ToString();
            txtIl.Text = Satir["IL"].ToString();
            txtIlce.Text = Satir["ILCE"].ToString();
            txtPostaKodu.Text = Satir["POSTAKODU"].ToString();
            txtTCKN.Text = Satir["TC"].ToString();
            txtTelefon.Text = Satir["TELEFON"].ToString();
            txtUlke.Text = Satir["ULKE"].ToString();
            txtVD.Text = Satir["VERGIDAIRESI"].ToString();
            txtVKN.Text = Satir["VERGINUMARASI"].ToString();
            txtWeb.Text = Satir["WEB"].ToString();

            string Tipi = Satir["TIPI"].ToString();

            if (Tipi=="ALICI")
            {
                radioAlici.Checked = true;
            }
            else if (Tipi=="SATICI")
            {
                radioSatici.Checked = true;

            }
            else
            {
                radioDiger.Checked = true;
            }


            Edit = true;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (mesajlar.Sor("Seçilen Kaydı Silmek İstediğinizden Emin Misiniz ? ") == true)
            {
                Cari.Sil(CariId);
                Temizle();
            }
            
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}