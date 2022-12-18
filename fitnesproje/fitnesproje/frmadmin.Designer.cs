namespace fitnesproje
{
    partial class frmadmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmadmin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.üyeİşleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maaşÖdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programVerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtgüncellesilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniÇalışanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanGünceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1022, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "MERHABA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1043, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "ADMİN";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(-2, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 80);
            this.button1.TabIndex = 2;
            this.button1.Text = "geri";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Moccasin;
            this.button2.Location = new System.Drawing.Point(1129, 536);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 80);
            this.button2.TabIndex = 2;
            this.button2.Text = "ÇIKIŞ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1272, 289);
            this.dataGridView1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.üyeİşleriToolStripMenuItem,
            this.kayıtgüncellesilToolStripMenuItem,
            this.çıkışİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1270, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // üyeİşleriToolStripMenuItem
            // 
            this.üyeİşleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maaşÖdeToolStripMenuItem,
            this.programVerToolStripMenuItem});
            this.üyeİşleriToolStripMenuItem.Name = "üyeİşleriToolStripMenuItem";
            this.üyeİşleriToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.üyeİşleriToolStripMenuItem.Text = "üye işleri";
            // 
            // maaşÖdeToolStripMenuItem
            // 
            this.maaşÖdeToolStripMenuItem.Name = "maaşÖdeToolStripMenuItem";
            this.maaşÖdeToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.maaşÖdeToolStripMenuItem.Text = "maaş öde";
            // 
            // programVerToolStripMenuItem
            // 
            this.programVerToolStripMenuItem.Name = "programVerToolStripMenuItem";
            this.programVerToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.programVerToolStripMenuItem.Text = "program ver";
            // 
            // kayıtgüncellesilToolStripMenuItem
            // 
            this.kayıtgüncellesilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniÇalışanToolStripMenuItem,
            this.çalışanGünceToolStripMenuItem,
            this.hesapSilToolStripMenuItem});
            this.kayıtgüncellesilToolStripMenuItem.Name = "kayıtgüncellesilToolStripMenuItem";
            this.kayıtgüncellesilToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.kayıtgüncellesilToolStripMenuItem.Text = "kayıt&güncelle&sil";
            // 
            // yeniÇalışanToolStripMenuItem
            // 
            this.yeniÇalışanToolStripMenuItem.Name = "yeniÇalışanToolStripMenuItem";
            this.yeniÇalışanToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.yeniÇalışanToolStripMenuItem.Text = "yeni hesap";
            this.yeniÇalışanToolStripMenuItem.Click += new System.EventHandler(this.yeniÇalışanToolStripMenuItem_Click);
            // 
            // çalışanGünceToolStripMenuItem
            // 
            this.çalışanGünceToolStripMenuItem.Name = "çalışanGünceToolStripMenuItem";
            this.çalışanGünceToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.çalışanGünceToolStripMenuItem.Text = "hesap güncelle";
            this.çalışanGünceToolStripMenuItem.Click += new System.EventHandler(this.çalışanGünceToolStripMenuItem_Click);
            // 
            // hesapSilToolStripMenuItem
            // 
            this.hesapSilToolStripMenuItem.Name = "hesapSilToolStripMenuItem";
            this.hesapSilToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.hesapSilToolStripMenuItem.Text = "hesap sil";
            this.hesapSilToolStripMenuItem.Click += new System.EventHandler(this.hesapSilToolStripMenuItem_Click);
            // 
            // çıkışİşlemleriToolStripMenuItem
            // 
            this.çıkışİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kilitleToolStripMenuItem,
            this.çıkışYapToolStripMenuItem});
            this.çıkışİşlemleriToolStripMenuItem.Name = "çıkışİşlemleriToolStripMenuItem";
            this.çıkışİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.çıkışİşlemleriToolStripMenuItem.Text = "çıkış işlemleri ";
            // 
            // kilitleToolStripMenuItem
            // 
            this.kilitleToolStripMenuItem.Name = "kilitleToolStripMenuItem";
            this.kilitleToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.kilitleToolStripMenuItem.Text = "kilitle";
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.çıkışYapToolStripMenuItem.Text = "çıkış yap";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::fitnesproje.Properties.Resources.unauthorized_person;
            this.pictureBox1.Location = new System.Drawing.Point(1152, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 617);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmadmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMİN";
            this.Load += new System.EventHandler(this.frmadmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem üyeİşleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maaşÖdeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programVerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtgüncellesilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniÇalışanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çalışanGünceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilitleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
    }
}