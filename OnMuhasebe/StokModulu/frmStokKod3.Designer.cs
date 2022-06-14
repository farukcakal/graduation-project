
namespace OnMuhasebe.StokModulu
{
    partial class frmStokKod3
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
            this.lbl_Kod_Kod1 = new System.Windows.Forms.Label();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.lbl_Acıklama_Kod1 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeni = new DevExpress.XtraEditors.SimpleButton();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Kod_Kod1
            // 
            this.lbl_Kod_Kod1.AutoSize = true;
            this.lbl_Kod_Kod1.Location = new System.Drawing.Point(12, 18);
            this.lbl_Kod_Kod1.Name = "lbl_Kod_Kod1";
            this.lbl_Kod_Kod1.Size = new System.Drawing.Size(34, 13);
            this.lbl_Kod_Kod1.TabIndex = 0;
            this.lbl_Kod_Kod1.Text = "Kod 3";
            // 
            // txtKod
            // 
            this.txtKod.Location = new System.Drawing.Point(67, 10);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(327, 21);
            this.txtKod.TabIndex = 0;
            // 
            // lbl_Acıklama_Kod1
            // 
            this.lbl_Acıklama_Kod1.AutoSize = true;
            this.lbl_Acıklama_Kod1.Location = new System.Drawing.Point(12, 48);
            this.lbl_Acıklama_Kod1.Name = "lbl_Acıklama_Kod1";
            this.lbl_Acıklama_Kod1.Size = new System.Drawing.Size(48, 13);
            this.lbl_Acıklama_Kod1.TabIndex = 0;
            this.lbl_Acıklama_Kod1.Text = "Açıklama";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(67, 40);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(327, 21);
            this.txtAciklama.TabIndex = 1;
            // 
            // btnKapat
            // 
            this.btnKapat.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnKapat.Appearance.Options.UseBackColor = true;
            this.btnKapat.ImageOptions.Image = global::OnMuhasebe.Properties.Resources.removepivotfield_32x322;
            this.btnKapat.Location = new System.Drawing.Point(298, 3);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 29);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Text = "Kapat";
            // 
            // btnSil
            // 
            this.btnSil.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.btnSil.Appearance.Options.UseBackColor = true;
            this.btnSil.ImageOptions.Image = global::OnMuhasebe.Properties.Resources.deletelist2_32x32;
            this.btnSil.Location = new System.Drawing.Point(208, 3);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 29);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.btnKaydet.Appearance.Options.UseBackColor = true;
            this.btnKaydet.ImageOptions.Image = global::OnMuhasebe.Properties.Resources.saveto_32x321;
            this.btnKaydet.Location = new System.Drawing.Point(109, 3);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 29);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnYeni.Appearance.Options.UseBackColor = true;
            this.btnYeni.ImageOptions.Image = global::OnMuhasebe.Properties.Resources.addfile_32x32;
            this.btnYeni.Location = new System.Drawing.Point(13, 3);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(75, 29);
            this.btnYeni.TabIndex = 0;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Liste
            // 
            this.Liste.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Liste.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.Liste.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.Liste.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.Liste.EmbeddedNavigator.Buttons.EnabledAutoRepeat = false;
            this.Liste.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.Liste.EmbeddedNavigator.Buttons.Last.Visible = false;
            this.Liste.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.Liste.Location = new System.Drawing.Point(0, 123);
            this.Liste.MainView = this.gridView1;
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(423, 409);
            this.Liste.TabIndex = 3;
            this.Liste.UseEmbeddedNavigator = true;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.KOD,
            this.ACIKLAMA});
            this.gridView1.GridControl = this.Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.OptionsColumn.AllowFocus = false;
            this.ID.OptionsColumn.AllowShowHide = false;
            this.ID.OptionsColumn.FixedWidth = true;
            this.ID.OptionsColumn.ReadOnly = true;
            // 
            // KOD
            // 
            this.KOD.Caption = "KOD";
            this.KOD.FieldName = "KOD";
            this.KOD.Name = "KOD";
            this.KOD.OptionsColumn.AllowEdit = false;
            this.KOD.OptionsColumn.AllowFocus = false;
            this.KOD.OptionsColumn.AllowShowHide = false;
            this.KOD.OptionsColumn.FixedWidth = true;
            this.KOD.OptionsColumn.ReadOnly = true;
            this.KOD.Visible = true;
            this.KOD.VisibleIndex = 0;
            // 
            // ACIKLAMA
            // 
            this.ACIKLAMA.Caption = "AÇIKLAMA";
            this.ACIKLAMA.FieldName = "ACIKLAMA";
            this.ACIKLAMA.Name = "ACIKLAMA";
            this.ACIKLAMA.OptionsColumn.AllowEdit = false;
            this.ACIKLAMA.OptionsColumn.AllowFocus = false;
            this.ACIKLAMA.OptionsColumn.AllowShowHide = false;
            this.ACIKLAMA.OptionsColumn.ReadOnly = true;
            this.ACIKLAMA.Visible = true;
            this.ACIKLAMA.VisibleIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKapat);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.btnYeni);
            this.panel1.Location = new System.Drawing.Point(0, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 36);
            this.panel1.TabIndex = 2;
            // 
            // frmStokKod3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 532);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.lbl_Acıklama_Kod1);
            this.Controls.Add(this.lbl_Kod_Kod1);
            this.Name = "frmStokKod3";
            this.Text = "Stok Kod 3";
            this.Load += new System.EventHandler(this.frmStokKod3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Kod_Kod1;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.Label lbl_Acıklama_Kod1;
        private System.Windows.Forms.TextBox txtAciklama;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnYeni;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn KOD;
        private DevExpress.XtraGrid.Columns.GridColumn ACIKLAMA;
        private System.Windows.Forms.Panel panel1;
    }
}