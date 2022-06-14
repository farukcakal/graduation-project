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
    public partial class frmTopluStokGuncelle : DevExpress.XtraEditors.XtraForm
    {
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();
        public frmTopluStokGuncelle()
        {
            InitializeComponent();
        }

        private void cheStokAdi_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cheIngIsim_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void cheKod1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void cheKod2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void cheKod3_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void cheKod4_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void cheKod5_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void cheBirim_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void cheBarkod_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void cheAlisKdv_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cheSatisKdv_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void cheAlis1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void cheAlis2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void cheSatis1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void cheSatis2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void barAc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void frmTopluStokGuncelle_Load(object sender, EventArgs e)
        {

        }

        private void checkEdit14_CheckedChanged(object sender, EventArgs e)
        {
            if (ceSatisFiyat1.Checked == true)
            {
                cbSatisFiyat2.Enabled = true;

            }
            else
            {
                cbSatisFiyat2.Enabled = false;
            }
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (ceStokAdi.Checked == true)
            {
                cbStokAdi.Enabled = true;

            }
            else
            {
                cbStokAdi.Enabled = false;
            }
        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
            if (ceIngIsim.Checked == true)
            {
                cbIngIsim.Enabled = true;

            }
            else
            {
                cbIngIsim.Enabled = false;
            }
        }

        private void checkEdit3_CheckedChanged(object sender, EventArgs e)
        {

            if (ceKod1.Checked == true)
            {
                cbKod1.Enabled = true;

            }
            else
            {
                cbKod1.Enabled = false;
            }
        }

        private void checkEdit4_CheckedChanged(object sender, EventArgs e)
        {

            if (ceKod2.Checked == true)
            {
                cbKod2.Enabled = true;

            }
            else
            {
                cbKod2.Enabled = false;
            }
        }

        private void checkEdit5_CheckedChanged(object sender, EventArgs e)
        {
            if (ceKod3.Checked == true)
            {
                cbKod3.Enabled = true;

            }
            else
            {
                cbKod3.Enabled = false;
            }
        }

        private void checkEdit6_CheckedChanged(object sender, EventArgs e)
        {
            if (ceKod4.Checked == true)
            {
                cbKod4.Enabled = true;

            }
            else
            {
                cbKod4.Enabled = false;
            }
        }

        private void checkEdit7_CheckedChanged(object sender, EventArgs e)
        {

            if (ceKod5.Checked == true)
            {
                cbKod5.Enabled = true;

            }
            else
            {
                cbKod5.Enabled = false;
            }
        }

        private void checkEdit8_CheckedChanged(object sender, EventArgs e)
        {
            if (ceBirim.Checked == true)
            {
                cbBirim.Enabled = true;

            }
            else
            {
                cbBirim.Enabled = false;
            }
        }

        private void checkEdit9_CheckedChanged(object sender, EventArgs e)
        {
            if (ceBarkod.Checked == true)
            {
                cbBarkod.Enabled = true;

            }
            else
            {
                cbBarkod.Enabled = false;
            }
        }

        private void checkEdit10_CheckedChanged(object sender, EventArgs e)
        {
            if (ceAlisKdv.Checked == true)
            {
                cbAlisKdv.Enabled = true;

            }
            else
            {
                cbAlisKdv.Enabled = false;
            }
        }

        private void checkEdit11_CheckedChanged(object sender, EventArgs e)
        {
            if (ceSatisKdv.Checked == true)
            {
                cbSatisKdv.Enabled = true;

            }
            else
            {
                cbSatisKdv.Enabled = false;
            }
        }

        private void checkEdit12_CheckedChanged(object sender, EventArgs e)
        {
            if (ceAlisFiyat1.Checked == true)
            {
                cbAlisFiyat1.Enabled = true;

            }
            else
            {
                cbAlisFiyat1.Enabled = false;
            }
        }

        private void checkEdit13_CheckedChanged(object sender, EventArgs e)
        {
            if (ceAlisFiyat2.Checked == true)
            {
                cbAlisFiyat2.Enabled = true;

            }
            else
            {
                cbAlisFiyat2.Enabled = false;
            }
        }

        private void checkEdit15_CheckedChanged(object sender, EventArgs e)
        {
            if (ceSatisFiyat2.Checked == true)
            {
                cbSatisFiyat1.Enabled = true;

            }
            else
            {
                cbSatisFiyat1.Enabled = false;
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog Ac = new OpenFileDialog();
            Ac.Filter = "Excel 2003(*xls)|*.xls | Excel 2007(*.xlsx)|*.xlsx";
            if (Ac.ShowDialog() == DialogResult.OK)
            {
                OnMuhasebe.Classlar.ExcelIslemleri Excel = new OnMuhasebe.Classlar.ExcelIslemleri();
                this.Cursor = Cursors.WaitCursor;

                DataTable Veriler = Excel.Veriler(Ac.FileName);
                Liste.DataSource = Veriler;
                this.Cursor = Cursors.Default;

                foreach (Control Nesne in Tasiyicipanel.Panel1.Controls)
                {
                    if (Nesne is DevExpress.XtraEditors.ComboBoxEdit)
                    {
                        SutunAl((DevExpress.XtraEditors.ComboBoxEdit)Nesne);

                    }

                }

            }
        }
        void SutunAl(DevExpress.XtraEditors.ComboBoxEdit Nesne)
        {
            DevExpress.XtraEditors.Controls.ComboBoxItemCollection Sutunlar = Nesne.Properties.Items;
            Sutunlar.Clear();
            Sutunlar.BeginUpdate();

            Sutunlar.Add("");

            for (int i = 0; i < gridView1.Columns.Count; i++)
            {
                Sutunlar.Add(gridView1.Columns[i].FieldName.ToString());

            }
            Nesne.SelectedIndex = 0;
            Sutunlar.EndUpdate();

        }

        private void barIceriAktar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IceriAktar();

        }
        void IceriAktar()
        {

            if (cbStokKodu.SelectedIndex == 0)
            {
                Mesajlar.Uyari("Stok kodu seçmeden güncelleme işlemi yapamazsınız");
                cbStokKodu.Focus();


            }
            else
            {


                Classlar.clsStokKod1 StokKod1 = new Classlar.clsStokKod1();
                Classlar.clsStokKod2 StokKod2 = new Classlar.clsStokKod2();
                Classlar.clsStokKod3 StokKod3 = new Classlar.clsStokKod3();
                Classlar.clsStokKod4 StokKod4 = new Classlar.clsStokKod4();
                Classlar.clsStokKod5 StokKod5 = new Classlar.clsStokKod5();
                OnMuhasebe.Classlar.Formatlar Formatlar = new OnMuhasebe.Classlar.Formatlar();
                OnMuhasebe.Classlar.Veritabani Dbase = new OnMuhasebe.Classlar.Veritabani();


                string StokKodu, StokAdi, IngIsim, Kod1, Kod2, Kod3, Kod4, Kod5, Birim, Barkod, AlisKdv, SatisKdv, AlisFiyat1, AlisFiyat2, SatisFiyat1, SatisFiyat2;

                this.Cursor = Cursors.WaitCursor;


                for (int i = 0; i < gridView1.RowCount - 1; i++)
                {
                    StokKodu = DegerAl(cbStokKodu, i);
                    StokAdi = DegerAl(cbStokAdi, i);
                    IngIsim = DegerAl(cbIngIsim, i);
                    Kod1 = DegerAl(cbKod1, i);
                    Kod2 = DegerAl(cbKod2, i);
                    Kod3 = DegerAl(cbKod3, i);
                    Kod4 = DegerAl(cbKod4, i);
                    Kod5 = DegerAl(cbKod5, i);
                    Birim = DegerAl(cbBirim, i);
                    Barkod = DegerAl(cbBarkod, i);
                    AlisKdv = DegerAl(cbAlisKdv, i);
                    SatisKdv = DegerAl(cbSatisKdv, i);
                    AlisFiyat1 = DegerAl(cbAlisFiyat1, i);
                    AlisFiyat2 = DegerAl(cbAlisFiyat2, i);
                    SatisFiyat1 = DegerAl(cbSatisFiyat1, i);
                    SatisFiyat2 = DegerAl(cbSatisFiyat2, i);

                    string UserId = OnMuhasebe.frmAnaSayfa.UserId;
                    string sql = "UPDATE TBLSTOKLAR SET";


                    if (ceStokAdi.Checked == true) { sql += "STOKADI = '" + StokAdi + "',"; }
                    if (ceIngIsim.Checked == true) { sql += "INGILIZCEISIM = '" + IngIsim + "',"; }
                    if (ceKod1.Checked == true) { sql += "KOD1 = '" + StokKod1.IdAl(Kod1, true, UserId) + "'"; }
                    if (ceKod2.Checked == true) { sql += "KOD2 = '" + StokKod2.IdAl(Kod2, true, UserId) + " ',"; }
                    if (ceKod3.Checked == true) { sql += "KOD3 = '" + StokKod3.IdAl(Kod3, true, UserId) + " ',"; }
                    if (ceKod4.Checked == true) { sql += "KOD4 = '" + StokKod4.IdAl(Kod4, true, UserId) + " ',"; }
                    if (ceKod5.Checked == true) { sql += "KOD5 = '" + StokKod5.IdAl(Kod5, true, UserId) + " ',"; }
                    if (ceBirim.Checked == true) { sql += "BIRIM = '" + Birim + " ',"; }
                    if (ceBarkod.Checked == true) { sql += " BARKOD = '" + Barkod + " ',"; }
                    if (ceAlisKdv.Checked == true) { sql += "  ALISKDV = '" + AlisKdv.Replace(",", ".") + " ',"; }
                    if (ceSatisKdv.Checked == true) { sql += "  SATISKDV = ' " + SatisKdv.Replace(",", ".") + "',"; }
                    if (ceAlisFiyat1.Checked == true) { sql += "  ALISFIYAT1 =' " + AlisFiyat1.Replace(",", ".") + "',"; }
                    if (ceAlisFiyat2.Checked == true) { sql += "  ALISFIYAT2 = ' " + AlisFiyat2.Replace(",", ".") + "',"; }
                    if (ceSatisFiyat1.Checked == true) { sql += "  SATISFIYAT1 = ' " + SatisFiyat1.Replace(",", ".") + "',"; }
                    if (ceSatisFiyat2.Checked == true) { sql += "  SATISFIYAT2 = '" + SatisFiyat2.Replace(",", ".") + " ',"; }


                    sql += "  EDITUSER = " + UserId + ",";
                    sql += "   EDITDATE = GETDATE()";
                    sql += "WHERE STOKKODU=' " + StokKodu + "'";

                    Dbase.Isle(sql);
                }
                this.Cursor = Cursors.Default;
                Mesajlar.Bilgi("Toplu stok güncelleme işlemi başarılı bir şekilde tamamlanmıştır.");
            }
                    }
        string DegerAl(DevExpress.XtraEditors.ComboBoxEdit Nesne, int SatirId)
        {
            string Deger = "";
            if (Nesne.SelectedIndex > 0)
            {
                Deger = gridView1.GetRowCellValue(SatirId, Nesne.SelectedItem.ToString()).ToString();

            }

            return Deger;

        }
    }
}