
namespace OnMuhasebe.StokModulu
{
    partial class frmStokAcilisKarti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokAcilisKarti));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeni = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.radioCikis = new System.Windows.Forms.RadioButton();
            this.radioGiris = new System.Windows.Forms.RadioButton();
            this.btnStokSec = new DevExpress.XtraEditors.SimpleButton();
            this.lblTarih = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.txtTarih = new DevExpress.XtraEditors.DateEdit();
            this.txtBelgeNo = new DevExpress.XtraEditors.TextEdit();
            this.txtMiktar = new DevExpress.XtraEditors.TextEdit();
            this.lblStokKodu = new System.Windows.Forms.Label();
            this.txtStokIsmi = new System.Windows.Forms.TextBox();
            this.txtStokKodu = new System.Windows.Forms.TextBox();
            this.lblStokIsmi = new System.Windows.Forms.Label();
            this.txtStokFiyat = new DevExpress.XtraEditors.TextEdit();
            this.lblFiyat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelgeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokFiyat.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnKaydet);
            this.panelControl2.Controls.Add(this.btnYeni);
            this.panelControl2.Controls.Add(this.btnKapat);
            this.panelControl2.Controls.Add(this.btnSil);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 226);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(466, 48);
            this.panelControl2.TabIndex = 7;
            // 
            // btnKaydet
            // 
            this.btnKaydet.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKaydet.ImageOptions.Image = global::OnMuhasebe.Properties.Resources.save_16x16;
            this.btnKaydet.Location = new System.Drawing.Point(213, 13);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.ImageOptions.Image = global::OnMuhasebe.Properties.Resources.addnewdatasource_16x16;
            this.btnYeni.Location = new System.Drawing.Point(132, 13);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(75, 23);
            this.btnYeni.TabIndex = 0;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.ImageOptions.Image = global::OnMuhasebe.Properties.Resources.cancel_16x161;
            this.btnKapat.Location = new System.Drawing.Point(375, 13);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 23);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = global::OnMuhasebe.Properties.Resources.deletedatasource2_16x16;
            this.btnSil.Location = new System.Drawing.Point(294, 13);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // radioCikis
            // 
            this.radioCikis.AutoSize = true;
            this.radioCikis.Location = new System.Drawing.Point(230, 191);
            this.radioCikis.Name = "radioCikis";
            this.radioCikis.Size = new System.Drawing.Size(80, 17);
            this.radioCikis.TabIndex = 6;
            this.radioCikis.Text = "Çıkış Miktarı";
            this.radioCikis.UseVisualStyleBackColor = true;
            // 
            // radioGiris
            // 
            this.radioGiris.AutoSize = true;
            this.radioGiris.Checked = true;
            this.radioGiris.Location = new System.Drawing.Point(127, 191);
            this.radioGiris.Name = "radioGiris";
            this.radioGiris.Size = new System.Drawing.Size(79, 17);
            this.radioGiris.TabIndex = 5;
            this.radioGiris.TabStop = true;
            this.radioGiris.Text = "Giriş Miktarı";
            this.radioGiris.UseVisualStyleBackColor = true;
            // 
            // btnStokSec
            // 
            this.btnStokSec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStokSec.ImageOptions.Image")));
            this.btnStokSec.Location = new System.Drawing.Point(387, 41);
            this.btnStokSec.Name = "btnStokSec";
            this.btnStokSec.Size = new System.Drawing.Size(45, 31);
            this.btnStokSec.TabIndex = 1;
            this.btnStokSec.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(15, 105);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(31, 13);
            this.lblTarih.TabIndex = 27;
            this.lblTarih.Text = "Tarih";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Belge No";
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(14, 131);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(36, 13);
            this.lblMiktar.TabIndex = 26;
            this.lblMiktar.Text = "Miktar";
            // 
            // txtTarih
            // 
            this.txtTarih.EditValue = null;
            this.txtTarih.Location = new System.Drawing.Point(124, 98);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Size = new System.Drawing.Size(190, 20);
            this.txtTarih.TabIndex = 2;
            // 
            // txtBelgeNo
            // 
            this.txtBelgeNo.Location = new System.Drawing.Point(124, 13);
            this.txtBelgeNo.Name = "txtBelgeNo";
            this.txtBelgeNo.Size = new System.Drawing.Size(190, 20);
            this.txtBelgeNo.TabIndex = 0;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(124, 124);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(190, 20);
            this.txtMiktar.TabIndex = 3;
            // 
            // lblStokKodu
            // 
            this.lblStokKodu.AutoSize = true;
            this.lblStokKodu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStokKodu.Location = new System.Drawing.Point(15, 49);
            this.lblStokKodu.Name = "lblStokKodu";
            this.lblStokKodu.Size = new System.Drawing.Size(55, 13);
            this.lblStokKodu.TabIndex = 16;
            this.lblStokKodu.Text = "Stok Kodu";
            // 
            // txtStokIsmi
            // 
            this.txtStokIsmi.Location = new System.Drawing.Point(124, 68);
            this.txtStokIsmi.Name = "txtStokIsmi";
            this.txtStokIsmi.ReadOnly = true;
            this.txtStokIsmi.Size = new System.Drawing.Size(257, 21);
            this.txtStokIsmi.TabIndex = 14;
            // 
            // txtStokKodu
            // 
            this.txtStokKodu.Location = new System.Drawing.Point(124, 41);
            this.txtStokKodu.Name = "txtStokKodu";
            this.txtStokKodu.ReadOnly = true;
            this.txtStokKodu.Size = new System.Drawing.Size(257, 21);
            this.txtStokKodu.TabIndex = 12;
            // 
            // lblStokIsmi
            // 
            this.lblStokIsmi.AutoSize = true;
            this.lblStokIsmi.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStokIsmi.Location = new System.Drawing.Point(15, 76);
            this.lblStokIsmi.Name = "lblStokIsmi";
            this.lblStokIsmi.Size = new System.Drawing.Size(50, 13);
            this.lblStokIsmi.TabIndex = 18;
            this.lblStokIsmi.Text = "Stok İsmi";
            this.lblStokIsmi.Click += new System.EventHandler(this.lbl_Cari_Ismi_Hareket_Click);
            // 
            // txtStokFiyat
            // 
            this.txtStokFiyat.Location = new System.Drawing.Point(125, 156);
            this.txtStokFiyat.Name = "txtStokFiyat";
            this.txtStokFiyat.Size = new System.Drawing.Size(190, 20);
            this.txtStokFiyat.TabIndex = 4;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(15, 163);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(31, 13);
            this.lblFiyat.TabIndex = 26;
            this.lblFiyat.Text = "Fiyat";
            // 
            // frmStokAcilisKarti
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnKaydet;
            this.ClientSize = new System.Drawing.Size(466, 274);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.radioCikis);
            this.Controls.Add(this.radioGiris);
            this.Controls.Add(this.btnStokSec);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.txtStokFiyat);
            this.Controls.Add(this.txtBelgeNo);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.lblStokKodu);
            this.Controls.Add(this.txtStokIsmi);
            this.Controls.Add(this.txtStokKodu);
            this.Controls.Add(this.lblStokIsmi);
            this.Name = "frmStokAcilisKarti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Açılış Kartı";
            this.Load += new System.EventHandler(this.frmStokAcilisKarti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelgeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokFiyat.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnYeni;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private System.Windows.Forms.RadioButton radioCikis;
        private System.Windows.Forms.RadioButton radioGiris;
        private DevExpress.XtraEditors.SimpleButton btnStokSec;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMiktar;
        private DevExpress.XtraEditors.DateEdit txtTarih;
        private DevExpress.XtraEditors.TextEdit txtBelgeNo;
        private DevExpress.XtraEditors.TextEdit txtMiktar;
        private System.Windows.Forms.Label lblStokKodu;
        private System.Windows.Forms.TextBox txtStokIsmi;
        private System.Windows.Forms.TextBox txtStokKodu;
        private System.Windows.Forms.Label lblStokIsmi;
        private DevExpress.XtraEditors.TextEdit txtStokFiyat;
        private System.Windows.Forms.Label lblFiyat;
    }
}