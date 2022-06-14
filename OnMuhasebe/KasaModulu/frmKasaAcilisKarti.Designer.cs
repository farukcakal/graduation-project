
namespace OnMuhasebe.KasaModulu
{
    partial class frmKasaAcilisKarti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKasaAcilisKarti));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeni = new DevExpress.XtraEditors.SimpleButton();
            this.radioAlacak = new System.Windows.Forms.RadioButton();
            this.radioBorc = new System.Windows.Forms.RadioButton();
            this.tarih = new DevExpress.XtraEditors.DateEdit();
            this.txtBelgeNo = new DevExpress.XtraEditors.TextEdit();
            this.txtTutar = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCariIsmi = new DevExpress.XtraEditors.TextEdit();
            this.txtCariKodu = new DevExpress.XtraEditors.TextEdit();
            this.btnSec = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelgeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariIsmi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKodu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnKapat);
            this.panelControl2.Controls.Add(this.btnSil);
            this.panelControl2.Controls.Add(this.btnKaydet);
            this.panelControl2.Controls.Add(this.btnYeni);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 165);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(444, 47);
            this.panelControl2.TabIndex = 35;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
            this.btnKapat.Location = new System.Drawing.Point(341, 9);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(96, 33);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Text = "Kapat [Esc]";
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(239, 9);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(96, 33);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(140, 9);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(96, 33);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            // 
            // btnYeni
            // 
            this.btnYeni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYeni.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYeni.ImageOptions.Image")));
            this.btnYeni.Location = new System.Drawing.Point(41, 9);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(96, 33);
            this.btnYeni.TabIndex = 0;
            this.btnYeni.Text = "Yeni";
            // 
            // radioAlacak
            // 
            this.radioAlacak.AutoSize = true;
            this.radioAlacak.Checked = true;
            this.radioAlacak.Location = new System.Drawing.Point(104, 137);
            this.radioAlacak.Name = "radioAlacak";
            this.radioAlacak.Size = new System.Drawing.Size(45, 17);
            this.radioAlacak.TabIndex = 32;
            this.radioAlacak.TabStop = true;
            this.radioAlacak.Text = "Giriş";
            this.radioAlacak.UseVisualStyleBackColor = true;
            // 
            // radioBorc
            // 
            this.radioBorc.AutoSize = true;
            this.radioBorc.Location = new System.Drawing.Point(158, 137);
            this.radioBorc.Name = "radioBorc";
            this.radioBorc.Size = new System.Drawing.Size(46, 17);
            this.radioBorc.TabIndex = 33;
            this.radioBorc.Text = "Çıkış";
            this.radioBorc.UseVisualStyleBackColor = true;
            // 
            // tarih
            // 
            this.tarih.EditValue = null;
            this.tarih.Location = new System.Drawing.Point(104, 83);
            this.tarih.Name = "tarih";
            this.tarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tarih.Size = new System.Drawing.Size(100, 20);
            this.tarih.TabIndex = 30;
            // 
            // txtBelgeNo
            // 
            this.txtBelgeNo.Location = new System.Drawing.Point(104, 5);
            this.txtBelgeNo.Name = "txtBelgeNo";
            this.txtBelgeNo.Size = new System.Drawing.Size(100, 20);
            this.txtBelgeNo.TabIndex = 26;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(104, 109);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(100, 20);
            this.txtTutar.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Tarih";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Belge No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Tutar";
            // 
            // txtCariIsmi
            // 
            this.txtCariIsmi.Location = new System.Drawing.Point(104, 57);
            this.txtCariIsmi.Name = "txtCariIsmi";
            this.txtCariIsmi.Properties.ReadOnly = true;
            this.txtCariIsmi.Size = new System.Drawing.Size(313, 20);
            this.txtCariIsmi.TabIndex = 28;
            // 
            // txtCariKodu
            // 
            this.txtCariKodu.Location = new System.Drawing.Point(104, 31);
            this.txtCariKodu.Name = "txtCariKodu";
            this.txtCariKodu.Properties.ReadOnly = true;
            this.txtCariKodu.Size = new System.Drawing.Size(271, 20);
            this.txtCariKodu.TabIndex = 27;
            // 
            // btnSec
            // 
            this.btnSec.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSec.ImageOptions.Image")));
            this.btnSec.Location = new System.Drawing.Point(381, 31);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(36, 20);
            this.btnSec.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Kasa Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Kasa Kodu";
            // 
            // frmKasaAcilisKarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 212);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.radioAlacak);
            this.Controls.Add(this.radioBorc);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.txtBelgeNo);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCariIsmi);
            this.Controls.Add(this.txtCariKodu);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.IconOptions.ShowIcon = false;
            this.Name = "frmKasaAcilisKarti";
            this.Text = "Kasa Açılış Kartı";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelgeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariIsmi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKodu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnYeni;
        private System.Windows.Forms.RadioButton radioAlacak;
        private System.Windows.Forms.RadioButton radioBorc;
        private DevExpress.XtraEditors.DateEdit tarih;
        private DevExpress.XtraEditors.TextEdit txtBelgeNo;
        private DevExpress.XtraEditors.TextEdit txtTutar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtCariIsmi;
        private DevExpress.XtraEditors.TextEdit txtCariKodu;
        private DevExpress.XtraEditors.SimpleButton btnSec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}