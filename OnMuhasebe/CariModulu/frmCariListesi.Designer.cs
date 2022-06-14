
namespace OnMuhasebe.CariModulu
{
    partial class frmCariListesi
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
            this.txtTipi = new DevExpress.XtraEditors.TextEdit();
            this.lbl_Tipi_Listele = new DevExpress.XtraEditors.LabelControl();
            this.txtTc = new DevExpress.XtraEditors.TextEdit();
            this.lbl_Tc_Listele = new DevExpress.XtraEditors.LabelControl();
            this.txtIlce = new DevExpress.XtraEditors.TextEdit();
            this.lbl_Ilce_Listele = new DevExpress.XtraEditors.LabelControl();
            this.txtIl = new DevExpress.XtraEditors.TextEdit();
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
            this.IL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ILCE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TELEFON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VERGIDAIRESI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TIPI = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tp_Arama_Listele)).BeginInit();
            this.tp_Arama_Listele.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIlce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIl.Properties)).BeginInit();
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
            this.splitContainerControl1.Size = new System.Drawing.Size(1278, 859);
            this.splitContainerControl1.SplitterPosition = 186;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // tp_Arama_Listele
            // 
            this.tp_Arama_Listele.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tp_Arama_Listele.Location = new System.Drawing.Point(0, 0);
            this.tp_Arama_Listele.Name = "tp_Arama_Listele";
            this.tp_Arama_Listele.SelectedTabPage = this.xtraTabPage1;
            this.tp_Arama_Listele.Size = new System.Drawing.Size(186, 859);
            this.tp_Arama_Listele.TabIndex = 0;
            this.tp_Arama_Listele.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.txtTipi);
            this.xtraTabPage1.Controls.Add(this.lbl_Tipi_Listele);
            this.xtraTabPage1.Controls.Add(this.txtTc);
            this.xtraTabPage1.Controls.Add(this.lbl_Tc_Listele);
            this.xtraTabPage1.Controls.Add(this.txtIlce);
            this.xtraTabPage1.Controls.Add(this.lbl_Ilce_Listele);
            this.xtraTabPage1.Controls.Add(this.txtIl);
            this.xtraTabPage1.Controls.Add(this.lbl_Il_Listele);
            this.xtraTabPage1.Controls.Add(this.txtCariAdi);
            this.xtraTabPage1.Controls.Add(this.lbl_Cari_Adı_Listele);
            this.xtraTabPage1.Controls.Add(this.btnTemizle);
            this.xtraTabPage1.Controls.Add(this.btnArama);
            this.xtraTabPage1.Controls.Add(this.txtCariKodu);
            this.xtraTabPage1.Controls.Add(this.lbl_Cari_Kodu_Listele);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(180, 831);
            this.xtraTabPage1.Text = "Arama";
            // 
            // txtTipi
            // 
            this.txtTipi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTipi.Location = new System.Drawing.Point(11, 383);
            this.txtTipi.Name = "txtTipi";
            this.txtTipi.Size = new System.Drawing.Size(156, 20);
            this.txtTipi.TabIndex = 5;
            // 
            // lbl_Tipi_Listele
            // 
            this.lbl_Tipi_Listele.Location = new System.Drawing.Point(11, 364);
            this.lbl_Tipi_Listele.Name = "lbl_Tipi_Listele";
            this.lbl_Tipi_Listele.Size = new System.Drawing.Size(16, 13);
            this.lbl_Tipi_Listele.TabIndex = 12;
            this.lbl_Tipi_Listele.Text = "Tipi";
            // 
            // txtTc
            // 
            this.txtTc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTc.Location = new System.Drawing.Point(11, 318);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(156, 20);
            this.txtTc.TabIndex = 4;
            // 
            // lbl_Tc_Listele
            // 
            this.lbl_Tc_Listele.Location = new System.Drawing.Point(11, 299);
            this.lbl_Tc_Listele.Name = "lbl_Tc_Listele";
            this.lbl_Tc_Listele.Size = new System.Drawing.Size(49, 13);
            this.lbl_Tc_Listele.TabIndex = 10;
            this.lbl_Tc_Listele.Text = "T.C. Kimlik";
            // 
            // txtIlce
            // 
            this.txtIlce.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIlce.Location = new System.Drawing.Point(11, 252);
            this.txtIlce.Name = "txtIlce";
            this.txtIlce.Size = new System.Drawing.Size(156, 20);
            this.txtIlce.TabIndex = 3;
            // 
            // lbl_Ilce_Listele
            // 
            this.lbl_Ilce_Listele.Location = new System.Drawing.Point(11, 233);
            this.lbl_Ilce_Listele.Name = "lbl_Ilce_Listele";
            this.lbl_Ilce_Listele.Size = new System.Drawing.Size(17, 13);
            this.lbl_Ilce_Listele.TabIndex = 8;
            this.lbl_Ilce_Listele.Text = "İlçe";
            // 
            // txtIl
            // 
            this.txtIl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIl.Location = new System.Drawing.Point(11, 179);
            this.txtIl.Name = "txtIl";
            this.txtIl.Size = new System.Drawing.Size(156, 20);
            this.txtIl.TabIndex = 2;
            // 
            // lbl_Il_Listele
            // 
            this.lbl_Il_Listele.Location = new System.Drawing.Point(11, 160);
            this.lbl_Il_Listele.Name = "lbl_Il_Listele";
            this.lbl_Il_Listele.Size = new System.Drawing.Size(6, 13);
            this.lbl_Il_Listele.TabIndex = 6;
            this.lbl_Il_Listele.Text = "İl";
            // 
            // txtCariAdi
            // 
            this.txtCariAdi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCariAdi.Location = new System.Drawing.Point(11, 110);
            this.txtCariAdi.Name = "txtCariAdi";
            this.txtCariAdi.Size = new System.Drawing.Size(156, 20);
            this.txtCariAdi.TabIndex = 1;
            // 
            // lbl_Cari_Adı_Listele
            // 
            this.lbl_Cari_Adı_Listele.Location = new System.Drawing.Point(11, 91);
            this.lbl_Cari_Adı_Listele.Name = "lbl_Cari_Adı_Listele";
            this.lbl_Cari_Adı_Listele.Size = new System.Drawing.Size(37, 13);
            this.lbl_Cari_Adı_Listele.TabIndex = 4;
            this.lbl_Cari_Adı_Listele.Text = "Cari Adı";
            // 
            // btnTemizle
            // 
            this.btnTemizle.ImageOptions.Image = global::OnMuhasebe.Properties.Resources.clearall_16x16;
            this.btnTemizle.Location = new System.Drawing.Point(92, 422);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 34);
            this.btnTemizle.TabIndex = 7;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnArama
            // 
            this.btnArama.ImageOptions.Image = global::OnMuhasebe.Properties.Resources.lookup_reference_16x16;
            this.btnArama.Location = new System.Drawing.Point(11, 422);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(75, 34);
            this.btnArama.TabIndex = 6;
            this.btnArama.Text = "Arama";
            // 
            // txtCariKodu
            // 
            this.txtCariKodu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCariKodu.Location = new System.Drawing.Point(11, 38);
            this.txtCariKodu.Name = "txtCariKodu";
            this.txtCariKodu.Size = new System.Drawing.Size(156, 20);
            this.txtCariKodu.TabIndex = 0;
            // 
            // lbl_Cari_Kodu_Listele
            // 
            this.lbl_Cari_Kodu_Listele.Location = new System.Drawing.Point(11, 19);
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
            this.Liste.Size = new System.Drawing.Size(1086, 859);
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
            this.IL,
            this.ILCE,
            this.TELEFON,
            this.VERGIDAIRESI,
            this.TC,
            this.TIPI});
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
            // 
            // IL
            // 
            this.IL.Caption = "İL";
            this.IL.FieldName = "IL";
            this.IL.Name = "IL";
            this.IL.OptionsColumn.AllowEdit = false;
            this.IL.OptionsColumn.AllowFocus = false;
            this.IL.OptionsColumn.FixedWidth = true;
            this.IL.OptionsColumn.ReadOnly = true;
            this.IL.Visible = true;
            this.IL.VisibleIndex = 2;
            // 
            // ILCE
            // 
            this.ILCE.Caption = "İLÇE";
            this.ILCE.FieldName = "ILCE";
            this.ILCE.Name = "ILCE";
            this.ILCE.OptionsColumn.AllowEdit = false;
            this.ILCE.OptionsColumn.AllowFocus = false;
            this.ILCE.OptionsColumn.FixedWidth = true;
            this.ILCE.OptionsColumn.ReadOnly = true;
            this.ILCE.Visible = true;
            this.ILCE.VisibleIndex = 3;
            // 
            // TELEFON
            // 
            this.TELEFON.Caption = "TELEFON";
            this.TELEFON.FieldName = "TELEFON";
            this.TELEFON.Name = "TELEFON";
            this.TELEFON.OptionsColumn.AllowEdit = false;
            this.TELEFON.OptionsColumn.AllowFocus = false;
            this.TELEFON.OptionsColumn.FixedWidth = true;
            this.TELEFON.OptionsColumn.ReadOnly = true;
            this.TELEFON.Visible = true;
            this.TELEFON.VisibleIndex = 4;
            // 
            // VERGIDAIRESI
            // 
            this.VERGIDAIRESI.Caption = "VERGİ DAIRESI";
            this.VERGIDAIRESI.FieldName = "VERGIDAIRESI";
            this.VERGIDAIRESI.Name = "VERGIDAIRESI";
            this.VERGIDAIRESI.OptionsColumn.AllowEdit = false;
            this.VERGIDAIRESI.OptionsColumn.AllowFocus = false;
            this.VERGIDAIRESI.OptionsColumn.FixedWidth = true;
            this.VERGIDAIRESI.OptionsColumn.ReadOnly = true;
            this.VERGIDAIRESI.Visible = true;
            this.VERGIDAIRESI.VisibleIndex = 5;
            // 
            // TC
            // 
            this.TC.Caption = "TC";
            this.TC.FieldName = "TC";
            this.TC.Name = "TC";
            this.TC.OptionsColumn.AllowEdit = false;
            this.TC.OptionsColumn.AllowFocus = false;
            this.TC.OptionsColumn.FixedWidth = true;
            this.TC.OptionsColumn.ReadOnly = true;
            this.TC.Visible = true;
            this.TC.VisibleIndex = 6;
            // 
            // TIPI
            // 
            this.TIPI.Caption = "TİPİ";
            this.TIPI.FieldName = "TIPI";
            this.TIPI.Name = "TIPI";
            this.TIPI.OptionsColumn.AllowEdit = false;
            this.TIPI.OptionsColumn.AllowFocus = false;
            this.TIPI.OptionsColumn.FixedWidth = true;
            this.TIPI.OptionsColumn.ReadOnly = true;
            this.TIPI.Visible = true;
            this.TIPI.VisibleIndex = 7;
            // 
            // frmCariListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 859);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmCariListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari Listesi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCariListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tp_Arama_Listele)).EndInit();
            this.tp_Arama_Listele.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIlce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIl.Properties)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit txtTipi;
        private DevExpress.XtraEditors.LabelControl lbl_Tipi_Listele;
        private DevExpress.XtraEditors.TextEdit txtTc;
        private DevExpress.XtraEditors.LabelControl lbl_Tc_Listele;
        private DevExpress.XtraEditors.TextEdit txtIlce;
        private DevExpress.XtraEditors.LabelControl lbl_Ilce_Listele;
        private DevExpress.XtraEditors.TextEdit txtIl;
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
        private DevExpress.XtraGrid.Columns.GridColumn IL;
        private DevExpress.XtraGrid.Columns.GridColumn ILCE;
        private DevExpress.XtraGrid.Columns.GridColumn TELEFON;
        private DevExpress.XtraGrid.Columns.GridColumn VERGIDAIRESI;
        private DevExpress.XtraGrid.Columns.GridColumn TC;
        private DevExpress.XtraGrid.Columns.GridColumn TIPI;
    }
}