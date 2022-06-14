
namespace OnMuhasebe
{
    partial class frmServerAyar
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServer = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDB = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.button1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 124);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(269, 53);
            this.panelControl1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Image = global::OnMuhasebe.Properties.Resources.save_16x16;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(167, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SQL Server IP:";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(95, 16);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(167, 20);
            this.txtServer.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Veritabanı Adı:";
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(95, 42);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(167, 20);
            this.txtDB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kullanıcı Adı:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(95, 68);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(167, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Parola";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(95, 94);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.UseSystemPasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(167, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // frmServerAyar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 177);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmServerAyar";
            this.Text = "SQL Server Ayarları";
            this.Load += new System.EventHandler(this.frmServerAyar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtServer;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtDB;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtPassword;
    }
}