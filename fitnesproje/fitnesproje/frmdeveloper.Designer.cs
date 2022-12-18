namespace fitnesproje
{
    partial class frmdeveloper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdeveloper));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btncikis = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(682, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "HEY DEVELOPER HOSGELDİN KODTAKİ HATALAR İÇİN GELDİYSEN ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(683, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "LÜTFEN VERİTABANI HATALARINA BAK EMİNİM ORDA HATA VAR";
            // 
            // btncikis
            // 
            this.btncikis.BackColor = System.Drawing.Color.Maroon;
            this.btncikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncikis.ForeColor = System.Drawing.Color.Cornsilk;
            this.btncikis.Location = new System.Drawing.Point(888, 470);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(145, 95);
            this.btncikis.TabIndex = 1;
            this.btncikis.Text = "ÇIKIŞ";
            this.btncikis.UseVisualStyleBackColor = false;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // geri
            // 
            this.geri.BackColor = System.Drawing.Color.YellowGreen;
            this.geri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geri.Location = new System.Drawing.Point(-2, 470);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(163, 95);
            this.geri.TabIndex = 2;
            this.geri.Text = "geri";
            this.geri.UseVisualStyleBackColor = false;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // frmdeveloper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::fitnesproje.Properties.Resources.Screenshot_66_1_587x300;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1034, 566);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmdeveloper";
            this.Text = "frmdeveloper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Button geri;
    }
}