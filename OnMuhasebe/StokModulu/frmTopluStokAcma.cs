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
    public partial class frmTopluStokAcma : DevExpress.XtraEditors.XtraForm
    {

        Classlar.clsStokTanitimKarti Stok = new Classlar.clsStokTanitimKarti();
        public frmTopluStokAcma()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TopluStokAcma_Load(object sender, EventArgs e)
        {

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

        private void barAktar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           

        }
        void IceriAktar()
        {

            Classlar.clsStokKod1 StokKod1 = new Classlar.clsStokKod1();
            Classlar.clsStokKod2 StokKod2 = new Classlar.clsStokKod2();
            Classlar.clsStokKod3 StokKod3 = new Classlar.clsStokKod3();
            Classlar.clsStokKod4 StokKod4 = new Classlar.clsStokKod4();
            Classlar.clsStokKod5 StokKod5 = new Classlar.clsStokKod5();

            string StokKodu, StokAdi, IngIsim, Kod1, Kod2, Kod3, Kod4, Kod5, Birim, Barkod, AlisKdv, SatisKdv, AlisFiyat1, AlisFiyat2, SatisFiyat1, SatisFiyat2;

            this.Cursor = Cursors.WaitCursor;


            for (int i = 0; i < gridView1.RowCount-1; i++)
            {
                StokKodu = DegerAl(comStokKodu, i);
                StokAdi = DegerAl(comStokAdi, i);
                IngIsim = DegerAl(comIngIsim, i);
                Kod1 = DegerAl(comKod1, i);
                Kod2 = DegerAl(comKod2, i);
                Kod3 = DegerAl(comKod3, i);
                Kod4 = DegerAl(comKod4, i);
                Kod5 = DegerAl(comKod5, i);
                Birim = DegerAl(comBirim, i);
                Barkod = DegerAl(comBarkod, i);
                AlisKdv = DegerAl(comAlisKdv, i);
                SatisKdv = DegerAl(comSatisKdv, i);
                AlisFiyat1 = DegerAl(comAlisFiyat1, i);
                AlisFiyat2 = DegerAl(comAlisFiyat2, i);
                SatisFiyat1 = DegerAl(comSatisFiyat1, i);
                SatisFiyat2 = DegerAl(comboBoxEdit16, i);

                string UserId = OnMuhasebe.frmAnaSayfa.UserId;

                Stok.Ekle(StokKodu, StokAdi, IngIsim, StokKod1.IdAl(Kod1,true,UserId), StokKod2.IdAl(Kod2, true, UserId), StokKod3.IdAl(Kod3, true, UserId), StokKod4.IdAl(Kod4,true, UserId), StokKod5.IdAl(Kod5, true, UserId), Birim, Barkod, AlisKdv, SatisKdv, AlisFiyat1, AlisFiyat2, SatisFiyat1, SatisFiyat2,UserId);
            }
            this.Cursor = Cursors.Default;
        }
        string DegerAl(DevExpress.XtraEditors.ComboBoxEdit Nesne, int SatirId)
        {
            string Deger="";
            if (Nesne.SelectedIndex>0)
            {
                Deger = gridView1.GetRowCellValue(SatirId,Nesne.SelectedItem.ToString()).ToString();

            }
                    
             return Deger;

        }

        private void barKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barAc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void lblStokKodu_Click(object sender, EventArgs e)
        {

        }

        private void barIceriAktar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IceriAktar();
        }
    }
}