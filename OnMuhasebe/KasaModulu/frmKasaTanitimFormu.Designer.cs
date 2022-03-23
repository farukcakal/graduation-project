
namespace OnMuhasebe.KasaModulu
{
    partial class frmKasaTanitimFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKasaTanitimFormu));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtKasaAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.listeKasaBakiye = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.giris = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cikis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bakiye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeni = new DevExpress.XtraEditors.SimpleButton();
            this.btnKasaKodu = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeKasaBakiye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnKasaKodu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kasa Kodu";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Kasa Adı";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 64);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Açıklama";
            // 
            // txtKasaAdi
            // 
            this.txtKasaAdi.Location = new System.Drawing.Point(90, 35);
            this.txtKasaAdi.Name = "txtKasaAdi";
            this.txtKasaAdi.Size = new System.Drawing.Size(100, 20);
            this.txtKasaAdi.TabIndex = 1;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(90, 63);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(368, 96);
            this.txtAciklama.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.listeKasaBakiye);
            this.groupControl1.Location = new System.Drawing.Point(12, 177);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(448, 131);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Kasa Bakiyesi";
            // 
            // listeKasaBakiye
            // 
            this.listeKasaBakiye.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listeKasaBakiye.Location = new System.Drawing.Point(2, 23);
            this.listeKasaBakiye.MainView = this.gridView1;
            this.listeKasaBakiye.Name = "listeKasaBakiye";
            this.listeKasaBakiye.Size = new System.Drawing.Size(444, 106);
            this.listeKasaBakiye.TabIndex = 0;
            this.listeKasaBakiye.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.giris,
            this.cikis,
            this.bakiye,
            this.gridColumn1});
            this.gridView1.GridControl = this.listeKasaBakiye;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // giris
            // 
            this.giris.Caption = "Toplam Giriş";
            this.giris.FieldName = "giris";
            this.giris.Name = "giris";
            this.giris.OptionsColumn.AllowEdit = false;
            this.giris.OptionsColumn.AllowFocus = false;
            this.giris.OptionsColumn.FixedWidth = true;
            this.giris.OptionsColumn.ReadOnly = true;
            this.giris.Visible = true;
            this.giris.VisibleIndex = 0;
            this.giris.Width = 108;
            // 
            // cikis
            // 
            this.cikis.Caption = "Toplam Çıkış";
            this.cikis.FieldName = "cikis";
            this.cikis.Name = "cikis";
            this.cikis.OptionsColumn.AllowEdit = false;
            this.cikis.OptionsColumn.AllowFocus = false;
            this.cikis.OptionsColumn.FixedWidth = true;
            this.cikis.OptionsColumn.ReadOnly = true;
            this.cikis.Visible = true;
            this.cikis.VisibleIndex = 1;
            this.cikis.Width = 95;
            // 
            // bakiye
            // 
            this.bakiye.Caption = "Bakiye";
            this.bakiye.FieldName = "bakiye";
            this.bakiye.Name = "bakiye";
            this.bakiye.OptionsColumn.AllowEdit = false;
            this.bakiye.OptionsColumn.AllowFocus = false;
            this.bakiye.OptionsColumn.FixedWidth = true;
            this.bakiye.OptionsColumn.ReadOnly = true;
            this.bakiye.Visible = true;
            this.bakiye.VisibleIndex = 2;
            this.bakiye.Width = 88;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnKapat);
            this.panelControl2.Controls.Add(this.btnSil);
            this.panelControl2.Controls.Add(this.btnKaydet);
            this.panelControl2.Controls.Add(this.btnYeni);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 314);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(472, 47);
            this.panelControl2.TabIndex = 4;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
            this.btnKapat.Location = new System.Drawing.Point(354, 9);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(96, 33);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Text = "Kapat [Esc]";
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(252, 9);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(96, 33);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(153, 9);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(96, 33);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            // 
            // btnYeni
            // 
            this.btnYeni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYeni.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYeni.ImageOptions.Image")));
            this.btnYeni.Location = new System.Drawing.Point(54, 9);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(96, 33);
            this.btnYeni.TabIndex = 0;
            this.btnYeni.Text = "Yeni";
            // 
            // btnKasaKodu
            // 
            this.btnKasaKodu.Location = new System.Drawing.Point(90, 9);
            this.btnKasaKodu.Name = "btnKasaKodu";
            this.btnKasaKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnKasaKodu.Size = new System.Drawing.Size(100, 20);
            this.btnKasaKodu.TabIndex = 0;
            // 
            // frmKasaTanitimFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 361);
            this.Controls.Add(this.btnKasaKodu);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtKasaAdi);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.IconOptions.ShowIcon = false;
            this.Name = "frmKasaTanitimFormu";
            this.Text = "Kasa Tanıtım Kartı";
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listeKasaBakiye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnKasaKodu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtKasaAdi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl listeKasaBakiye;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn giris;
        private DevExpress.XtraGrid.Columns.GridColumn cikis;
        private DevExpress.XtraGrid.Columns.GridColumn bakiye;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnYeni;
        private DevExpress.XtraEditors.ButtonEdit btnKasaKodu;
    }
}