
namespace OnMuhasebe.StokModulu
{
    partial class frmStokHareketleri
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokHareketleri));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            this.GIRIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CARIKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CARIADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FATURANO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TARIH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CIKIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BRUTFIYAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ISK1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ISK2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BIRIMFIYAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TIPI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblStokKodu = new System.Windows.Forms.Label();
            this.txtStokIsmi = new System.Windows.Forms.TextBox();
            this.btn_StokHareket = new DevExpress.XtraEditors.SimpleButton();
            this.txtStokKodu = new System.Windows.Forms.TextBox();
            this.lblStokIsmi = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.txtToplamCikis = new System.Windows.Forms.TextBox();
            this.txtToplamGiris = new System.Windows.Forms.TextBox();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CARİKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CARIADI1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // GIRIS
            // 
            this.GIRIS.Caption = "GİRİŞ";
            this.GIRIS.FieldName = "GIRIS";
            this.GIRIS.Name = "GIRIS";
            this.GIRIS.OptionsColumn.AllowEdit = false;
            this.GIRIS.OptionsColumn.AllowFocus = false;
            this.GIRIS.OptionsColumn.FixedWidth = true;
            this.GIRIS.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "GİRİŞ";
            this.gridColumn6.FieldName = "GIRIS";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.AllowFocus = false;
            this.gridColumn6.OptionsColumn.FixedWidth = true;
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // Liste
            // 
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 100);
            this.Liste.MainView = this.gridView1;
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(1273, 687);
            this.Liste.TabIndex = 7;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.CARIKODU,
            this.CARIADI,
            this.FATURANO,
            this.TARIH,
            this.GCKODU,
            this.GIRIS,
            this.CIKIS,
            this.BRUTFIYAT,
            this.ISK1,
            this.ISK2,
            this.BIRIMFIYAT,
            this.TIPI});
            gridFormatRule1.Column = this.GIRIS;
            gridFormatRule1.Name = "Format0";
            gridFormatRule1.Rule = null;
            this.gridView1.FormatRules.Add(gridFormatRule1);
            this.gridView1.GridControl = this.Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            this.CARIKODU.FieldName = "CARİKODU";
            this.CARIKODU.Name = "CARIKODU";
            this.CARIKODU.OptionsColumn.AllowEdit = false;
            this.CARIKODU.OptionsColumn.AllowFocus = false;
            this.CARIKODU.OptionsColumn.FixedWidth = true;
            this.CARIKODU.OptionsColumn.ReadOnly = true;
            // 
            // CARIADI
            // 
            this.CARIADI.Caption = "CARİ ADI";
            this.CARIADI.FieldName = "CARIADI";
            this.CARIADI.Name = "CARIADI";
            this.CARIADI.OptionsColumn.AllowEdit = false;
            this.CARIADI.OptionsColumn.AllowFocus = false;
            this.CARIADI.OptionsColumn.FixedWidth = true;
            this.CARIADI.OptionsColumn.ReadOnly = true;
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
            // 
            // GCKODU
            // 
            this.GCKODU.Caption = "GC KODU";
            this.GCKODU.FieldName = "GCKODU";
            this.GCKODU.Name = "GCKODU";
            this.GCKODU.OptionsColumn.AllowEdit = false;
            this.GCKODU.OptionsColumn.AllowFocus = false;
            this.GCKODU.OptionsColumn.FixedWidth = true;
            this.GCKODU.OptionsColumn.ReadOnly = true;
            // 
            // CIKIS
            // 
            this.CIKIS.Caption = "ÇIKIŞ";
            this.CIKIS.FieldName = "CIKIS";
            this.CIKIS.Name = "CIKIS";
            this.CIKIS.OptionsColumn.AllowEdit = false;
            this.CIKIS.OptionsColumn.AllowFocus = false;
            this.CIKIS.OptionsColumn.FixedWidth = true;
            this.CIKIS.OptionsColumn.ReadOnly = true;
            // 
            // BRUTFIYAT
            // 
            this.BRUTFIYAT.Caption = "BRÜT FİYAT";
            this.BRUTFIYAT.FieldName = "BRUTFIYAT";
            this.BRUTFIYAT.Name = "BRUTFIYAT";
            this.BRUTFIYAT.OptionsColumn.AllowEdit = false;
            this.BRUTFIYAT.OptionsColumn.AllowFocus = false;
            this.BRUTFIYAT.OptionsColumn.FixedWidth = true;
            this.BRUTFIYAT.OptionsColumn.ReadOnly = true;
            // 
            // ISK1
            // 
            this.ISK1.Caption = "İSK 1 (%)";
            this.ISK1.FieldName = "ISK1";
            this.ISK1.Name = "ISK1";
            this.ISK1.OptionsColumn.AllowEdit = false;
            this.ISK1.OptionsColumn.AllowFocus = false;
            this.ISK1.OptionsColumn.FixedWidth = true;
            this.ISK1.OptionsColumn.ReadOnly = true;
            // 
            // ISK2
            // 
            this.ISK2.Caption = "İSK 2 (%)";
            this.ISK2.FieldName = "ISK2";
            this.ISK2.Name = "ISK2";
            this.ISK2.OptionsColumn.AllowEdit = false;
            this.ISK2.OptionsColumn.AllowFocus = false;
            this.ISK2.OptionsColumn.FixedWidth = true;
            // 
            // BIRIMFIYAT
            // 
            this.BIRIMFIYAT.Caption = "BİRİM FİYAT";
            this.BIRIMFIYAT.FieldName = "BIRIMFIYAT";
            this.BIRIMFIYAT.Name = "BIRIMFIYAT";
            this.BIRIMFIYAT.OptionsColumn.AllowEdit = false;
            this.BIRIMFIYAT.OptionsColumn.AllowFocus = false;
            this.BIRIMFIYAT.OptionsColumn.FixedWidth = true;
            // 
            // TIPI
            // 
            this.TIPI.Caption = "TİPİ";
            this.TIPI.FieldName = "TIPI";
            this.TIPI.Name = "TIPI";
            this.TIPI.OptionsColumn.AllowEdit = false;
            this.TIPI.OptionsColumn.AllowFocus = false;
            this.TIPI.OptionsColumn.FixedWidth = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblStokKodu);
            this.groupControl1.Controls.Add(this.txtStokIsmi);
            this.groupControl1.Controls.Add(this.btn_StokHareket);
            this.groupControl1.Controls.Add(this.txtStokKodu);
            this.groupControl1.Controls.Add(this.lblStokIsmi);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1273, 100);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Stok Bilgileri";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // lblStokKodu
            // 
            this.lblStokKodu.AutoSize = true;
            this.lblStokKodu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStokKodu.Location = new System.Drawing.Point(12, 31);
            this.lblStokKodu.Name = "lblStokKodu";
            this.lblStokKodu.Size = new System.Drawing.Size(92, 21);
            this.lblStokKodu.TabIndex = 0;
            this.lblStokKodu.Text = "Stok Kodu";
            // 
            // txtStokIsmi
            // 
            this.txtStokIsmi.Location = new System.Drawing.Point(112, 60);
            this.txtStokIsmi.Name = "txtStokIsmi";
            this.txtStokIsmi.ReadOnly = true;
            this.txtStokIsmi.Size = new System.Drawing.Size(714, 21);
            this.txtStokIsmi.TabIndex = 1;
            // 
            // btn_StokHareket
            // 
            this.btn_StokHareket.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_StokHareket.ImageOptions.Image")));
            this.btn_StokHareket.Location = new System.Drawing.Point(760, 32);
            this.btn_StokHareket.Name = "btn_StokHareket";
            this.btn_StokHareket.Size = new System.Drawing.Size(66, 21);
            this.btn_StokHareket.TabIndex = 2;
            this.btn_StokHareket.Text = "Arama";
            this.btn_StokHareket.Click += new System.EventHandler(this.btn_StokHareket_Click);
            // 
            // txtStokKodu
            // 
            this.txtStokKodu.Location = new System.Drawing.Point(112, 33);
            this.txtStokKodu.Name = "txtStokKodu";
            this.txtStokKodu.ReadOnly = true;
            this.txtStokKodu.Size = new System.Drawing.Size(642, 21);
            this.txtStokKodu.TabIndex = 1;
            // 
            // lblStokIsmi
            // 
            this.lblStokIsmi.AutoSize = true;
            this.lblStokIsmi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStokIsmi.Location = new System.Drawing.Point(12, 58);
            this.lblStokIsmi.Name = "lblStokIsmi";
            this.lblStokIsmi.Size = new System.Drawing.Size(82, 21);
            this.lblStokIsmi.TabIndex = 0;
            this.lblStokIsmi.Text = "Stok İsmi";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.txtBakiye);
            this.panelControl1.Controls.Add(this.txtToplamCikis);
            this.panelControl1.Controls.Add(this.txtToplamGiris);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 738);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1273, 49);
            this.panelControl1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(574, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bakiye";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(293, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Toplam Çıkış";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Toplam Giriş";
            // 
            // txtBakiye
            // 
            this.txtBakiye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtBakiye.Location = new System.Drawing.Point(650, 16);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Size = new System.Drawing.Size(118, 21);
            this.txtBakiye.TabIndex = 1;
            // 
            // txtToplamCikis
            // 
            this.txtToplamCikis.Location = new System.Drawing.Point(418, 16);
            this.txtToplamCikis.Name = "txtToplamCikis";
            this.txtToplamCikis.Size = new System.Drawing.Size(118, 21);
            this.txtToplamCikis.TabIndex = 1;
            // 
            // txtToplamGiris
            // 
            this.txtToplamGiris.Location = new System.Drawing.Point(135, 16);
            this.txtToplamGiris.Name = "txtToplamGiris";
            this.txtToplamGiris.Size = new System.Drawing.Size(118, 21);
            this.txtToplamGiris.TabIndex = 1;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.CARİKODU,
            this.CARIADI1,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12});
            gridFormatRule2.Column = this.gridColumn6;
            gridFormatRule2.Name = "Format0";
            gridFormatRule2.Rule = null;
            this.gridView2.FormatRules.Add(gridFormatRule2);
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.OptionsColumn.AllowShowHide = false;
            this.gridColumn1.OptionsColumn.FixedWidth = true;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            // 
            // CARİKODU
            // 
            this.CARİKODU.Caption = "CARİ KODU";
            this.CARİKODU.FieldName = "CARIKODU";
            this.CARİKODU.Name = "CARİKODU";
            this.CARİKODU.OptionsColumn.AllowEdit = false;
            this.CARİKODU.OptionsColumn.AllowFocus = false;
            this.CARİKODU.OptionsColumn.FixedWidth = true;
            this.CARİKODU.OptionsColumn.ReadOnly = true;
            this.CARİKODU.Visible = true;
            this.CARİKODU.VisibleIndex = 0;
            // 
            // CARIADI1
            // 
            this.CARIADI1.Caption = "CARİ ADI";
            this.CARIADI1.FieldName = "CARIADI";
            this.CARIADI1.Name = "CARIADI1";
            this.CARIADI1.OptionsColumn.AllowEdit = false;
            this.CARIADI1.OptionsColumn.AllowFocus = false;
            this.CARIADI1.OptionsColumn.ReadOnly = true;
            this.CARIADI1.Visible = true;
            this.CARIADI1.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "FATURA NO";
            this.gridColumn3.FieldName = "FATURANO";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.OptionsColumn.FixedWidth = true;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "TARİH";
            this.gridColumn4.FieldName = "TARIH";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.OptionsColumn.FixedWidth = true;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "GC KODU";
            this.gridColumn5.FieldName = "GCKODU";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowFocus = false;
            this.gridColumn5.OptionsColumn.FixedWidth = true;
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "ÇIKIŞ";
            this.gridColumn7.FieldName = "CIKIS";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.OptionsColumn.AllowFocus = false;
            this.gridColumn7.OptionsColumn.FixedWidth = true;
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "BRÜT FİYAT";
            this.gridColumn8.FieldName = "BRUTFIYAT";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.OptionsColumn.AllowFocus = false;
            this.gridColumn8.OptionsColumn.FixedWidth = true;
            this.gridColumn8.OptionsColumn.ReadOnly = true;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "İSK 1 (%)";
            this.gridColumn9.FieldName = "ISK1";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.OptionsColumn.AllowFocus = false;
            this.gridColumn9.OptionsColumn.FixedWidth = true;
            this.gridColumn9.OptionsColumn.ReadOnly = true;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "İSK 2 (%)";
            this.gridColumn10.FieldName = "ISK2";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.OptionsColumn.AllowFocus = false;
            this.gridColumn10.OptionsColumn.ReadOnly = true;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 9;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "BİRİM FİYAT";
            this.gridColumn11.FieldName = "BIRIMFIYAT";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.OptionsColumn.AllowFocus = false;
            this.gridColumn11.OptionsColumn.ReadOnly = true;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 10;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "TİPİ";
            this.gridColumn12.FieldName = "TIPI";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.AllowEdit = false;
            this.gridColumn12.OptionsColumn.AllowFocus = false;
            this.gridColumn12.OptionsColumn.ReadOnly = true;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 11;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 100);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1273, 638);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // frmStokHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 787);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmStokHareketleri";
            this.Text = "Stok Hareket Kayıtları";
            this.Load += new System.EventHandler(this.frmStokHareketleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn CARIKODU;
        private DevExpress.XtraGrid.Columns.GridColumn CARIADI;
        private DevExpress.XtraGrid.Columns.GridColumn FATURANO;
        private DevExpress.XtraGrid.Columns.GridColumn TARIH;
        private DevExpress.XtraGrid.Columns.GridColumn GCKODU;
        private DevExpress.XtraGrid.Columns.GridColumn GIRIS;
        private DevExpress.XtraGrid.Columns.GridColumn CIKIS;
        private DevExpress.XtraGrid.Columns.GridColumn BRUTFIYAT;
        private DevExpress.XtraGrid.Columns.GridColumn ISK1;
        private DevExpress.XtraGrid.Columns.GridColumn ISK2;
        private DevExpress.XtraGrid.Columns.GridColumn BIRIMFIYAT;
        private DevExpress.XtraGrid.Columns.GridColumn TIPI;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label lblStokKodu;
        private System.Windows.Forms.TextBox txtStokIsmi;
        private DevExpress.XtraEditors.SimpleButton btn_StokHareket;
        private System.Windows.Forms.TextBox txtStokKodu;
        private System.Windows.Forms.Label lblStokIsmi;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.TextBox txtToplamCikis;
        private System.Windows.Forms.TextBox txtToplamGiris;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn CARİKODU;
        private DevExpress.XtraGrid.Columns.GridColumn CARIADI1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.GridControl gridControl1;
    }
}