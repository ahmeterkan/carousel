namespace atlikarinca
{
    partial class Form1
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
            this.lblCalismaSayisiR = new System.Windows.Forms.Label();
            this.lblGrupSayisiN = new System.Windows.Forms.Label();
            this.lblKapasiteK = new System.Windows.Forms.Label();
            this.txtCalismaSayisiR = new System.Windows.Forms.TextBox();
            this.txtGrupSayisiN = new System.Windows.Forms.TextBox();
            this.txtKapasiteK = new System.Windows.Forms.TextBox();
            this.btnTamam = new System.Windows.Forms.Button();
            this.lblGrupKisiSayisi = new System.Windows.Forms.Label();
            this.txtGrupKisiSayisi = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCalismaSayisiR
            // 
            this.lblCalismaSayisiR.AutoSize = true;
            this.lblCalismaSayisiR.Location = new System.Drawing.Point(164, 9);
            this.lblCalismaSayisiR.Name = "lblCalismaSayisiR";
            this.lblCalismaSayisiR.Size = new System.Drawing.Size(98, 13);
            this.lblCalismaSayisiR.TabIndex = 0;
            this.lblCalismaSayisiR.Text = "Çalıştırma Sayısı(R):";
            // 
            // lblGrupSayisiN
            // 
            this.lblGrupSayisiN.AutoSize = true;
            this.lblGrupSayisiN.Location = new System.Drawing.Point(110, 40);
            this.lblGrupSayisiN.Name = "lblGrupSayisiN";
            this.lblGrupSayisiN.Size = new System.Drawing.Size(152, 13);
            this.lblGrupSayisiN.TabIndex = 1;
            this.lblGrupSayisiN.Text = "Binmek İsteyen Grup Sayısı(N):";
            // 
            // lblKapasiteK
            // 
            this.lblKapasiteK.AutoSize = true;
            this.lblKapasiteK.Location = new System.Drawing.Point(19, 66);
            this.lblKapasiteK.Name = "lblKapasiteK";
            this.lblKapasiteK.Size = new System.Drawing.Size(243, 13);
            this.lblKapasiteK.TabIndex = 2;
            this.lblKapasiteK.Text = "Tek Seferde Atlı Karıncaya Binebilen Kişi Sayısı(k):";
            // 
            // txtCalismaSayisiR
            // 
            this.txtCalismaSayisiR.Location = new System.Drawing.Point(269, 6);
            this.txtCalismaSayisiR.Name = "txtCalismaSayisiR";
            this.txtCalismaSayisiR.Size = new System.Drawing.Size(100, 20);
            this.txtCalismaSayisiR.TabIndex = 3;
            this.txtCalismaSayisiR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCalismaSayisiR_KeyPress);
            // 
            // txtGrupSayisiN
            // 
            this.txtGrupSayisiN.Location = new System.Drawing.Point(269, 37);
            this.txtGrupSayisiN.Name = "txtGrupSayisiN";
            this.txtGrupSayisiN.Size = new System.Drawing.Size(100, 20);
            this.txtGrupSayisiN.TabIndex = 4;
            this.txtGrupSayisiN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGrupSayisiN_KeyPress);
            // 
            // txtKapasiteK
            // 
            this.txtKapasiteK.Location = new System.Drawing.Point(269, 63);
            this.txtKapasiteK.Name = "txtKapasiteK";
            this.txtKapasiteK.Size = new System.Drawing.Size(100, 20);
            this.txtKapasiteK.TabIndex = 5;
            this.txtKapasiteK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKapasiteK_KeyPress);
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(283, 89);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(75, 23);
            this.btnTamam.TabIndex = 6;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // lblGrupKisiSayisi
            // 
            this.lblGrupKisiSayisi.AutoSize = true;
            this.lblGrupKisiSayisi.Location = new System.Drawing.Point(160, 191);
            this.lblGrupKisiSayisi.Name = "lblGrupKisiSayisi";
            this.lblGrupKisiSayisi.Size = new System.Drawing.Size(102, 13);
            this.lblGrupKisiSayisi.TabIndex = 7;
            this.lblGrupKisiSayisi.Text = "Grupdaki Kişi Sayısı:";
            // 
            // txtGrupKisiSayisi
            // 
            this.txtGrupKisiSayisi.Location = new System.Drawing.Point(269, 191);
            this.txtGrupKisiSayisi.Name = "txtGrupKisiSayisi";
            this.txtGrupKisiSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtGrupKisiSayisi.TabIndex = 8;
            this.txtGrupKisiSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGrupKisiSayisi_KeyPress);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(283, 217);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(454, 139);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(126, 101);
            this.btnHesapla.TabIndex = 10;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 259);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtGrupKisiSayisi);
            this.Controls.Add(this.lblGrupKisiSayisi);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.txtKapasiteK);
            this.Controls.Add(this.txtGrupSayisiN);
            this.Controls.Add(this.txtCalismaSayisiR);
            this.Controls.Add(this.lblKapasiteK);
            this.Controls.Add(this.lblGrupSayisiN);
            this.Controls.Add(this.lblCalismaSayisiR);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalismaSayisiR;
        private System.Windows.Forms.Label lblGrupSayisiN;
        private System.Windows.Forms.Label lblKapasiteK;
        private System.Windows.Forms.TextBox txtCalismaSayisiR;
        private System.Windows.Forms.TextBox txtGrupSayisiN;
        private System.Windows.Forms.TextBox txtKapasiteK;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Label lblGrupKisiSayisi;
        private System.Windows.Forms.TextBox txtGrupKisiSayisi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnHesapla;
    }
}

