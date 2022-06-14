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

namespace OnMuhasebe.KullaniciModulu
{
    public partial class frmKullanici : DevExpress.XtraEditors.XtraForm
    {
        clsKullanici Kullanici = new clsKullanici();
        Classlar.Mesajlar Mesajlar = new Classlar.Mesajlar();
        public Boolean Edit = false;
        string AcilanKullaniciId = "-1";
        public frmKullanici()
        {
            InitializeComponent();
        }
        /*void Kaydet()
        {
            if(Mesajlar.Sor("Kullanıcıyı kaydetmek istediğinizden emin misiniz ?") == true)
            {
                if(Kullanici.Ekle(txtAdi.Text, txtSoyadi.Text, txtUnvan.Text, txtMail.Text, txtTelefon.Text, txtKullaniciAdi.Text, txtParola.Text, txtAciklama.Text, frmAnaSayfa.UserId)==true)
                {
                    Temizle();
                }
                else
                {

                }
            }
        }
        void Guncelle()
        {
            if(Mesajlar.Sor("Kullanıcıyı güncellemek istediğinizden emin misiniz ?") == true)
            {
                if(Kullanici.Guncelle(AcilanKullaniciId, txtAdi.Text, txtSoyadi.Text, txtUnvan.Text, txtMail.Text, txtTelefon.Text, txtKullaniciAdi.Text, txtParola.Text, txtAciklama.Text, frmAnaSayfa.UserId))
                {
                    Temizle();
                }
                else
                {

                }
            }
            
        }
        void Sil()
        {
            if(Mesajlar.Sor("Kullanıcıyı silmek istediğinizden emin misiniz ?") == true)
            {
                if(Kullanici.Sil(AcilanKullaniciId)==true)
                {
                    Temizle();
                }
            }
        }
        void Temizle()
        {
            txtAdi.Text = "";
            txtSoyadi.Text = "";
            txtAciklama.Text = "";
            txtKullaniciAdi.Text = "";
            txtMail.Text = "";
            txtParola.Text = "";
            txtTelefon.Text = "";
            txtUnvan.Text = "";
        }*/

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            /*if(Edit == true)
            {
                Guncelle();
            }
            else
            {
                Kaydet();
            }*/
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            /*if(Edit == true)
            {
                Sil();
            }*/
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            /*if(txtAdi.Text != "")
            {
                if(Mesajlar.Sor("Geçerli işlemi iptal etmek istediğinizden emin misiniz ?") == true)
                {
                    Edit = false;
                    Temizle();
                }
            }*/

        }
    }
}