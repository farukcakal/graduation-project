
namespace OnMuhasebe.CariModulu
{
    partial class XtraForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraForm1));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.Arama = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnArama = new DevExpress.XtraEditors.SimpleButton();
            this.txtTipi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtTC = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtIlce = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtIl = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCariAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCariKodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cariKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cariIsım = new DevExpress.XtraGrid.Columns.GridColumn();
            this.il = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ılce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.telefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vergiDairesi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tipi = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Arama)).BeginInit();
            this.Arama.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIlce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.Arama);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(768, 525);
            this.splitContainerControl1.SplitterPosition = 179;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // Arama
            // 
            this.Arama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Arama.Location = new System.Drawing.Point(0, 0);
            this.Arama.Name = "Arama";
            this.Arama.SelectedTabPage = this.xtraTabPage1;
            this.Arama.Size = new System.Drawing.Size(179, 525);
            this.Arama.TabIndex = 0;
            this.Arama.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnTemizle);
            this.xtraTabPage1.Controls.Add(this.btnArama);
            this.xtraTabPage1.Controls.Add(this.txtTipi);
            this.xtraTabPage1.Controls.Add(this.labelControl6);
            this.xtraTabPage1.Controls.Add(this.txtTC);
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.txtIlce);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.txtIl);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.txtCariAdi);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.txtCariKodu);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(177, 500);
            this.xtraTabPage1.Text = "Arama";
            // 
            // btnTemizle
            // 
            this.btnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.ImageOptions.Image")));
            this.btnTemizle.Location = new System.Drawing.Point(94, 310);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 7;
            this.btnTemizle.Text = "Temizle";
            // 
            // btnArama
            // 
            this.btnArama.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnArama.ImageOptions.Image")));
            this.btnArama.Location = new System.Drawing.Point(11, 310);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(75, 23);
            this.btnArama.TabIndex = 6;
            this.btnArama.Text = "Arama";
            // 
            // txtTipi
            // 
            this.txtTipi.Location = new System.Drawing.Point(11, 270);
            this.txtTipi.Name = "txtTipi";
            this.txtTipi.Size = new System.Drawing.Size(158, 20);
            this.txtTipi.TabIndex = 5;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(11, 250);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(16, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Tipi";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(11, 223);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(158, 20);
            this.txtTC.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(11, 203);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(65, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "T.C. Kimlik No";
            // 
            // txtIlce
            // 
            this.txtIlce.Location = new System.Drawing.Point(11, 176);
            this.txtIlce.Name = "txtIlce";
            this.txtIlce.Size = new System.Drawing.Size(158, 20);
            this.txtIlce.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(11, 156);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(17, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "İlçe";
            // 
            // txtIl
            // 
            this.txtIl.Location = new System.Drawing.Point(11, 129);
            this.txtIl.Name = "txtIl";
            this.txtIl.Size = new System.Drawing.Size(158, 20);
            this.txtIl.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 109);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(6, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "İl";
            // 
            // txtCariAdi
            // 
            this.txtCariAdi.Location = new System.Drawing.Point(11, 82);
            this.txtCariAdi.Name = "txtCariAdi";
            this.txtCariAdi.Size = new System.Drawing.Size(158, 20);
            this.txtCariAdi.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Cari Adı";
            // 
            // txtCariKodu
            // 
            this.txtCariKodu.Location = new System.Drawing.Point(11, 35);
            this.txtCariKodu.Name = "txtCariKodu";
            this.txtCariKodu.Size = new System.Drawing.Size(158, 20);
            this.txtCariKodu.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Cari Kodu";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(579, 525);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.cariKodu,
            this.cariIsım,
            this.il,
            this.ılce,
            this.telefon,
            this.vergiDairesi,
            this.tc,
            this.tipi});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            // 
            // cariKodu
            // 
            this.cariKodu.Caption = "Cari Kodu";
            this.cariKodu.FieldName = "cariKodu";
            this.cariKodu.Name = "cariKodu";
            this.cariKodu.Visible = true;
            this.cariKodu.VisibleIndex = 1;
            // 
            // cariIsım
            // 
            this.cariIsım.Caption = "Cari İsim";
            this.cariIsım.FieldName = "cariIsım";
            this.cariIsım.Name = "cariIsım";
            this.cariIsım.Visible = true;
            this.cariIsım.VisibleIndex = 2;
            // 
            // il
            // 
            this.il.Caption = "İl";
            this.il.FieldName = "il";
            this.il.Name = "il";
            this.il.Visible = true;
            this.il.VisibleIndex = 3;
            // 
            // ılce
            // 
            this.ılce.Caption = "İlçe";
            this.ılce.FieldName = "ılce";
            this.ılce.Name = "ılce";
            this.ılce.Visible = true;
            this.ılce.VisibleIndex = 4;
            // 
            // telefon
            // 
            this.telefon.Caption = "Telefon";
            this.telefon.FieldName = "telefon";
            this.telefon.Name = "telefon";
            this.telefon.Visible = true;
            this.telefon.VisibleIndex = 5;
            // 
            // vergiDairesi
            // 
            this.vergiDairesi.Caption = "Vergi Dairesi";
            this.vergiDairesi.FieldName = "vergiDairesi";
            this.vergiDairesi.Name = "vergiDairesi";
            this.vergiDairesi.Visible = true;
            this.vergiDairesi.VisibleIndex = 6;
            // 
            // tc
            // 
            this.tc.Caption = "T.C. Kimlik No";
            this.tc.FieldName = "tc";
            this.tc.Name = "tc";
            this.tc.Visible = true;
            this.tc.VisibleIndex = 7;
            // 
            // tipi
            // 
            this.tipi.Caption = "Tipi";
            this.tipi.FieldName = "tipi";
            this.tipi.Name = "tipi";
            this.tipi.Visible = true;
            this.tipi.VisibleIndex = 8;
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(768, 525);
            this.Controls.Add(this.splitContainerControl1);
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XtraForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari Listesi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Arama)).EndInit();
            this.Arama.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIlce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTab.XtraTabControl Arama;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn cariKodu;
        private DevExpress.XtraGrid.Columns.GridColumn cariIsım;
        private DevExpress.XtraGrid.Columns.GridColumn il;
        private DevExpress.XtraGrid.Columns.GridColumn ılce;
        private DevExpress.XtraGrid.Columns.GridColumn telefon;
        private DevExpress.XtraGrid.Columns.GridColumn vergiDairesi;
        private DevExpress.XtraGrid.Columns.GridColumn tc;
        private DevExpress.XtraGrid.Columns.GridColumn tipi;
        private DevExpress.XtraEditors.TextEdit txtCariKodu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.SimpleButton btnArama;
        private DevExpress.XtraEditors.TextEdit txtTipi;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtTC;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtIlce;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtIl;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtCariAdi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}