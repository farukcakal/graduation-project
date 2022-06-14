
namespace OnMuhasebe.StokModulu
{
    partial class frmStokListesi
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
            this.components = new System.ComponentModel.Container();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.tp_Arama_Listele = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.txtKod5 = new DevExpress.XtraEditors.TextEdit();
            this.lbl_Kod5_Listele = new DevExpress.XtraEditors.LabelControl();
            this.txtKod4 = new DevExpress.XtraEditors.TextEdit();
            this.lbl_Kod4_Listele = new DevExpress.XtraEditors.LabelControl();
            this.txtKod3 = new DevExpress.XtraEditors.TextEdit();
            this.lbl_Kod3_Listele = new DevExpress.XtraEditors.LabelControl();
            this.txtKod2 = new DevExpress.XtraEditors.TextEdit();
            this.lbl_Kod2_Listele = new DevExpress.XtraEditors.LabelControl();
            this.txtKod1 = new DevExpress.XtraEditors.TextEdit();
            this.lbl_Kod1_Listele = new DevExpress.XtraEditors.LabelControl();
            this.txtStokAdi = new DevExpress.XtraEditors.TextEdit();
            this.lbl_Stok_Adı_Listele = new DevExpress.XtraEditors.LabelControl();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnArama = new DevExpress.XtraEditors.SimpleButton();
            this.txtStokKodu = new DevExpress.XtraEditors.TextEdit();
            this.lbl_Stok_Kodu_Listele = new DevExpress.XtraEditors.LabelControl();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.SagMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SagEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.SagGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.SagSil = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STOKKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STOKADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SATISFIYAT1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MIKTAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KOD1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KOD2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KOD3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KOD4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KOD5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tp_Arama_Listele)).BeginInit();
            this.tp_Arama_Listele.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SagMenu.SuspendLayout();
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
            this.splitContainerControl1.Size = new System.Drawing.Size(1270, 523);
            this.splitContainerControl1.SplitterPosition = 186;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // tp_Arama_Listele
            // 
            this.tp_Arama_Listele.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tp_Arama_Listele.Location = new System.Drawing.Point(0, 0);
            this.tp_Arama_Listele.Name = "tp_Arama_Listele";
            this.tp_Arama_Listele.SelectedTabPage = this.xtraTabPage1;
            this.tp_Arama_Listele.Size = new System.Drawing.Size(186, 523);
            this.tp_Arama_Listele.TabIndex = 0;
            this.tp_Arama_Listele.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.txtKod5);
            this.xtraTabPage1.Controls.Add(this.lbl_Kod5_Listele);
            this.xtraTabPage1.Controls.Add(this.txtKod4);
            this.xtraTabPage1.Controls.Add(this.lbl_Kod4_Listele);
            this.xtraTabPage1.Controls.Add(this.txtKod3);
            this.xtraTabPage1.Controls.Add(this.lbl_Kod3_Listele);
            this.xtraTabPage1.Controls.Add(this.txtKod2);
            this.xtraTabPage1.Controls.Add(this.lbl_Kod2_Listele);
            this.xtraTabPage1.Controls.Add(this.txtKod1);
            this.xtraTabPage1.Controls.Add(this.lbl_Kod1_Listele);
            this.xtraTabPage1.Controls.Add(this.txtStokAdi);
            this.xtraTabPage1.Controls.Add(this.lbl_Stok_Adı_Listele);
            this.xtraTabPage1.Controls.Add(this.btnTemizle);
            this.xtraTabPage1.Controls.Add(this.btnArama);
            this.xtraTabPage1.Controls.Add(this.txtStokKodu);
            this.xtraTabPage1.Controls.Add(this.lbl_Stok_Kodu_Listele);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(180, 495);
            this.xtraTabPage1.Text = "Arama";
            // 
            // txtKod5
            // 
            this.txtKod5.Location = new System.Drawing.Point(3, 293);
            this.txtKod5.Name = "txtKod5";
            this.txtKod5.Size = new System.Drawing.Size(168, 20);
            this.txtKod5.TabIndex = 6;
            // 
            // lbl_Kod5_Listele
            // 
            this.lbl_Kod5_Listele.Location = new System.Drawing.Point(3, 275);
            this.lbl_Kod5_Listele.Name = "lbl_Kod5_Listele";
            this.lbl_Kod5_Listele.Size = new System.Drawing.Size(27, 13);
            this.lbl_Kod5_Listele.TabIndex = 14;
            this.lbl_Kod5_Listele.Text = "Kod 5";
            // 
            // txtKod4
            // 
            this.txtKod4.Location = new System.Drawing.Point(3, 249);
            this.txtKod4.Name = "txtKod4";
            this.txtKod4.Size = new System.Drawing.Size(168, 20);
            this.txtKod4.TabIndex = 5;
            // 
            // lbl_Kod4_Listele
            // 
            this.lbl_Kod4_Listele.Location = new System.Drawing.Point(3, 233);
            this.lbl_Kod4_Listele.Name = "lbl_Kod4_Listele";
            this.lbl_Kod4_Listele.Size = new System.Drawing.Size(27, 13);
            this.lbl_Kod4_Listele.TabIndex = 12;
            this.lbl_Kod4_Listele.Text = "Kod 4";
            // 
            // txtKod3
            // 
            this.txtKod3.Location = new System.Drawing.Point(3, 207);
            this.txtKod3.Name = "txtKod3";
            this.txtKod3.Size = new System.Drawing.Size(168, 20);
            this.txtKod3.TabIndex = 4;
            // 
            // lbl_Kod3_Listele
            // 
            this.lbl_Kod3_Listele.Location = new System.Drawing.Point(3, 191);
            this.lbl_Kod3_Listele.Name = "lbl_Kod3_Listele";
            this.lbl_Kod3_Listele.Size = new System.Drawing.Size(27, 13);
            this.lbl_Kod3_Listele.TabIndex = 10;
            this.lbl_Kod3_Listele.Text = "Kod 3";
            // 
            // txtKod2
            // 
            this.txtKod2.Location = new System.Drawing.Point(3, 166);
            this.txtKod2.Name = "txtKod2";
            this.txtKod2.Size = new System.Drawing.Size(168, 20);
            this.txtKod2.TabIndex = 3;
            // 
            // lbl_Kod2_Listele
            // 
            this.lbl_Kod2_Listele.Location = new System.Drawing.Point(3, 149);
            this.lbl_Kod2_Listele.Name = "lbl_Kod2_Listele";
            this.lbl_Kod2_Listele.Size = new System.Drawing.Size(27, 13);
            this.lbl_Kod2_Listele.TabIndex = 8;
            this.lbl_Kod2_Listele.Text = "Kod 2";
            // 
            // txtKod1
            // 
            this.txtKod1.Location = new System.Drawing.Point(3, 118);
            this.txtKod1.Name = "txtKod1";
            this.txtKod1.Size = new System.Drawing.Size(168, 20);
            this.txtKod1.TabIndex = 2;
            // 
            // lbl_Kod1_Listele
            // 
            this.lbl_Kod1_Listele.Location = new System.Drawing.Point(3, 102);
            this.lbl_Kod1_Listele.Name = "lbl_Kod1_Listele";
            this.lbl_Kod1_Listele.Size = new System.Drawing.Size(27, 13);
            this.lbl_Kod1_Listele.TabIndex = 6;
            this.lbl_Kod1_Listele.Text = "Kod 1";
            // 
            // txtStokAdi
            // 
            this.txtStokAdi.Location = new System.Drawing.Point(3, 76);
            this.txtStokAdi.Name = "txtStokAdi";
            this.txtStokAdi.Size = new System.Drawing.Size(168, 20);
            this.txtStokAdi.TabIndex = 1;
            // 
            // lbl_Stok_Adı_Listele
            // 
            this.lbl_Stok_Adı_Listele.Location = new System.Drawing.Point(3, 59);
            this.lbl_Stok_Adı_Listele.Name = "lbl_Stok_Adı_Listele";
            this.lbl_Stok_Adı_Listele.Size = new System.Drawing.Size(39, 13);
            this.lbl_Stok_Adı_Listele.TabIndex = 4;
            this.lbl_Stok_Adı_Listele.Text = "Stok Adı";
            // 
            // btnTemizle
            // 
            this.btnTemizle.ImageOptions.Image = global::OnMuhasebe.Properties.Resources.clearall_16x16;
            this.btnTemizle.Location = new System.Drawing.Point(90, 339);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(81, 29);
            this.btnTemizle.TabIndex = 8;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnArama
            // 
            this.btnArama.ImageOptions.Image = global::OnMuhasebe.Properties.Resources.lookup_reference_16x16;
            this.btnArama.Location = new System.Drawing.Point(3, 339);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(81, 29);
            this.btnArama.TabIndex = 7;
            this.btnArama.Text = "Arama";
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // txtStokKodu
            // 
            this.txtStokKodu.Location = new System.Drawing.Point(3, 30);
            this.txtStokKodu.Name = "txtStokKodu";
            this.txtStokKodu.Size = new System.Drawing.Size(168, 20);
            this.txtStokKodu.TabIndex = 0;
            // 
            // lbl_Stok_Kodu_Listele
            // 
            this.lbl_Stok_Kodu_Listele.Location = new System.Drawing.Point(3, 13);
            this.lbl_Stok_Kodu_Listele.Name = "lbl_Stok_Kodu_Listele";
            this.lbl_Stok_Kodu_Listele.Size = new System.Drawing.Size(48, 13);
            this.lbl_Stok_Kodu_Listele.TabIndex = 0;
            this.lbl_Stok_Kodu_Listele.Text = "Stok Kodu";
            // 
            // Liste
            // 
            this.Liste.ContextMenuStrip = this.SagMenu;
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.MainView = this.gridView1;
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(1078, 523);
            this.Liste.TabIndex = 0;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // SagMenu
            // 
            this.SagMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SagEkle,
            this.SagGuncelle,
            this.SagSil});
            this.SagMenu.Name = "SagMenu";
            this.SagMenu.Size = new System.Drawing.Size(121, 70);
            // 
            // SagEkle
            // 
            this.SagEkle.Name = "SagEkle";
            this.SagEkle.Size = new System.Drawing.Size(120, 22);
            this.SagEkle.Text = "Ekle";
            this.SagEkle.Click += new System.EventHandler(this.SagEkle_Click);
            // 
            // SagGuncelle
            // 
            this.SagGuncelle.Name = "SagGuncelle";
            this.SagGuncelle.Size = new System.Drawing.Size(120, 22);
            this.SagGuncelle.Text = "Güncelle";
            this.SagGuncelle.Click += new System.EventHandler(this.SagGuncelle_Click);
            // 
            // SagSil
            // 
            this.SagSil.Name = "SagSil";
            this.SagSil.Size = new System.Drawing.Size(120, 22);
            this.SagSil.Text = "Sil";
            this.SagSil.Click += new System.EventHandler(this.SagSil_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.STOKKODU,
            this.STOKADI,
            this.SATISFIYAT1,
            this.MIKTAR,
            this.KOD1,
            this.KOD2,
            this.KOD3,
            this.KOD4,
            this.KOD5});
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
            // STOKKODU
            // 
            this.STOKKODU.Caption = "STOK KODU";
            this.STOKKODU.FieldName = "STOKKODU";
            this.STOKKODU.Name = "STOKKODU";
            this.STOKKODU.OptionsColumn.AllowEdit = false;
            this.STOKKODU.OptionsColumn.AllowFocus = false;
            this.STOKKODU.OptionsColumn.FixedWidth = true;
            this.STOKKODU.OptionsColumn.ReadOnly = true;
            this.STOKKODU.Visible = true;
            this.STOKKODU.VisibleIndex = 0;
            // 
            // STOKADI
            // 
            this.STOKADI.Caption = "STOK ADI";
            this.STOKADI.FieldName = "STOKADI";
            this.STOKADI.Name = "STOKADI";
            this.STOKADI.OptionsColumn.AllowEdit = false;
            this.STOKADI.OptionsColumn.AllowFocus = false;
            this.STOKADI.OptionsColumn.ReadOnly = true;
            this.STOKADI.Visible = true;
            this.STOKADI.VisibleIndex = 1;
            // 
            // SATISFIYAT1
            // 
            this.SATISFIYAT1.Caption = "SATISFIYAT1";
            this.SATISFIYAT1.FieldName = "SATISFIYAT1";
            this.SATISFIYAT1.Name = "SATISFIYAT1";
            this.SATISFIYAT1.OptionsColumn.AllowEdit = false;
            this.SATISFIYAT1.OptionsColumn.AllowFocus = false;
            this.SATISFIYAT1.OptionsColumn.FixedWidth = true;
            this.SATISFIYAT1.OptionsColumn.ReadOnly = true;
            this.SATISFIYAT1.Visible = true;
            this.SATISFIYAT1.VisibleIndex = 2;
            // 
            // MIKTAR
            // 
            this.MIKTAR.Caption = "MIKTAR";
            this.MIKTAR.FieldName = "MIKTAR";
            this.MIKTAR.Name = "MIKTAR";
            this.MIKTAR.OptionsColumn.AllowEdit = false;
            this.MIKTAR.OptionsColumn.AllowFocus = false;
            this.MIKTAR.OptionsColumn.FixedWidth = true;
            this.MIKTAR.OptionsColumn.ReadOnly = true;
            this.MIKTAR.Visible = true;
            this.MIKTAR.VisibleIndex = 3;
            // 
            // KOD1
            // 
            this.KOD1.Caption = "KOD1";
            this.KOD1.FieldName = "KOD1";
            this.KOD1.Name = "KOD1";
            this.KOD1.OptionsColumn.AllowEdit = false;
            this.KOD1.OptionsColumn.AllowFocus = false;
            this.KOD1.OptionsColumn.FixedWidth = true;
            this.KOD1.OptionsColumn.ReadOnly = true;
            this.KOD1.Visible = true;
            this.KOD1.VisibleIndex = 4;
            // 
            // KOD2
            // 
            this.KOD2.Caption = "KOD2";
            this.KOD2.FieldName = "KOD2";
            this.KOD2.Name = "KOD2";
            this.KOD2.OptionsColumn.AllowEdit = false;
            this.KOD2.OptionsColumn.AllowFocus = false;
            this.KOD2.OptionsColumn.FixedWidth = true;
            this.KOD2.OptionsColumn.ReadOnly = true;
            this.KOD2.Visible = true;
            this.KOD2.VisibleIndex = 5;
            // 
            // KOD3
            // 
            this.KOD3.Caption = "KOD3";
            this.KOD3.FieldName = "KOD3";
            this.KOD3.Name = "KOD3";
            this.KOD3.OptionsColumn.AllowEdit = false;
            this.KOD3.OptionsColumn.AllowFocus = false;
            this.KOD3.OptionsColumn.FixedWidth = true;
            this.KOD3.OptionsColumn.ReadOnly = true;
            this.KOD3.Visible = true;
            this.KOD3.VisibleIndex = 6;
            // 
            // KOD4
            // 
            this.KOD4.Caption = "KOD4";
            this.KOD4.FieldName = "KOD4";
            this.KOD4.Name = "KOD4";
            this.KOD4.OptionsColumn.AllowEdit = false;
            this.KOD4.OptionsColumn.AllowFocus = false;
            this.KOD4.OptionsColumn.FixedWidth = true;
            this.KOD4.OptionsColumn.ReadOnly = true;
            this.KOD4.Visible = true;
            this.KOD4.VisibleIndex = 7;
            // 
            // KOD5
            // 
            this.KOD5.Caption = "KOD5";
            this.KOD5.FieldName = "KOD5";
            this.KOD5.Name = "KOD5";
            this.KOD5.OptionsColumn.AllowEdit = false;
            this.KOD5.OptionsColumn.AllowFocus = false;
            this.KOD5.OptionsColumn.FixedWidth = true;
            this.KOD5.OptionsColumn.ReadOnly = true;
            this.KOD5.Visible = true;
            this.KOD5.VisibleIndex = 8;
            // 
            // frmStokListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 523);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmStokListesi";
            this.Text = "Stok Listesi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStokListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tp_Arama_Listele)).EndInit();
            this.tp_Arama_Listele.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.SagMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTab.XtraTabControl tp_Arama_Listele;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtKod5;
        private DevExpress.XtraEditors.LabelControl lbl_Kod5_Listele;
        private DevExpress.XtraEditors.TextEdit txtKod4;
        private DevExpress.XtraEditors.LabelControl lbl_Kod4_Listele;
        private DevExpress.XtraEditors.TextEdit txtKod3;
        private DevExpress.XtraEditors.LabelControl lbl_Kod3_Listele;
        private DevExpress.XtraEditors.TextEdit txtKod2;
        private DevExpress.XtraEditors.LabelControl lbl_Kod2_Listele;
        private DevExpress.XtraEditors.TextEdit txtKod1;
        private DevExpress.XtraEditors.LabelControl lbl_Kod1_Listele;
        private DevExpress.XtraEditors.TextEdit txtStokAdi;
        private DevExpress.XtraEditors.LabelControl lbl_Stok_Adı_Listele;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.SimpleButton btnArama;
        private DevExpress.XtraEditors.TextEdit txtStokKodu;
        private DevExpress.XtraEditors.LabelControl lbl_Stok_Kodu_Listele;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn STOKKODU;
        private DevExpress.XtraGrid.Columns.GridColumn STOKADI;
        private DevExpress.XtraGrid.Columns.GridColumn SATISFIYAT1;
        private DevExpress.XtraGrid.Columns.GridColumn MIKTAR;
        private DevExpress.XtraGrid.Columns.GridColumn KOD1;
        private DevExpress.XtraGrid.Columns.GridColumn KOD2;
        private DevExpress.XtraGrid.Columns.GridColumn KOD3;
        private DevExpress.XtraGrid.Columns.GridColumn KOD4;
        private DevExpress.XtraGrid.Columns.GridColumn KOD5;
        private System.Windows.Forms.ContextMenuStrip SagMenu;
        private System.Windows.Forms.ToolStripMenuItem SagEkle;
        private System.Windows.Forms.ToolStripMenuItem SagGuncelle;
        private System.Windows.Forms.ToolStripMenuItem SagSil;
    }
}