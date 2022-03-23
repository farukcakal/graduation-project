
namespace OnMuhasebe.StokModulu
{
    partial class StokHareketKayıtları
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CARİKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CARIADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FATURANO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TARIH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIRIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CIKIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BRUTFIYAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ISK1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ISK2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BIRIMFIYAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TIPI = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stok Kodu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Stok İsmi";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(603, 21);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(714, 21);
            this.textBox2.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = global::OnMuhasebe.Properties.Resources.lookup_reference_32x32;
            this.simpleButton1.Location = new System.Drawing.Point(721, 33);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(105, 39);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Arama";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.textBox2);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.textBox1);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1215, 119);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Stok Bilgileri";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 119);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1215, 643);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.CARİKODU,
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
            this.gridView1.GridControl = this.gridControl1;
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
            this.ID.Visible = true;
            this.ID.VisibleIndex = 9;
            // 
            // CARİKODU
            // 
            this.CARİKODU.Caption = "CARİ KODU";
            this.CARİKODU.FieldName = "CARİKODU";
            this.CARİKODU.Name = "CARİKODU";
            this.CARİKODU.OptionsColumn.AllowEdit = false;
            this.CARİKODU.OptionsColumn.AllowFocus = false;
            this.CARİKODU.OptionsColumn.FixedWidth = true;
            this.CARİKODU.OptionsColumn.ReadOnly = true;
            this.CARİKODU.Visible = true;
            this.CARİKODU.VisibleIndex = 0;
            // 
            // CARIADI
            // 
            this.CARIADI.Caption = "CARİ ADI";
            this.CARIADI.FieldName = "CARIADI";
            this.CARIADI.Name = "CARIADI";
            this.CARIADI.OptionsColumn.AllowEdit = false;
            this.CARIADI.OptionsColumn.AllowFocus = false;
            this.CARIADI.OptionsColumn.ReadOnly = true;
            this.CARIADI.Visible = true;
            this.CARIADI.VisibleIndex = 1;
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
            // GCKODU
            // 
            this.GCKODU.Caption = "GC KODU";
            this.GCKODU.FieldName = "GCKODU";
            this.GCKODU.Name = "GCKODU";
            this.GCKODU.OptionsColumn.AllowEdit = false;
            this.GCKODU.OptionsColumn.AllowFocus = false;
            this.GCKODU.OptionsColumn.FixedWidth = true;
            this.GCKODU.OptionsColumn.ReadOnly = true;
            this.GCKODU.Visible = true;
            this.GCKODU.VisibleIndex = 4;
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
            this.GIRIS.Visible = true;
            this.GIRIS.VisibleIndex = 5;
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
            this.CIKIS.Visible = true;
            this.CIKIS.VisibleIndex = 6;
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
            this.BRUTFIYAT.Visible = true;
            this.BRUTFIYAT.VisibleIndex = 7;
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
            this.ISK1.Visible = true;
            this.ISK1.VisibleIndex = 8;
            // 
            // ISK2
            // 
            this.ISK2.Caption = "İSK 2 (%)";
            this.ISK2.FieldName = "ISK2";
            this.ISK2.Name = "ISK2";
            this.ISK2.Visible = true;
            this.ISK2.VisibleIndex = 10;
            // 
            // BIRIMFIYAT
            // 
            this.BIRIMFIYAT.Caption = "BİRİM FİYAT";
            this.BIRIMFIYAT.FieldName = "BIRIMFIYAT";
            this.BIRIMFIYAT.Name = "BIRIMFIYAT";
            this.BIRIMFIYAT.Visible = true;
            this.BIRIMFIYAT.VisibleIndex = 11;
            // 
            // TIPI
            // 
            this.TIPI.Caption = "TİPİ";
            this.TIPI.FieldName = "TIPI";
            this.TIPI.Name = "TIPI";
            this.TIPI.Visible = true;
            this.TIPI.VisibleIndex = 12;
            // 
            // StokHareketKayıtları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 762);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "StokHareketKayıtları";
            this.Text = "StokHareketKayıtları";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn CARİKODU;
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
    }
}