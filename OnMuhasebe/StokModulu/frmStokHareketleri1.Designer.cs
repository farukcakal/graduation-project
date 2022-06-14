
namespace OnMuhasebe.StokModulu
{
    partial class frmStokHareketleri1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokHareketleri1));
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
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CARIKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CARIISIM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FATURANO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TARIH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCKOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIRIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CIKIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BRUTFIYAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ISK1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ISK2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BIRIMFIYAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TIPI = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
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
            this.groupControl1.Size = new System.Drawing.Size(1039, 96);
            this.groupControl1.TabIndex = 0;
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
            this.txtStokIsmi.TabIndex = 2;
            // 
            // btn_StokHareket
            // 
            this.btn_StokHareket.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_StokHareket.ImageOptions.Image")));
            this.btn_StokHareket.Location = new System.Drawing.Point(760, 32);
            this.btn_StokHareket.Name = "btn_StokHareket";
            this.btn_StokHareket.Size = new System.Drawing.Size(66, 21);
            this.btn_StokHareket.TabIndex = 1;
            this.btn_StokHareket.Text = "Arama";
            this.btn_StokHareket.Click += new System.EventHandler(this.btn_StokHareket_Click);
            // 
            // txtStokKodu
            // 
            this.txtStokKodu.Location = new System.Drawing.Point(112, 33);
            this.txtStokKodu.Name = "txtStokKodu";
            this.txtStokKodu.ReadOnly = true;
            this.txtStokKodu.Size = new System.Drawing.Size(642, 21);
            this.txtStokKodu.TabIndex = 0;
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
            this.panelControl1.Location = new System.Drawing.Point(0, 810);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1039, 60);
            this.panelControl1.TabIndex = 2;
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
            this.txtBakiye.TextChanged += new System.EventHandler(this.txtBakiye_TextChanged);
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
            // Liste
            // 
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 96);
            this.Liste.MainView = this.gridView1;
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(1039, 714);
            this.Liste.TabIndex = 1;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.CARIKODU,
            this.CARIISIM,
            this.FATURANO,
            this.TARIH,
            this.GCKOD,
            this.GIRIS,
            this.CIKIS,
            this.BRUTFIYAT,
            this.ISK1,
            this.ISK2,
            this.BIRIMFIYAT,
            this.TIPI});
            this.gridView1.GridControl = this.Liste;
            this.gridView1.Name = "gridView1";
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // CARIKODU
            // 
            this.CARIKODU.Caption = "CARIKODU";
            this.CARIKODU.FieldName = "CARIKODU";
            this.CARIKODU.Name = "CARIKODU";
            this.CARIKODU.Visible = true;
            this.CARIKODU.VisibleIndex = 0;
            // 
            // CARIISIM
            // 
            this.CARIISIM.Caption = "CARIISIM";
            this.CARIISIM.FieldName = "CARIISIM";
            this.CARIISIM.Name = "CARIISIM";
            this.CARIISIM.Visible = true;
            this.CARIISIM.VisibleIndex = 1;
            // 
            // FATURANO
            // 
            this.FATURANO.Caption = "FATURANO";
            this.FATURANO.FieldName = "FATURANO";
            this.FATURANO.Name = "FATURANO";
            this.FATURANO.Visible = true;
            this.FATURANO.VisibleIndex = 2;
            // 
            // TARIH
            // 
            this.TARIH.Caption = "TARIH";
            this.TARIH.FieldName = "TARIH";
            this.TARIH.Name = "TARIH";
            this.TARIH.Visible = true;
            this.TARIH.VisibleIndex = 3;
            // 
            // GCKOD
            // 
            this.GCKOD.Caption = "GCKOD";
            this.GCKOD.FieldName = "GCKOD";
            this.GCKOD.Name = "GCKOD";
            this.GCKOD.Visible = true;
            this.GCKOD.VisibleIndex = 4;
            // 
            // GIRIS
            // 
            this.GIRIS.Caption = "GIRIS";
            this.GIRIS.FieldName = "GIRIS";
            this.GIRIS.Name = "GIRIS";
            this.GIRIS.Visible = true;
            this.GIRIS.VisibleIndex = 5;
            // 
            // CIKIS
            // 
            this.CIKIS.Caption = "CIKIS";
            this.CIKIS.FieldName = "CIKIS";
            this.CIKIS.Name = "CIKIS";
            this.CIKIS.Visible = true;
            this.CIKIS.VisibleIndex = 6;
            // 
            // BRUTFIYAT
            // 
            this.BRUTFIYAT.Caption = "BRUTFIYAT";
            this.BRUTFIYAT.FieldName = "BRUTFIYAT";
            this.BRUTFIYAT.Name = "BRUTFIYAT";
            this.BRUTFIYAT.Visible = true;
            this.BRUTFIYAT.VisibleIndex = 7;
            // 
            // ISK1
            // 
            this.ISK1.Caption = "ISK1";
            this.ISK1.FieldName = "ISK1";
            this.ISK1.Name = "ISK1";
            this.ISK1.Visible = true;
            this.ISK1.VisibleIndex = 8;
            // 
            // ISK2
            // 
            this.ISK2.Caption = "ISK2";
            this.ISK2.FieldName = "ISK2";
            this.ISK2.Name = "ISK2";
            this.ISK2.Visible = true;
            this.ISK2.VisibleIndex = 9;
            // 
            // BIRIMFIYAT
            // 
            this.BIRIMFIYAT.Caption = "BIRIMFIYAT";
            this.BIRIMFIYAT.FieldName = "BIRIMFIYAT";
            this.BIRIMFIYAT.Name = "BIRIMFIYAT";
            this.BIRIMFIYAT.Visible = true;
            this.BIRIMFIYAT.VisibleIndex = 10;
            // 
            // TIPI
            // 
            this.TIPI.Caption = "TIPI";
            this.TIPI.FieldName = "TIPI";
            this.TIPI.Name = "TIPI";
            this.TIPI.Visible = true;
            this.TIPI.VisibleIndex = 11;
            // 
            // frmStokHareketleri1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 870);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmStokHareketleri1";
            this.Text = "Stok Hareket Kayıtları";
            this.Load += new System.EventHandler(this.frmStokHareketleri1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn CARIKODU;
        private DevExpress.XtraGrid.Columns.GridColumn CARIISIM;
        private DevExpress.XtraGrid.Columns.GridColumn FATURANO;
        private DevExpress.XtraGrid.Columns.GridColumn TARIH;
        private DevExpress.XtraGrid.Columns.GridColumn GCKOD;
        private DevExpress.XtraGrid.Columns.GridColumn GIRIS;
        private DevExpress.XtraGrid.Columns.GridColumn CIKIS;
        private DevExpress.XtraGrid.Columns.GridColumn BRUTFIYAT;
        private DevExpress.XtraGrid.Columns.GridColumn ISK1;
        private DevExpress.XtraGrid.Columns.GridColumn ISK2;
        private DevExpress.XtraGrid.Columns.GridColumn BIRIMFIYAT;
        private DevExpress.XtraGrid.Columns.GridColumn TIPI;
    }
}