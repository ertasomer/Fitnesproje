namespace fitnesproje
{
    partial class frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.txtkullanici1 = new System.Windows.Forms.TextBox();
            this.txtsifre1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.uye = new System.Windows.Forms.Button();
            this.admin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtkullanici1
            // 
            this.txtkullanici1.Location = new System.Drawing.Point(87, 75);
            this.txtkullanici1.MaxLength = 10;
            this.txtkullanici1.Multiline = true;
            this.txtkullanici1.Name = "txtkullanici1";
            this.txtkullanici1.Size = new System.Drawing.Size(155, 20);
            this.txtkullanici1.TabIndex = 0;
            this.txtkullanici1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtsifre1
            // 
            this.txtsifre1.Location = new System.Drawing.Point(87, 101);
            this.txtsifre1.MaxLength = 10;
            this.txtsifre1.Name = "txtsifre1";
            this.txtsifre1.PasswordChar = '*';
            this.txtsifre1.Size = new System.Drawing.Size(155, 20);
            this.txtsifre1.TabIndex = 1;
            this.txtsifre1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.uye);
            this.groupBox1.Controls.Add(this.admin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtsifre1);
            this.groupBox1.Controls.Add(this.txtkullanici1);
            this.groupBox1.Location = new System.Drawing.Point(443, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 231);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "giriş";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(110, 218);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "kayıt ol";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // uye
            // 
            this.uye.BackColor = System.Drawing.Color.Yellow;
            this.uye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uye.ForeColor = System.Drawing.Color.Red;
            this.uye.Location = new System.Drawing.Point(149, 161);
            this.uye.Name = "uye";
            this.uye.Size = new System.Drawing.Size(102, 34);
            this.uye.TabIndex = 3;
            this.uye.Text = "üye";
            this.uye.UseVisualStyleBackColor = false;
            this.uye.Click += new System.EventHandler(this.uye_Click);
            // 
            // admin
            // 
            this.admin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.admin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.admin.Location = new System.Drawing.Point(42, 161);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(87, 34);
            this.admin.TabIndex = 2;
            this.admin.Text = "admin";
            this.admin.UseVisualStyleBackColor = false;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "kullanıcı adı";
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 469);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FİTNES KAYIT&GİRİŞ";
            this.Load += new System.EventHandler(this.frmlogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtkullanici1;
        private System.Windows.Forms.TextBox txtsifre1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button uye;
        private System.Windows.Forms.Button admin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

