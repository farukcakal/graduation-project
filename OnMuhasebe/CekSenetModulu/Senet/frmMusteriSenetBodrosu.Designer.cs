
namespace OnMuhasebe.CekSenetModulu.Senet
{
    partial class frmMusteriSenetBodrosu
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
            this.grcoCekBodroGiris = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BELGENO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CEKNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VADETARIHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BANKA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SUBE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TUTAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTarih = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtCariIsim = new DevExpress.XtraEditors.TextEdit();
            this.txtBordroNo = new DevExpress.XtraEditors.ButtonEdit();
            this.txtCariKod = new DevExpress.XtraEditors.ButtonEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnYeni = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.TxtBordroAciklamasi = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtOrtVad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtToplamTutar = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grcoCekBodroGiris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariIsim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBordroNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBordroAciklamasi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrtVad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToplamTutar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grcoCekBodroGiris
            // 
            this.grcoCekBodroGiris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcoCekBodroGiris.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grcoCekBodroGiris.Location = new System.Drawing.Point(0, 78);
            this.grcoCekBodroGiris.MainView = this.gridView1;
            this.grcoCekBodroGiris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grcoCekBodroGiris.Name = "grcoCekBodroGiris";
            this.grcoCekBodroGiris.Size = new System.Drawing.Size(797, 290);
            this.grcoCekBodroGiris.TabIndex = 16;
            this.grcoCekBodroGiris.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.BELGENO,
            this.CEKNO,
            this.VADETARIHI,
            this.BANKA,
            this.SUBE,
            this.TUTAR});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.grcoCekBodroGiris;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // BELGENO
            // 
            this.BELGENO.Caption = "BELGENO";
            this.BELGENO.FieldName = "BELGENO";
            this.BELGENO.MinWidth = 21;
            this.BELGENO.Name = "BELGENO";
            this.BELGENO.OptionsColumn.FixedWidth = true;
            this.BELGENO.Visible = true;
            this.BELGENO.VisibleIndex = 0;
            this.BELGENO.Width = 81;
            // 
            // CEKNO
            // 
            this.CEKNO.Caption = "ÇEK NO";
            this.CEKNO.FieldName = "CEKNO";
            this.CEKNO.MinWidth = 21;
            this.CEKNO.Name = "CEKNO";
            this.CEKNO.OptionsColumn.FixedWidth = true;
            this.CEKNO.Visible = true;
            this.CEKNO.VisibleIndex = 1;
            this.CEKNO.Width = 81;
            // 
            // VADETARIHI
            // 
            this.VADETARIHI.Caption = "VADE TARİHİ";
            this.VADETARIHI.FieldName = "VADETARIHI";
            this.VADETARIHI.MinWidth = 21;
            this.VADETARIHI.Name = "VADETARIHI";
            this.VADETARIHI.OptionsColumn.FixedWidth = true;
            this.VADETARIHI.Visible = true;
            this.VADETARIHI.VisibleIndex = 2;
            this.VADETARIHI.Width = 116;
            // 
            // BANKA
            // 
            this.BANKA.Caption = "BANKA";
            this.BANKA.FieldName = "BANKA";
            this.BANKA.MinWidth = 21;
            this.BANKA.Name = "BANKA";
            this.BANKA.Visible = true;
            this.BANKA.VisibleIndex = 3;
            this.BANKA.Width = 291;
            // 
            // SUBE
            // 
            this.SUBE.Caption = "ŞUBE";
            this.SUBE.FieldName = "SUBE";
            this.SUBE.MinWidth = 21;
            this.SUBE.Name = "SUBE";
            this.SUBE.OptionsColumn.FixedWidth = true;
            this.SUBE.Visible = true;
            this.SUBE.VisibleIndex = 4;
            this.SUBE.Width = 81;
            // 
            // TUTAR
            // 
            this.TUTAR.Caption = "TUTAR";
            this.TUTAR.FieldName = "TUTAR";
            this.TUTAR.MinWidth = 21;
            this.TUTAR.Name = "TUTAR";
            this.TUTAR.OptionsColumn.FixedWidth = true;
            this.TUTAR.Visible = true;
            this.TUTAR.VisibleIndex = 5;
            this.TUTAR.Width = 81;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtTarih);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtCariIsim);
            this.groupControl1.Controls.Add(this.txtBordroNo);
            this.groupControl1.Controls.Add(this.txtCariKod);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(797, 78);
            this.groupControl1.TabIndex = 15;
            this.groupControl1.Text = "Bordro Bilgileri";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(321, 33);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Cari Kodu";
            // 
            // txtTarih
            // 
            this.txtTarih.EditValue = null;
            this.txtTarih.Location = new System.Drawing.Point(109, 54);
            this.txtTarih.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Size = new System.Drawing.Size(143, 20);
            this.txtTarih.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 33);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(79, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Bordro Numarası";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(10, 56);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(24, 13);
            this.labelControl9.TabIndex = 2;
            this.labelControl9.Text = "Tarih";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Location = new System.Drawing.Point(321, 54);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(41, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Cari İsim";
            // 
            // txtCariIsim
            // 
            this.txtCariIsim.Location = new System.Drawing.Point(373, 51);
            this.txtCariIsim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCariIsim.Name = "txtCariIsim";
            this.txtCariIsim.Size = new System.Drawing.Size(345, 20);
            this.txtCariIsim.TabIndex = 1;
            // 
            // txtBordroNo
            // 
            this.txtBordroNo.Location = new System.Drawing.Point(109, 31);
            this.txtBordroNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBordroNo.Name = "txtBordroNo";
            this.txtBordroNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtBordroNo.Size = new System.Drawing.Size(143, 20);
            this.txtBordroNo.TabIndex = 0;
            // 
            // txtCariKod
            // 
            this.txtCariKod.Location = new System.Drawing.Point(373, 31);
            this.txtCariKod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCariKod.Name = "txtCariKod";
            this.txtCariKod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtCariKod.Size = new System.Drawing.Size(345, 20);
            this.txtCariKod.TabIndex = 2;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnYeni);
            this.panelControl2.Controls.Add(this.btnKaydet);
            this.panelControl2.Controls.Add(this.btnSil);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 368);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(797, 32);
            this.panelControl2.TabIndex = 17;
            // 
            // btnYeni
            // 
            this.btnYeni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYeni.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnYeni.Appearance.Options.UseBackColor = true;
            this.btnYeni.ImageOptions.Image = global::OnMuhasebe.Properties.Resources.insert_16x16;
            this.btnYeni.Location = new System.Drawing.Point(526, 4);
            this.btnYeni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(90, 24);
            this.btnYeni.TabIndex = 0;
            this.btnYeni.Text = "Yeni";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.btnKaydet.Appearance.Options.UseBackColor = true;
            this.btnKaydet.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.btnKaydet.AppearanceDisabled.Options.UseBackColor = true;
            this.btnKaydet.ImageOptions.Image = global::OnMuhasebe.Properties.Resources.save_16x16;
            this.btnKaydet.Location = new System.Drawing.Point(621, 4);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(81, 24);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.btnSil.Appearance.Options.UseBackColor = true;
            this.btnSil.ImageOptions.Image = global::OnMuhasebe.Properties.Resources.trash_16x16;
            this.btnSil.Location = new System.Drawing.Point(706, 4);
            this.btnSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(81, 24);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl11);
            this.panelControl1.Controls.Add(this.TxtBordroAciklamasi);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.txtOrtVad);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.txtToplamTutar);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 310);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(797, 58);
            this.panelControl1.TabIndex = 18;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(10, 5);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(48, 13);
            this.labelControl11.TabIndex = 2;
            this.labelControl11.Text = "Açıklaması";
            // 
            // TxtBordroAciklamasi
            // 
            this.TxtBordroAciklamasi.Location = new System.Drawing.Point(67, 3);
            this.TxtBordroAciklamasi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtBordroAciklamasi.Name = "TxtBordroAciklamasi";
            this.TxtBordroAciklamasi.Size = new System.Drawing.Size(297, 51);
            this.TxtBordroAciklamasi.TabIndex = 12;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(575, 37);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(71, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Ortalama Vade";
            // 
            // txtOrtVad
            // 
            this.txtOrtVad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrtVad.Location = new System.Drawing.Point(657, 35);
            this.txtOrtVad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrtVad.Name = "txtOrtVad";
            this.txtOrtVad.Size = new System.Drawing.Size(130, 20);
            this.txtOrtVad.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(575, 15);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Toplam Tutar";
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToplamTutar.Location = new System.Drawing.Point(657, 12);
            this.txtToplamTutar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Size = new System.Drawing.Size(130, 20);
            this.txtToplamTutar.TabIndex = 1;
            // 
            // frmMusteriSenetBodrosu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 400);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.grcoCekBodroGiris);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMusteriSenetBodrosu";
            this.Text = "Müşteri Senet Bordrosu";
            ((System.ComponentModel.ISupportInitialize)(this.grcoCekBodroGiris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariIsim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBordroNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBordroAciklamasi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrtVad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToplamTutar.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grcoCekBodroGiris;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn BELGENO;
        private DevExpress.XtraGrid.Columns.GridColumn CEKNO;
        private DevExpress.XtraGrid.Columns.GridColumn VADETARIHI;
        private DevExpress.XtraGrid.Columns.GridColumn BANKA;
        private DevExpress.XtraGrid.Columns.GridColumn SUBE;
        private DevExpress.XtraGrid.Columns.GridColumn TUTAR;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit txtTarih;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtCariIsim;
        private DevExpress.XtraEditors.ButtonEdit txtBordroNo;
        private DevExpress.XtraEditors.ButtonEdit txtCariKod;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnYeni;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.MemoEdit TxtBordroAciklamasi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtOrtVad;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtToplamTutar;
    }
}