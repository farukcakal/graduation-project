﻿
namespace OnMuhasebe.StokModulu
{
    partial class StokKodu3
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
            this.gc_Stokkod3 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KOD1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Kapat_Kod3 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Sil_Kod3 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Kaydet_Kod3 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Yeni_Kod3 = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Acıklama_Kod3 = new System.Windows.Forms.TextBox();
            this.txt_Kod_Kod3 = new System.Windows.Forms.TextBox();
            this.lbl_Acıklama_Kod3 = new System.Windows.Forms.Label();
            this.lbl_Kod_Kod3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Stokkod3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gc_Stokkod3
            // 
            this.gc_Stokkod3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gc_Stokkod3.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gc_Stokkod3.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gc_Stokkod3.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gc_Stokkod3.EmbeddedNavigator.Buttons.EnabledAutoRepeat = false;
            this.gc_Stokkod3.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gc_Stokkod3.EmbeddedNavigator.Buttons.Last.Visible = false;
            this.gc_Stokkod3.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gc_Stokkod3.Location = new System.Drawing.Point(0, 116);
            this.gc_Stokkod3.MainView = this.gridView1;
            this.gc_Stokkod3.Name = "gc_Stokkod3";
            this.gc_Stokkod3.Size = new System.Drawing.Size(402, 409);
            this.gc_Stokkod3.TabIndex = 9;
            this.gc_Stokkod3.UseEmbeddedNavigator = true;
            this.gc_Stokkod3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.KOD1,
            this.ACIKLAMA});
            this.gridView1.GridControl = this.gc_Stokkod3;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            // KOD1
            // 
            this.KOD1.Caption = "KOD 1";
            this.KOD1.FieldName = "KOD 1";
            this.KOD1.Name = "KOD1";
            this.KOD1.OptionsColumn.AllowEdit = false;
            this.KOD1.OptionsColumn.AllowFocus = false;
            this.KOD1.OptionsColumn.AllowShowHide = false;
            this.KOD1.OptionsColumn.FixedWidth = true;
            this.KOD1.OptionsColumn.ReadOnly = true;
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
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Kapat_Kod3);
            this.panel1.Controls.Add(this.btn_Sil_Kod3);
            this.panel1.Controls.Add(this.btn_Kaydet_Kod3);
            this.panel1.Controls.Add(this.btn_Yeni_Kod3);
            this.panel1.Location = new System.Drawing.Point(0, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 36);
            this.panel1.TabIndex = 8;
            // 
            // btn_Kapat_Kod3
            // 
            this.btn_Kapat_Kod3.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btn_Kapat_Kod3.Appearance.Options.UseBackColor = true;
            this.btn_Kapat_Kod3.ImageOptions.Image = global::OnMuhasebe.Properties.Resources.removepivotfield_32x322;
            this.btn_Kapat_Kod3.Location = new System.Drawing.Point(298, 3);
            this.btn_Kapat_Kod3.Name = "btn_Kapat_Kod3";
            this.btn_Kapat_Kod3.Size = new System.Drawing.Size(75, 29);
            this.btn_Kapat_Kod3.TabIndex = 0;
            this.btn_Kapat_Kod3.Text = "Kapat";
            // 
            // btn_Sil_Kod3
            // 
            this.btn_Sil_Kod3.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.btn_Sil_Kod3.Appearance.Options.UseBackColor = true;
            this.btn_Sil_Kod3.ImageOptions.Image = global::OnMuhasebe.Properties.Resources.deletelist2_32x32;
            this.btn_Sil_Kod3.Location = new System.Drawing.Point(208, 3);
            this.btn_Sil_Kod3.Name = "btn_Sil_Kod3";
            this.btn_Sil_Kod3.Size = new System.Drawing.Size(75, 29);
            this.btn_Sil_Kod3.TabIndex = 0;
            this.btn_Sil_Kod3.Text = "Sil";
            // 
            // btn_Kaydet_Kod3
            // 
            this.btn_Kaydet_Kod3.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.btn_Kaydet_Kod3.Appearance.Options.UseBackColor = true;
            this.btn_Kaydet_Kod3.ImageOptions.Image = global::OnMuhasebe.Properties.Resources.saveto_32x321;
            this.btn_Kaydet_Kod3.Location = new System.Drawing.Point(109, 3);
            this.btn_Kaydet_Kod3.Name = "btn_Kaydet_Kod3";
            this.btn_Kaydet_Kod3.Size = new System.Drawing.Size(75, 29);
            this.btn_Kaydet_Kod3.TabIndex = 0;
            this.btn_Kaydet_Kod3.Text = "Kaydet";
            // 
            // btn_Yeni_Kod3
            // 
            this.btn_Yeni_Kod3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Yeni_Kod3.Appearance.Options.UseBackColor = true;
            this.btn_Yeni_Kod3.ImageOptions.Image = global::OnMuhasebe.Properties.Resources.addfile_32x32;
            this.btn_Yeni_Kod3.Location = new System.Drawing.Point(13, 3);
            this.btn_Yeni_Kod3.Name = "btn_Yeni_Kod3";
            this.btn_Yeni_Kod3.Size = new System.Drawing.Size(75, 29);
            this.btn_Yeni_Kod3.TabIndex = 0;
            this.btn_Yeni_Kod3.Text = "Yeni";
            // 
            // txt_Acıklama_Kod3
            // 
            this.txt_Acıklama_Kod3.Location = new System.Drawing.Point(67, 35);
            this.txt_Acıklama_Kod3.Name = "txt_Acıklama_Kod3";
            this.txt_Acıklama_Kod3.Size = new System.Drawing.Size(327, 21);
            this.txt_Acıklama_Kod3.TabIndex = 6;
            // 
            // txt_Kod_Kod3
            // 
            this.txt_Kod_Kod3.Location = new System.Drawing.Point(67, 5);
            this.txt_Kod_Kod3.Name = "txt_Kod_Kod3";
            this.txt_Kod_Kod3.Size = new System.Drawing.Size(327, 21);
            this.txt_Kod_Kod3.TabIndex = 7;
            // 
            // lbl_Acıklama_Kod3
            // 
            this.lbl_Acıklama_Kod3.AutoSize = true;
            this.lbl_Acıklama_Kod3.Location = new System.Drawing.Point(12, 43);
            this.lbl_Acıklama_Kod3.Name = "lbl_Acıklama_Kod3";
            this.lbl_Acıklama_Kod3.Size = new System.Drawing.Size(48, 13);
            this.lbl_Acıklama_Kod3.TabIndex = 4;
            this.lbl_Acıklama_Kod3.Text = "Açıklama";
            // 
            // lbl_Kod_Kod3
            // 
            this.lbl_Kod_Kod3.AutoSize = true;
            this.lbl_Kod_Kod3.Location = new System.Drawing.Point(12, 13);
            this.lbl_Kod_Kod3.Name = "lbl_Kod_Kod3";
            this.lbl_Kod_Kod3.Size = new System.Drawing.Size(34, 13);
            this.lbl_Kod_Kod3.TabIndex = 5;
            this.lbl_Kod_Kod3.Text = "Kod 3";
            // 
            // StokKodu3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 525);
            this.Controls.Add(this.gc_Stokkod3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_Acıklama_Kod3);
            this.Controls.Add(this.txt_Kod_Kod3);
            this.Controls.Add(this.lbl_Acıklama_Kod3);
            this.Controls.Add(this.lbl_Kod_Kod3);
            this.Name = "StokKodu3";
            this.Text = "StokKodu3";
            ((System.ComponentModel.ISupportInitialize)(this.gc_Stokkod3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_Stokkod3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn KOD1;
        private DevExpress.XtraGrid.Columns.GridColumn ACIKLAMA;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btn_Kapat_Kod3;
        private DevExpress.XtraEditors.SimpleButton btn_Sil_Kod3;
        private DevExpress.XtraEditors.SimpleButton btn_Kaydet_Kod3;
        private DevExpress.XtraEditors.SimpleButton btn_Yeni_Kod3;
        private System.Windows.Forms.TextBox txt_Acıklama_Kod3;
        private System.Windows.Forms.TextBox txt_Kod_Kod3;
        private System.Windows.Forms.Label lbl_Acıklama_Kod3;
        private System.Windows.Forms.Label lbl_Kod_Kod3;
    }
}