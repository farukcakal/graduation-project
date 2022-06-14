
namespace OnMuhasebe.CariModulu
{
    partial class frmCariAcilisKarti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCariAcilisKarti));
            this.lbl_Cari_Kodu_Hareket = new System.Windows.Forms.Label();
            this.txtCariIsim = new System.Windows.Forms.TextBox();
            this.txtCariKodu = new System.Windows.Forms.TextBox();
            this.lbl_Cari_Ismi_Hareket = new System.Windows.Forms.Label();
            this.txtTutar = new DevExpress.XtraEditors.TextEdit();
            this.txtTarih = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Cari_Kodu_Acma = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.radioAlacak = new System.Windows.Forms.RadioButton();
            this.radioBorc = new System.Windows.Forms.RadioButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeni = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBelgeNo = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelgeNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Cari_Kodu_Hareket
            // 
            this.lbl_Cari_Kodu_Hareket.AutoSize = true;
            this.lbl_Cari_Kodu_Hareket.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Cari_Kodu_Hareket.Location = new System.Drawing.Point(17, 13);
            this.lbl_Cari_Kodu_Hareket.Name = "lbl_Cari_Kodu_Hareket";
            this.lbl_Cari_Kodu_Hareket.Size = new System.Drawing.Size(88, 21);
            this.lbl_Cari_Kodu_Hareket.TabIndex = 3;
            this.lbl_Cari_Kodu_Hareket.Text = "Cari Kodu";
            // 
            // txtCariIsim
            // 
            this.txtCariIsim.Location = new System.Drawing.Point(121, 42);
            this.txtCariIsim.Name = "txtCariIsim";
            this.txtCariIsim.ReadOnly = true;
            this.txtCariIsim.Size = new System.Drawing.Size(329, 21);
            this.txtCariIsim.TabIndex = 2;
            // 
            // txtCariKodu
            // 
            this.txtCariKodu.Location = new System.Drawing.Point(121, 15);
            this.txtCariKodu.Name = "txtCariKodu";
            this.txtCariKodu.ReadOnly = true;
            this.txtCariKodu.Size = new System.Drawing.Size(257, 21);
            this.txtCariKodu.TabIndex = 0;
            // 
            // lbl_Cari_Ismi_Hareket
            // 
            this.lbl_Cari_Ismi_Hareket.AutoSize = true;
            this.lbl_Cari_Ismi_Hareket.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Cari_Ismi_Hareket.Location = new System.Drawing.Point(17, 40);
            this.lbl_Cari_Ismi_Hareket.Name = "lbl_Cari_Ismi_Hareket";
            this.lbl_Cari_Ismi_Hareket.Size = new System.Drawing.Size(78, 21);
            this.lbl_Cari_Ismi_Hareket.TabIndex = 4;
            this.lbl_Cari_Ismi_Hareket.Text = "Cari İsmi";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(121, 123);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(190, 20);
            this.txtTutar.TabIndex = 5;
            // 
            // txtTarih
            // 
            this.txtTarih.EditValue = null;
            this.txtTarih.Location = new System.Drawing.Point(121, 97);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Size = new System.Drawing.Size(190, 20);
            this.txtTarih.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tutar";
            // 
            // lbl_Cari_Kodu_Acma
            // 
            this.lbl_Cari_Kodu_Acma.AutoSize = true;
            this.lbl_Cari_Kodu_Acma.Location = new System.Drawing.Point(18, 100);
            this.lbl_Cari_Kodu_Acma.Name = "lbl_Cari_Kodu_Acma";
            this.lbl_Cari_Kodu_Acma.Size = new System.Drawing.Size(31, 13);
            this.lbl_Cari_Kodu_Acma.TabIndex = 11;
            this.lbl_Cari_Kodu_Acma.Text = "Tarih";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(384, 15);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(66, 16);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Arama";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // radioAlacak
            // 
            this.radioAlacak.AutoSize = true;
            this.radioAlacak.Checked = true;
            this.radioAlacak.Location = new System.Drawing.Point(121, 149);
            this.radioAlacak.Name = "radioAlacak";
            this.radioAlacak.Size = new System.Drawing.Size(97, 17);
            this.radioAlacak.TabIndex = 6;
            this.radioAlacak.TabStop = true;
            this.radioAlacak.Text = "Alacak Bakiyesi";
            this.radioAlacak.UseVisualStyleBackColor = true;
            // 
            // radioBorc
            // 
            this.radioBorc.AutoSize = true;
            this.radioBorc.Location = new System.Drawing.Point(224, 149);
            this.radioBorc.Name = "radioBorc";
            this.radioBorc.Size = new System.Drawing.Size(87, 17);
            this.radioBorc.TabIndex = 7;
            this.radioBorc.Text = "Borç Bakiyesi";
            this.radioBorc.UseVisualStyleBackColor = true;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnKaydet);
            this.panelControl2.Controls.Add(this.btnYeni);
            this.panelControl2.Controls.Add(this.btnKapat);
            this.panelControl2.Controls.Add(this.btnSil);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 278);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(457, 48);
            this.panelControl2.TabIndex = 9;
            // 
            // btnKaydet
            // 
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
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(118, 172);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(332, 91);
            this.txtAciklama.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Açıklama";
            // 
            // txtBelgeNo
            // 
            this.txtBelgeNo.Location = new System.Drawing.Point(121, 69);
            this.txtBelgeNo.Name = "txtBelgeNo";
            this.txtBelgeNo.Size = new System.Drawing.Size(190, 20);
            this.txtBelgeNo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Belge No";
            // 
            // frmCariAcilisKarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 326);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.radioBorc);
            this.Controls.Add(this.radioAlacak);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.lbl_Cari_Kodu_Acma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.txtBelgeNo);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.lbl_Cari_Kodu_Hareket);
            this.Controls.Add(this.txtCariIsim);
            this.Controls.Add(this.txtCariKodu);
            this.Controls.Add(this.lbl_Cari_Ismi_Hareket);
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCariAcilisKarti";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari Açılış Kartı";
            this.Load += new System.EventHandler(this.frmCariAcilisKarti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelgeNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Cari_Kodu_Hareket;
        private System.Windows.Forms.TextBox txtCariIsim;
        private System.Windows.Forms.TextBox txtCariKodu;
        private System.Windows.Forms.Label lbl_Cari_Ismi_Hareket;
        private DevExpress.XtraEditors.TextEdit txtTutar;
        private DevExpress.XtraEditors.DateEdit txtTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Cari_Kodu_Acma;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.RadioButton radioAlacak;
        private System.Windows.Forms.RadioButton radioBorc;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnYeni;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtBelgeNo;
        private System.Windows.Forms.Label label3;
    }
}