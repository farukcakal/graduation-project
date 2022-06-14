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

namespace OnMuhasebe
{
    public partial class frmServerAyar : DevExpress.XtraEditors.XtraForm
    {
        public frmServerAyar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnMuhasebe.Properties.Settings.Default.ServerIpAdresi = txtServer.Text;
            OnMuhasebe.Properties.Settings.Default.Veritabani = txtDB.Text;
            OnMuhasebe.Properties.Settings.Default.VeritabaniKullanici = txtUsername.Text;
            OnMuhasebe.Properties.Settings.Default.VeritabaniSifre = txtPassword.Text;
            OnMuhasebe.Properties.Settings.Default.Save();
            this.Close();
        }

        private void frmServerAyar_Load(object sender, EventArgs e)
        {
            txtServer.Text = OnMuhasebe.Properties.Settings.Default.ServerIpAdresi;
            txtDB.Text = OnMuhasebe.Properties.Settings.Default.Veritabani;
            txtUsername.Text = OnMuhasebe.Properties.Settings.Default.VeritabaniKullanici;
            txtPassword.Text = OnMuhasebe.Properties.Settings.Default.VeritabaniSifre;
        }
    }
}