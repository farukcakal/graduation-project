
namespace OnMuhasebe
{
    partial class frmMasaustu
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
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem9 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem6 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem7 = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem1,
            this.navBarItem2,
            this.navBarItem6,
            this.navBarItem7,
            this.navBarItem9});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 169;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.Size = new System.Drawing.Size(169, 413);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "Fatura İşlemleri";
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem9)});
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // navBarItem9
            // 
            this.navBarItem9.Caption = "Satış Faturası";
            this.navBarItem9.ImageOptions.SmallImage = global::OnMuhasebe.Properties.Resources.insertblanklinepivottable_32x32;
            this.navBarItem9.Name = "navBarItem9";
            this.navBarItem9.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem9_LinkClicked);
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Stok İşlemleri";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "Stok Tanıtım Kartı";
            this.navBarItem1.ImageOptions.SmallImage = global::OnMuhasebe.Properties.Resources.pageinfo_32x32;
            this.navBarItem1.Name = "navBarItem1";
            this.navBarItem1.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem1_LinkClicked);
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "Stok Listesi";
            this.navBarItem2.ImageOptions.SmallImage = global::OnMuhasebe.Properties.Resources.chartsshowlegend_32x321;
            this.navBarItem2.Name = "navBarItem2";
            this.navBarItem2.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem2_LinkClicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Cari İşlemleri";
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem6),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem7)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarItem6
            // 
            this.navBarItem6.Caption = "Cari Tanıtım Kartı";
            this.navBarItem6.ImageOptions.SmallImage = global::OnMuhasebe.Properties.Resources.packageproduct_32x32;
            this.navBarItem6.Name = "navBarItem6";
            this.navBarItem6.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem6_LinkClicked);
            // 
            // navBarItem7
            // 
            this.navBarItem7.Caption = "Cari Listesi";
            this.navBarItem7.ImageOptions.SmallImage = global::OnMuhasebe.Properties.Resources.chartsshowlegend_32x32;
            this.navBarItem7.Name = "navBarItem7";
            this.navBarItem7.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem7_LinkClicked);
            // 
            // frmMasaustu
            // 
            this.Appearance.BackColor = System.Drawing.Color.Silver;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(549, 413);
            this.Controls.Add(this.navBarControl1);
            this.Name = "frmMasaustu";
            this.Text = "Hoş Geldiniz";
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem9;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem6;
        private DevExpress.XtraNavBar.NavBarItem navBarItem7;
    }
}