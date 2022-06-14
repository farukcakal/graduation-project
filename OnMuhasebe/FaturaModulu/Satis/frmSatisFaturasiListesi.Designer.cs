
namespace OnMuhasebe.FaturaModulu.Satis
{
    partial class frmSatisFaturasiListesi
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.tp_Arama_Listele = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.txtFaturaNo = new DevExpress.XtraEditors.TextEdit();
            this.lbl_Il_Listele = new DevExpress.XtraEditors.LabelControl();
            this.txtCariAdi = new DevExpress.XtraEditors.TextEdit();
            this.lbl_Cari_Adı_Listele = new DevExpress.XtraEditors.LabelControl();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnArama = new DevExpress.XtraEditors.SimpleButton();
            this.txtCariKodu = new DevExpress.XtraEditors.TextEdit();
            this.lbl_Cari_Kodu_Listele = new DevExpress.XtraEditors.LabelControl();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CARIKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CARISIM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FATURANO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TARIH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GENELTOPLAM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TURU = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tp_Arama_Listele)).BeginInit();
            this.tp_Arama_Listele.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaturaNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1;
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.tp_Arama_Listele);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.Liste);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1098, 745);
            this.splitContainerControl1.SplitterPosition = 186;
            this.splitContainerControl1.TabIndex = 2;
            // 
            // tp_Arama_Listele
            // 
            this.tp_Arama_Listele.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tp_Arama_Listele.Location = new System.Drawing.Point(0, 0);
            this.tp_Arama_Listele.Name = "tp_Arama_Listele";
            this.tp_Arama_Listele.SelectedTabPage = this.xtraTabPage1;
            this.tp_Arama_Listele.Size = new System.Drawing.Size(186, 745);
            this.tp_Arama_Listele.TabIndex = 0;
            this.tp_Arama_Listele.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.txtFaturaNo);
            this.xtraTabPage1.Controls.Add(this.lbl_Il_Listele);
            this.xtraTabPage1.Controls.Add(this.txtCariAdi);
            this.xtraTabPage1.Controls.Add(this.lbl_Cari_Adı_Listele);
            this.xtraTabPage1.Controls.Add(this.btnTemizle);
            this.xtraTabPage1.Controls.Add(this.btnArama);
            this.xtraTabPage1.Controls.Add(this.txtCariKodu);
            this.xtraTabPage1.Controls.Add(this.lbl_Cari_Kodu_Listele);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(180, 717);
            this.xtraTabPage1.Text = "Arama";
            // 
            // txtFaturaNo
            // 
            this.txtFaturaNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFaturaNo.Location = new System.Drawing.Point(11, 42);
            this.txtFaturaNo.Name = "txtFaturaNo";
            this.txtFaturaNo.Size = new System.Drawing.Size(156, 20);
            this.txtFaturaNo.TabIndex = 0;
            // 
            // lbl_Il_Listele
            // 
            this.lbl_Il_Listele.Location = new System.Drawing.Point(11, 23);
            this.lbl_Il_Listele.Name = "lbl_Il_Listele";
            this.lbl_Il_Listele.Size = new System.Drawing.Size(48, 13);
            this.lbl_Il_Listele.TabIndex = 6;
            this.lbl_Il_Listele.Text = "Fatura No";
            // 
            // txtCariAdi
            // 
            this.txtCariAdi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCariAdi.Location = new System.Drawing.Point(11, 188);
            this.txtCariAdi.Name = "txtCariAdi";
            this.txtCariAdi.Size = new System.Drawing.Size(156, 20);
            this.txtCariAdi.TabIndex = 2;
            // 
            // lbl_Cari_Adı_Listele
            // 
            this.lbl_Cari_Adı_Listele.Location = new System.Drawing.Point(11, 169);
            this.lbl_Cari_Adı_Listele.Name = "lbl_Cari_Adı_Listele";
            this.lbl_Cari_Adı_Listele.Size = new System.Drawing.Size(37, 13);
            this.lbl_Cari_Adı_Listele.TabIndex = 4;
            this.lbl_Cari_Adı_Listele.Text = "Cari Adı";
            // 
            // btnTemizle
            // 
            this.btnTemizle.ImageOptions.Image = global::OnMuhasebe.Properties.Resources.clearall_16x16;
            this.btnTemizle.Location = new System.Drawing.Point(92, 535);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 34);
            this.btnTemizle.TabIndex = 4;
            this.btnTemizle.Text = "Temizle";
            // 
            // btnArama
            // 
            this.btnArama.ImageOptions.Image = global::OnMuhasebe.Properties.Resources.lookup_reference_16x16;
            this.btnArama.Location = new System.Drawing.Point(11, 535);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(75, 34);
            this.btnArama.TabIndex = 3;
            this.btnArama.Text = "Arama";
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // txtCariKodu
            // 
            this.txtCariKodu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCariKodu.Location = new System.Drawing.Point(11, 116);
            this.txtCariKodu.Name = "txtCariKodu";
            this.txtCariKodu.Size = new System.Drawing.Size(156, 20);
            this.txtCariKodu.TabIndex = 1;
            // 
            // lbl_Cari_Kodu_Listele
            // 
            this.lbl_Cari_Kodu_Listele.Location = new System.Drawing.Point(11, 97);
            this.lbl_Cari_Kodu_Listele.Name = "lbl_Cari_Kodu_Listele";
            this.lbl_Cari_Kodu_Listele.Size = new System.Drawing.Size(46, 13);
            this.lbl_Cari_Kodu_Listele.TabIndex = 0;
            this.lbl_Cari_Kodu_Listele.Text = "Cari Kodu";
            // 
            // Liste
            // 
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.MainView = this.gridView1;
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(906, 745);
            this.Liste.TabIndex = 0;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.CARIKODU,
            this.CARISIM,
            this.FATURANO,
            this.TARIH,
            this.GENELTOPLAM,
            this.TURU});
            this.gridView1.GridControl = this.Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // ID
            // 
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.OptionsColumn.AllowFocus = false;
            this.ID.OptionsColumn.AllowShowHide = false;
            this.ID.OptionsColumn.FixedWidth = true;
            this.ID.OptionsColumn.ReadOnly = true;
            // 
            // CARIKODU
            // 
            this.CARIKODU.Caption = "CARİ KODU";
            this.CARIKODU.FieldName = "CARIKODU";
            this.CARIKODU.Name = "CARIKODU";
            this.CARIKODU.OptionsColumn.AllowEdit = false;
            this.CARIKODU.OptionsColumn.AllowFocus = false;
            this.CARIKODU.OptionsColumn.FixedWidth = true;
            this.CARIKODU.OptionsColumn.ReadOnly = true;
            this.CARIKODU.Visible = true;
            this.CARIKODU.VisibleIndex = 0;
            // 
            // CARISIM
            // 
            this.CARISIM.Caption = "CARİ İSİM";
            this.CARISIM.FieldName = "CARIISIM";
            this.CARISIM.Name = "CARISIM";
            this.CARISIM.OptionsColumn.AllowEdit = false;
            this.CARISIM.OptionsColumn.AllowFocus = false;
            this.CARISIM.OptionsColumn.ReadOnly = true;
            this.CARISIM.Visible = true;
            this.CARISIM.VisibleIndex = 1;
            this.CARISIM.Width = 507;
            // 
            // FATURANO
            // 
            this.FATURANO.Caption = "FATURA NO";
            this.FATURANO.FieldName = "FATURANO";
            this.FATURANO.Name = "FATURANO";
            this.FATURANO.OptionsColumn.AllowEdit = false;
            this.FATURANO.OptionsColumn.AllowFocus = false;
            this.FATURANO.OptionsColumn.FixedWidth = true;
            this.FATURANO.OptionsColumn.ReadOnly = true;
            this.FATURANO.Visible = true;
            this.FATURANO.VisibleIndex = 2;
            this.FATURANO.Width = 86;
            // 
            // TARIH
            // 
            this.TARIH.Caption = "TARİH";
            this.TARIH.FieldName = "TARIH";
            this.TARIH.Name = "TARIH";
            this.TARIH.OptionsColumn.AllowEdit = false;
            this.TARIH.OptionsColumn.AllowFocus = false;
            this.TARIH.OptionsColumn.FixedWidth = true;
            this.TARIH.OptionsColumn.ReadOnly = true;
            this.TARIH.Visible = true;
            this.TARIH.VisibleIndex = 3;
            // 
            // GENELTOPLAM
            // 
            this.GENELTOPLAM.Caption = "GENEL TOPLAM";
            this.GENELTOPLAM.FieldName = "GENELTOPLAM";
            this.GENELTOPLAM.Name = "GENELTOPLAM";
            this.GENELTOPLAM.OptionsColumn.AllowEdit = false;
            this.GENELTOPLAM.OptionsColumn.AllowFocus = false;
            this.GENELTOPLAM.OptionsColumn.FixedWidth = true;
            this.GENELTOPLAM.OptionsColumn.ReadOnly = true;
            this.GENELTOPLAM.Visible = true;
            this.GENELTOPLAM.VisibleIndex = 4;
            // 
            // TURU
            // 
            this.TURU.Caption = "TÜRÜ";
            this.TURU.FieldName = "TURU";
            this.TURU.Name = "TURU";
            this.TURU.OptionsColumn.AllowEdit = false;
            this.TURU.OptionsColumn.AllowFocus = false;
            this.TURU.OptionsColumn.FixedWidth = true;
            this.TURU.OptionsColumn.ReadOnly = true;
            this.TURU.Visible = true;
            this.TURU.VisibleIndex = 5;
            // 
            // frmSatisFaturasiListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 745);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmSatisFaturasiListesi";
            this.Text = "Satış Faturası Listesi";
            this.Load += new System.EventHandler(this.frmSatisFaturasiListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tp_Arama_Listele)).EndInit();
            this.tp_Arama_Listele.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaturaNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTab.XtraTabControl tp_Arama_Listele;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.TextEdit txtFaturaNo;
        private DevExpress.XtraEditors.LabelControl lbl_Il_Listele;
        private DevExpress.XtraEditors.TextEdit txtCariAdi;
        private DevExpress.XtraEditors.LabelControl lbl_Cari_Adı_Listele;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.SimpleButton btnArama;
        private DevExpress.XtraEditors.TextEdit txtCariKodu;
        private DevExpress.XtraEditors.LabelControl lbl_Cari_Kodu_Listele;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn CARIKODU;
        private DevExpress.XtraGrid.Columns.GridColumn CARISIM;
        private DevExpress.XtraGrid.Columns.GridColumn FATURANO;
        private DevExpress.XtraGrid.Columns.GridColumn TARIH;
        private DevExpress.XtraGrid.Columns.GridColumn GENELTOPLAM;
        private DevExpress.XtraGrid.Columns.GridColumn TURU;
    }
}