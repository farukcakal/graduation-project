
namespace OnMuhasebe.KasaModulu
{
    partial class frmKasaHareketKayitlari
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKasaHareketKayitlari));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCariIsmi = new DevExpress.XtraEditors.TextEdit();
            this.txtCariKodu = new DevExpress.XtraEditors.TextEdit();
            this.btnCariSec = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.belgeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.aciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vadeTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.borc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.alacak = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bakiye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tipi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtBakiye = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCikis = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiris = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariIsmi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBakiye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCikis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiris.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Kasa Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Kasa Kodu";
            // 
            // txtCariIsmi
            // 
            this.txtCariIsmi.Location = new System.Drawing.Point(102, 62);
            this.txtCariIsmi.Name = "txtCariIsmi";
            this.txtCariIsmi.Properties.ReadOnly = true;
            this.txtCariIsmi.Size = new System.Drawing.Size(353, 20);
            this.txtCariIsmi.TabIndex = 18;
            // 
            // txtCariKodu
            // 
            this.txtCariKodu.Location = new System.Drawing.Point(102, 36);
            this.txtCariKodu.Name = "txtCariKodu";
            this.txtCariKodu.Properties.ReadOnly = true;
            this.txtCariKodu.Size = new System.Drawing.Size(313, 20);
            this.txtCariKodu.TabIndex = 16;
            // 
            // btnCariSec
            // 
            this.btnCariSec.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCariSec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCariSec.ImageOptions.Image")));
            this.btnCariSec.Location = new System.Drawing.Point(419, 36);
            this.btnCariSec.Name = "btnCariSec";
            this.btnCariSec.Size = new System.Drawing.Size(36, 20);
            this.btnCariSec.TabIndex = 17;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtCariIsmi);
            this.groupControl1.Controls.Add(this.txtCariKodu);
            this.groupControl1.Controls.Add(this.btnCariSec);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(726, 108);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Kasa Bilgileri";
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl1.Location = new System.Drawing.Point(0, 108);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(726, 318);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.belgeNo,
            this.aciklama,
            this.vadeTarihi,
            this.borc,
            this.alacak,
            this.bakiye,
            this.tarih,
            this.tipi});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // belgeNo
            // 
            this.belgeNo.Caption = "Belge Numarası";
            this.belgeNo.FieldName = "belgeNo";
            this.belgeNo.Name = "belgeNo";
            this.belgeNo.Visible = true;
            this.belgeNo.VisibleIndex = 1;
            // 
            // aciklama
            // 
            this.aciklama.Caption = "Açıklama";
            this.aciklama.FieldName = "aciklama";
            this.aciklama.Name = "aciklama";
            this.aciklama.Visible = true;
            this.aciklama.VisibleIndex = 2;
            // 
            // vadeTarihi
            // 
            this.vadeTarihi.Caption = "Vade Tarihi";
            this.vadeTarihi.FieldName = "vadeTarihi";
            this.vadeTarihi.Name = "vadeTarihi";
            this.vadeTarihi.Visible = true;
            this.vadeTarihi.VisibleIndex = 3;
            // 
            // borc
            // 
            this.borc.Caption = "Borç";
            this.borc.DisplayFormat.FormatString = "N1";
            this.borc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.borc.FieldName = "borc";
            this.borc.Name = "borc";
            this.borc.Visible = true;
            this.borc.VisibleIndex = 4;
            // 
            // alacak
            // 
            this.alacak.Caption = "Alacak";
            this.alacak.DisplayFormat.FormatString = "N1";
            this.alacak.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.alacak.FieldName = "alacak";
            this.alacak.Name = "alacak";
            this.alacak.Visible = true;
            this.alacak.VisibleIndex = 5;
            // 
            // bakiye
            // 
            this.bakiye.Caption = "Bakiye";
            this.bakiye.DisplayFormat.FormatString = "N1";
            this.bakiye.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.bakiye.FieldName = "bakiye";
            this.bakiye.Name = "bakiye";
            this.bakiye.Visible = true;
            this.bakiye.VisibleIndex = 6;
            // 
            // tarih
            // 
            this.tarih.Caption = "Tarih";
            this.tarih.FieldName = "tarih";
            this.tarih.Name = "tarih";
            this.tarih.Visible = true;
            this.tarih.VisibleIndex = 7;
            // 
            // tipi
            // 
            this.tipi.Caption = "Tipi";
            this.tipi.FieldName = "tipi";
            this.tipi.Name = "tipi";
            this.tipi.Visible = true;
            this.tipi.VisibleIndex = 8;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtBakiye);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.txtCikis);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.txtGiris);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 376);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(726, 50);
            this.panelControl1.TabIndex = 4;
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(506, 18);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Properties.ReadOnly = true;
            this.txtBakiye.Size = new System.Drawing.Size(81, 20);
            this.txtBakiye.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Bakiye";
            // 
            // txtCikis
            // 
            this.txtCikis.Location = new System.Drawing.Point(304, 18);
            this.txtCikis.Name = "txtCikis";
            this.txtCikis.Properties.ReadOnly = true;
            this.txtCikis.Size = new System.Drawing.Size(81, 20);
            this.txtCikis.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Toplam Borç";
            // 
            // txtGiris
            // 
            this.txtGiris.Location = new System.Drawing.Point(102, 18);
            this.txtGiris.Name = "txtGiris";
            this.txtGiris.Properties.ReadOnly = true;
            this.txtGiris.Size = new System.Drawing.Size(81, 20);
            this.txtGiris.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Toplam Alacak";
            // 
            // frmKasaHareketKayitlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 426);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmKasaHareketKayitlari";
            this.Text = "Kasa Hareket Kayıtları";
            ((System.ComponentModel.ISupportInitialize)(this.txtCariIsmi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBakiye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCikis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiris.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtCariIsmi;
        private DevExpress.XtraEditors.TextEdit txtCariKodu;
        private DevExpress.XtraEditors.SimpleButton btnCariSec;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn belgeNo;
        private DevExpress.XtraGrid.Columns.GridColumn aciklama;
        private DevExpress.XtraGrid.Columns.GridColumn vadeTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn borc;
        private DevExpress.XtraGrid.Columns.GridColumn alacak;
        private DevExpress.XtraGrid.Columns.GridColumn bakiye;
        private DevExpress.XtraGrid.Columns.GridColumn tarih;
        private DevExpress.XtraGrid.Columns.GridColumn tipi;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtBakiye;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtCikis;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtGiris;
        private System.Windows.Forms.Label label3;
    }
}