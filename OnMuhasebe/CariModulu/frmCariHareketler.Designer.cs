
namespace OnMuhasebe.CariModulu
{
    partial class frmCariHareketler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCariHareketler));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lbl_Cari_Kodu_Hareket = new System.Windows.Forms.Label();
            this.txtCariIsim = new System.Windows.Forms.TextBox();
            this.btn_Carihareket = new DevExpress.XtraEditors.SimpleButton();
            this.txtCariKodu = new System.Windows.Forms.TextBox();
            this.lbl_Cari_Ismi_Hareket = new System.Windows.Forms.Label();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CARIKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BELGENO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TARIH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BORC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ALACAK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VADETARIHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TIPI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BAKIYE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.txtToplamBorc = new System.Windows.Forms.TextBox();
            this.txtToplamAlacak = new System.Windows.Forms.TextBox();
            this.txtIlkTarih = new DevExpress.XtraEditors.DateEdit();
            this.txtSonTarih = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTarihListele = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIlkTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIlkTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSonTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSonTarih.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnTarihListele);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtSonTarih);
            this.groupControl1.Controls.Add(this.txtIlkTarih);
            this.groupControl1.Controls.Add(this.lbl_Cari_Kodu_Hareket);
            this.groupControl1.Controls.Add(this.txtCariIsim);
            this.groupControl1.Controls.Add(this.btn_Carihareket);
            this.groupControl1.Controls.Add(this.txtCariKodu);
            this.groupControl1.Controls.Add(this.lbl_Cari_Ismi_Hareket);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1294, 100);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Stok Bilgileri";
            // 
            // lbl_Cari_Kodu_Hareket
            // 
            this.lbl_Cari_Kodu_Hareket.AutoSize = true;
            this.lbl_Cari_Kodu_Hareket.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Cari_Kodu_Hareket.Location = new System.Drawing.Point(12, 31);
            this.lbl_Cari_Kodu_Hareket.Name = "lbl_Cari_Kodu_Hareket";
            this.lbl_Cari_Kodu_Hareket.Size = new System.Drawing.Size(88, 21);
            this.lbl_Cari_Kodu_Hareket.TabIndex = 0;
            this.lbl_Cari_Kodu_Hareket.Text = "Cari Kodu";
            // 
            // txtCariIsim
            // 
            this.txtCariIsim.Location = new System.Drawing.Point(112, 60);
            this.txtCariIsim.Name = "txtCariIsim";
            this.txtCariIsim.ReadOnly = true;
            this.txtCariIsim.Size = new System.Drawing.Size(714, 21);
            this.txtCariIsim.TabIndex = 2;
            // 
            // btn_Carihareket
            // 
            this.btn_Carihareket.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Carihareket.ImageOptions.Image")));
            this.btn_Carihareket.Location = new System.Drawing.Point(760, 32);
            this.btn_Carihareket.Name = "btn_Carihareket";
            this.btn_Carihareket.Size = new System.Drawing.Size(66, 21);
            this.btn_Carihareket.TabIndex = 1;
            this.btn_Carihareket.Text = "Arama";
            this.btn_Carihareket.Click += new System.EventHandler(this.btn_Carihareket_Click);
            // 
            // txtCariKodu
            // 
            this.txtCariKodu.Location = new System.Drawing.Point(112, 33);
            this.txtCariKodu.Name = "txtCariKodu";
            this.txtCariKodu.ReadOnly = true;
            this.txtCariKodu.Size = new System.Drawing.Size(642, 21);
            this.txtCariKodu.TabIndex = 0;
            // 
            // lbl_Cari_Ismi_Hareket
            // 
            this.lbl_Cari_Ismi_Hareket.AutoSize = true;
            this.lbl_Cari_Ismi_Hareket.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Cari_Ismi_Hareket.Location = new System.Drawing.Point(12, 58);
            this.lbl_Cari_Ismi_Hareket.Name = "lbl_Cari_Ismi_Hareket";
            this.lbl_Cari_Ismi_Hareket.Size = new System.Drawing.Size(78, 21);
            this.lbl_Cari_Ismi_Hareket.TabIndex = 0;
            this.lbl_Cari_Ismi_Hareket.Text = "Cari İsmi";
            // 
            // Liste
            // 
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 100);
            this.Liste.MainView = this.gridView1;
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(1294, 637);
            this.Liste.TabIndex = 0;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.CARIKODU,
            this.BELGENO,
            this.TARIH,
            this.BORC,
            this.ALACAK,
            this.ACIKLAMA,
            this.VADETARIHI,
            this.TIPI,
            this.BAKIYE});
            gridFormatRule2.Name = "Format0";
            gridFormatRule2.Rule = null;
            this.gridView1.FormatRules.Add(gridFormatRule2);
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
            // BELGENO
            // 
            this.BELGENO.Caption = "BELGENO";
            this.BELGENO.FieldName = "BELGENO";
            this.BELGENO.Name = "BELGENO";
            this.BELGENO.OptionsColumn.AllowEdit = false;
            this.BELGENO.OptionsColumn.AllowFocus = false;
            this.BELGENO.OptionsColumn.FixedWidth = true;
            this.BELGENO.OptionsColumn.ReadOnly = true;
            this.BELGENO.Visible = true;
            this.BELGENO.VisibleIndex = 1;
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
            this.TARIH.VisibleIndex = 2;
            // 
            // BORC
            // 
            this.BORC.Caption = "BORC";
            this.BORC.FieldName = "BORC";
            this.BORC.Name = "BORC";
            this.BORC.OptionsColumn.AllowEdit = false;
            this.BORC.OptionsColumn.AllowFocus = false;
            this.BORC.OptionsColumn.FixedWidth = true;
            this.BORC.OptionsColumn.ReadOnly = true;
            this.BORC.Visible = true;
            this.BORC.VisibleIndex = 3;
            // 
            // ALACAK
            // 
            this.ALACAK.Caption = "ALACAK";
            this.ALACAK.FieldName = "ALACAK";
            this.ALACAK.Name = "ALACAK";
            this.ALACAK.OptionsColumn.AllowEdit = false;
            this.ALACAK.OptionsColumn.AllowFocus = false;
            this.ALACAK.OptionsColumn.FixedWidth = true;
            this.ALACAK.OptionsColumn.ReadOnly = true;
            this.ALACAK.Visible = true;
            this.ALACAK.VisibleIndex = 4;
            // 
            // ACIKLAMA
            // 
            this.ACIKLAMA.Caption = "ACIKLAMA";
            this.ACIKLAMA.FieldName = "ACIKLAMA";
            this.ACIKLAMA.Name = "ACIKLAMA";
            this.ACIKLAMA.Visible = true;
            this.ACIKLAMA.VisibleIndex = 5;
            // 
            // VADETARIHI
            // 
            this.VADETARIHI.Caption = "VADETARIHI";
            this.VADETARIHI.FieldName = "VADETARIHI";
            this.VADETARIHI.Name = "VADETARIHI";
            this.VADETARIHI.Visible = true;
            this.VADETARIHI.VisibleIndex = 6;
            // 
            // TIPI
            // 
            this.TIPI.Caption = "TİPİ";
            this.TIPI.FieldName = "TIPI";
            this.TIPI.Name = "TIPI";
            this.TIPI.Visible = true;
            this.TIPI.VisibleIndex = 7;
            // 
            // BAKIYE
            // 
            this.BAKIYE.Caption = "BAKIYE";
            this.BAKIYE.FieldName = "BAKIYE";
            this.BAKIYE.Name = "BAKIYE";
            this.BAKIYE.Visible = true;
            this.BAKIYE.VisibleIndex = 8;
            this.BAKIYE.Width = 64;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.txtBakiye);
            this.panelControl1.Controls.Add(this.txtToplamBorc);
            this.panelControl1.Controls.Add(this.txtToplamAlacak);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 688);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1294, 49);
            this.panelControl1.TabIndex = 6;
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
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Toplam Borc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Toplam Alacak";
            // 
            // txtBakiye
            // 
            this.txtBakiye.BackColor = System.Drawing.Color.White;
            this.txtBakiye.Location = new System.Drawing.Point(672, 16);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Size = new System.Drawing.Size(118, 21);
            this.txtBakiye.TabIndex = 1;
            // 
            // txtToplamBorc
            // 
            this.txtToplamBorc.Location = new System.Drawing.Point(418, 21);
            this.txtToplamBorc.Name = "txtToplamBorc";
            this.txtToplamBorc.Size = new System.Drawing.Size(118, 21);
            this.txtToplamBorc.TabIndex = 1;
            // 
            // txtToplamAlacak
            // 
            this.txtToplamAlacak.Location = new System.Drawing.Point(153, 20);
            this.txtToplamAlacak.Name = "txtToplamAlacak";
            this.txtToplamAlacak.Size = new System.Drawing.Size(118, 21);
            this.txtToplamAlacak.TabIndex = 1;
            // 
            // txtIlkTarih
            // 
            this.txtIlkTarih.EditValue = null;
            this.txtIlkTarih.Location = new System.Drawing.Point(1050, 33);
            this.txtIlkTarih.Name = "txtIlkTarih";
            this.txtIlkTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtIlkTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtIlkTarih.Size = new System.Drawing.Size(136, 20);
            this.txtIlkTarih.TabIndex = 3;
            // 
            // txtSonTarih
            // 
            this.txtSonTarih.EditValue = null;
            this.txtSonTarih.Location = new System.Drawing.Point(1049, 59);
            this.txtSonTarih.Name = "txtSonTarih";
            this.txtSonTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSonTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSonTarih.Size = new System.Drawing.Size(136, 20);
            this.txtSonTarih.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(991, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "İlk Tarih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(991, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Son Tarih";
            // 
            // btnTarihListele
            // 
            this.btnTarihListele.Location = new System.Drawing.Point(1192, 32);
            this.btnTarihListele.Name = "btnTarihListele";
            this.btnTarihListele.Size = new System.Drawing.Size(90, 47);
            this.btnTarihListele.TabIndex = 5;
            this.btnTarihListele.Text = "Listele";
            this.btnTarihListele.Click += new System.EventHandler(this.btnTarihListele_Click);
            // 
            // frmCariHareketler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 737);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.ShowIcon = false;
            this.Name = "frmCariHareketler";
            this.Text = "Cari Hareket Kayıtları";
            this.Load += new System.EventHandler(this.CariHareketKayıtları_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIlkTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIlkTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSonTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSonTarih.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label lbl_Cari_Kodu_Hareket;
        private System.Windows.Forms.TextBox txtCariIsim;
        private DevExpress.XtraEditors.SimpleButton btn_Carihareket;
        private System.Windows.Forms.TextBox txtCariKodu;
        private System.Windows.Forms.Label lbl_Cari_Ismi_Hareket;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn CARIKODU;
        private DevExpress.XtraGrid.Columns.GridColumn BELGENO;
        private DevExpress.XtraGrid.Columns.GridColumn TARIH;
        private DevExpress.XtraGrid.Columns.GridColumn BORC;
        private DevExpress.XtraGrid.Columns.GridColumn ALACAK;
        private DevExpress.XtraGrid.Columns.GridColumn ACIKLAMA;
        private DevExpress.XtraGrid.Columns.GridColumn VADETARIHI;
        private DevExpress.XtraGrid.Columns.GridColumn TIPI;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.TextBox txtToplamBorc;
        private System.Windows.Forms.TextBox txtToplamAlacak;
        private DevExpress.XtraGrid.Columns.GridColumn BAKIYE;
        private DevExpress.XtraEditors.SimpleButton btnTarihListele;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit txtSonTarih;
        private DevExpress.XtraEditors.DateEdit txtIlkTarih;
    }
}