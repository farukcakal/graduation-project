
namespace OnMuhasebe.RaporModulu
{
    partial class frmRapStokHareket
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnArama = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STOKKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STOKADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIRIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CIKIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BAKIYE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.xtraTabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainer1.Size = new System.Drawing.Size(757, 534);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 0;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(200, 534);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnTemizle);
            this.xtraTabPage1.Controls.Add(this.btnArama);
            this.xtraTabPage1.Controls.Add(this.textEdit7);
            this.xtraTabPage1.Controls.Add(this.textEdit6);
            this.xtraTabPage1.Controls.Add(this.textEdit3);
            this.xtraTabPage1.Controls.Add(this.labelControl7);
            this.xtraTabPage1.Controls.Add(this.labelControl6);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.textEdit5);
            this.xtraTabPage1.Controls.Add(this.textEdit2);
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.textEdit4);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.textEdit1);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(198, 504);
            this.xtraTabPage1.Text = "Arama";
            // 
            // btnTemizle
            // 
            this.btnTemizle.ImageOptions.Image = global::OnMuhasebe.Properties.Resources.clearall_16x16;
            this.btnTemizle.Location = new System.Drawing.Point(101, 377);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(81, 29);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Temizle";
            // 
            // btnArama
            // 
            this.btnArama.ImageOptions.Image = global::OnMuhasebe.Properties.Resources.lookup_reference_16x16;
            this.btnArama.Location = new System.Drawing.Point(3, 377);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(81, 29);
            this.btnArama.TabIndex = 2;
            this.btnArama.Text = "Arama";
            // 
            // textEdit6
            // 
            this.textEdit6.Location = new System.Drawing.Point(3, 291);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Size = new System.Drawing.Size(179, 22);
            this.textEdit6.TabIndex = 1;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(3, 139);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(179, 22);
            this.textEdit3.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(3, 269);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(75, 16);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "labelControl1";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(3, 117);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(75, 16);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "labelControl1";
            // 
            // textEdit5
            // 
            this.textEdit5.Location = new System.Drawing.Point(3, 241);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Size = new System.Drawing.Size(179, 22);
            this.textEdit5.TabIndex = 1;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(3, 89);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(179, 22);
            this.textEdit2.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(3, 219);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(75, 16);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "labelControl1";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(3, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 16);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Stok Adı";
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(3, 191);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(179, 22);
            this.textEdit4.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(3, 169);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(75, 16);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "labelControl1";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(3, 39);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(179, 22);
            this.textEdit1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(3, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Stok Kodu";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(553, 534);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.STOKKODU,
            this.STOKADI,
            this.GIRIS,
            this.CIKIS,
            this.BAKIYE});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.MinWidth = 25;
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 94;
            // 
            // STOKKODU
            // 
            this.STOKKODU.Caption = "STOKKODU";
            this.STOKKODU.FieldName = "STOKKODU";
            this.STOKKODU.MinWidth = 25;
            this.STOKKODU.Name = "STOKKODU";
            this.STOKKODU.Visible = true;
            this.STOKKODU.VisibleIndex = 1;
            this.STOKKODU.Width = 94;
            // 
            // STOKADI
            // 
            this.STOKADI.Caption = "STOKADI";
            this.STOKADI.FieldName = "STOKADI";
            this.STOKADI.MinWidth = 25;
            this.STOKADI.Name = "STOKADI";
            this.STOKADI.Visible = true;
            this.STOKADI.VisibleIndex = 2;
            this.STOKADI.Width = 94;
            // 
            // GIRIS
            // 
            this.GIRIS.Caption = "GİRİŞ";
            this.GIRIS.FieldName = "GIRIS";
            this.GIRIS.MinWidth = 25;
            this.GIRIS.Name = "GIRIS";
            this.GIRIS.Visible = true;
            this.GIRIS.VisibleIndex = 3;
            this.GIRIS.Width = 94;
            // 
            // CIKIS
            // 
            this.CIKIS.Caption = "ÇIKIŞ";
            this.CIKIS.FieldName = "CIKIS";
            this.CIKIS.MinWidth = 25;
            this.CIKIS.Name = "CIKIS";
            this.CIKIS.Visible = true;
            this.CIKIS.VisibleIndex = 4;
            this.CIKIS.Width = 94;
            // 
            // BAKIYE
            // 
            this.BAKIYE.Caption = "BAKİYE";
            this.BAKIYE.FieldName = "BAKIYE";
            this.BAKIYE.MinWidth = 25;
            this.BAKIYE.Name = "BAKIYE";
            this.BAKIYE.Visible = true;
            this.BAKIYE.VisibleIndex = 5;
            this.BAKIYE.Width = 94;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(3, 319);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(75, 16);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "labelControl1";
            // 
            // textEdit7
            // 
            this.textEdit7.Location = new System.Drawing.Point(3, 341);
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Size = new System.Drawing.Size(179, 22);
            this.textEdit7.TabIndex = 1;
            // 
            // frmRapStokHareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 534);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmRapStokHareket";
            this.Text = "Stok Hareket Raporu";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn STOKKODU;
        private DevExpress.XtraGrid.Columns.GridColumn STOKADI;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.SimpleButton btnArama;
        private DevExpress.XtraEditors.TextEdit textEdit6;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn GIRIS;
        private DevExpress.XtraGrid.Columns.GridColumn CIKIS;
        private DevExpress.XtraGrid.Columns.GridColumn BAKIYE;
        private DevExpress.XtraEditors.TextEdit textEdit7;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}