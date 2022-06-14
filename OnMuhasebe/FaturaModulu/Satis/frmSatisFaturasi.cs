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

namespace OnMuhasebe.FaturaModulu
{
    public partial class frmSatisFaturasi : DevExpress.XtraEditors.XtraForm
    {
        StokModulu.Classlar.clsStokTanitimKarti Stok = new StokModulu.Classlar.clsStokTanitimKarti();
        CariModulu.Classlar.clsCariTanitimKarti Cari = new CariModulu.Classlar.clsCariTanitimKarti();
        OnMuhasebe.Classlar.Ekranlar Ekranlar = new OnMuhasebe.Classlar.Ekranlar();
        Classlar.clsNumaralar Numaralar = new Classlar.clsNumaralar();
        Classlar.clsSatisFaturasi SatisFaturasi = new Classlar.clsSatisFaturasi();
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();
        Boolean Edit = false;
        string UrunId, CariId;
        string AcilacakFaturaNo = "-1";
        string AcilacakFaturaId = "-1";
        public frmSatisFaturasi()
        {
            InitializeComponent();
        }

        private void frmSatisFaturasi_Load(object sender, EventArgs e)
        {
            YeniFatura();
        }

        private void btnStokSec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            StokSec();
        }
        void StokSec()
        {
            UrunId = Ekranlar.StokListesiAc(true);
            if (UrunId != "")
            {
                DataRow Satir = Stok.Ac(UrunId);
                string StokKodu, Barkod, StokAdi, Birim;
                decimal BirimFiyat, SatisKdv;

                gridView1.AddNewRow();
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "STOKKODU", Satir["STOKKODU"].ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "STOKADI", Satir["STOKADI"].ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "BARKOD", Satir["BARKOD"].ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "BIRIMFIYAT", Satir["SATISFIYAT1"].ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "BIRIM", Satir["BIRIM"].ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "KDV", Satir["SATISKDV"].ToString());
            }
            }

        void Hesapla()
        {
            decimal BirimFiyat, Miktar, Isk1, Isk2, Toplam, IskontoOncesiToplam,IskontoToplam, KdvToplam, KdvOrani;
            IskontoOncesiToplam = 0;
            Toplam = 0;
            KdvToplam = 0;

            try
            {
                
                for (int i = 0; i <= gridView1.RowCount; i++)
                {
                        Miktar = Convert.ToDecimal(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MIKTAR").ToString());
                        KdvOrani = Convert.ToDecimal(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "KDV").ToString());
                        BirimFiyat = Convert.ToDecimal(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "BIRIMFIYAT").ToString());
                        IskontoOncesiToplam = IskontoOncesiToplam + (BirimFiyat * Miktar);
                        Toplam += Convert.ToDecimal(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TOPLAM").ToString());
                        KdvToplam += Toplam / 100 * KdvOrani;
                }
                txtAraToplam.Text = IskontoOncesiToplam.ToString("0.00");
                txtNetFiyat.Text = Toplam.ToString("0.00");

                /*Fatura formu ilk açıldığında toplam değişkeni 0 olduğu için hataya düşüyordu
                 o yüzden try catch ile program değerleri deniyor. Eğer hataya düşerse 
                iskonto text değeri 0 atanıyor.
                 */
                    IskontoToplam = Toplam / IskontoOncesiToplam;
                    IskontoToplam = (1 - IskontoToplam) * 100;
                    txtIskonto.Text = IskontoToplam.ToString("0.00");
                    txtKdv.Text = KdvToplam.ToString("0.00");
                    txtGenelToplam.Text = (KdvToplam + Toplam).ToString("0.00");
            }
            catch (Exception)
            {
                txtIskonto.Text = "0";
            }
            
        }
        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if(e.Column.Name != "TOPLAM")
            {
                try
                {
                    decimal BirimFiyat, Miktar, Isk1, Isk2;
                    BirimFiyat = Convert.ToDecimal(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "BIRIMFIYAT").ToString());

                    Miktar = Convert.ToDecimal(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MIKTAR").ToString());
                    Isk1 = Convert.ToDecimal(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ISK1").ToString());
                    Isk2 = Convert.ToDecimal(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ISK2").ToString());

                    decimal AraToplam;
                    AraToplam = BirimFiyat * Miktar;
                    AraToplam = AraToplam - (AraToplam / 100 * Isk1);
                    AraToplam = AraToplam - (AraToplam / 100 * Isk2);

                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "TOPLAM", AraToplam);
                    Hesapla();
                }
                catch (Exception)
                {

                    //gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "TOPLAM", 0);
                }
            }
        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "MIKTAR", 1);
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "ISK1", 0);
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "ISK2", 0);
        }

        private void gridView1_RowCountChanged(object sender, EventArgs e)
        {
            /* Program bundan dolayı hataya düşüyor (henüz çözümlenemedi)*/
            //Hesapla();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }

        void Kaydet()
        {
            Classlar.clsSatisFaturasi SatisFaturasi = new Classlar.clsSatisFaturasi();
            string Turu = "K";
            if (txtTuru.SelectedIndex == 0)
            {
                Turu = "A";
            }



            DataTable StokKalemleri = new DataTable();
            StokKalemleri = (DataTable)Liste.DataSource;

            if (Edit == true)
            {
                if (SatisFaturasi.Guncelle(AcilacakFaturaId, txtFaturaNo.Text, btnCariSec.Text, txtTarih.Text, txtVadeTarihi.Text, txtGenelToplam.Text, Turu, txtAciklama.Text, StokKalemleri) == true)
                {
                    Mesajlar.Bilgi("Fatura başarılı bir şekilde güncellenmiştir.");
                }
                else
                {
                    Mesajlar.Hata();
                }
            }

            else
            {
                if (SatisFaturasi.Ekle(txtFaturaNo.Text, btnCariSec.Text, txtTarih.Text, txtVadeTarihi.Text, txtGenelToplam.Text, Turu, txtAciklama.Text, StokKalemleri) == true)
                {
                    Mesajlar.Bilgi("Fatura başarılı bir şekilde eklenmiştir.");
                }
                else
                {
                    Mesajlar.Hata();
                }
            }
            YeniFatura();
        }
       

        private void txtFaturaNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                AcilacakFaturaNo = Ekranlar.SatisFaturasiListesi();
                DataRow Ac = SatisFaturasi.Ac(AcilacakFaturaNo);
                AcilacakFaturaId = Ac["ID"].ToString();
                txtAciklama.Text = Ac["ACIKLAMA"].ToString();
                txtCariIsim.Text = Ac["CARIISIM"].ToString();
                btnCariSec.Text = Ac["CARIKODU"].ToString();
                txtFaturaNo.Text = AcilacakFaturaNo;

                DateTime Tarih = Convert.ToDateTime(Ac["TARIH"].ToString());
                DateTime VadeTarih = Convert.ToDateTime(Ac["VADETARIH"].ToString());
                txtTarih.EditValue = Tarih;
                txtVadeTarihi.EditValue = VadeTarih;

                string Turu = Ac["TURU"].ToString();
                if (Turu == "A")
                {
                    txtTuru.SelectedIndex = 0;
                }
                else
                {
                    txtTuru.SelectedIndex = 1;
                }
                Liste.DataSource = SatisFaturasi.KalemleriAc(AcilacakFaturaNo);
                Edit = true;

            }
            catch (Exception)
            {

                Edit = false;
            }
        } 

        private void btnCariSec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            CariId = Ekranlar.CariListesiAc();
            DataRow Satir = Cari.Ac(CariId);
            txtCariIsim.Text = Satir["CARIISIM"].ToString();
            btnCariSec.Text = Satir["CARIKODU"].ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit == true)
            {
                if(Mesajlar.Sor("Faturayı Silmek istediğinizden emin misiniz ?")==true)
                SatisFaturasi.Sil(AcilacakFaturaId);
                YeniFatura();
            }
        }

        void YeniFatura()
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtVadeTarihi.Text = DateTime.Now.ToShortDateString();
            //txtFaturaNo.Text = Numaralar.GetYeniSatisFaturasiNumarasi();
            Liste.DataSource = SatisFaturasi.KalemleriAc("-1");
            txtAciklama.Text = "";
            txtCariIsim.Text = "";
            btnCariSec.Text = "";
            txtVadeTarihi.EditValue = DateTime.Now.ToShortDateString();
            txtTarih.EditValue = DateTime.Now.ToShortDateString();
            txtTuru.SelectedIndex = 0;
            txtFaturaNo.Focus();
            Edit = false;
        }
    }
    }

        