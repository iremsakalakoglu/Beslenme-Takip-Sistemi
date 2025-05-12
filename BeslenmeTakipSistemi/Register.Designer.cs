namespace BeslenmeTakipSistemi
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.RegisterBackground = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbCinsiyet = new System.Windows.Forms.ComboBox();
            this.dateTimeDg = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKayıt = new System.Windows.Forms.Button();
            this.rbregSifreTekrar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRegSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbregmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSoyad = new System.Windows.Forms.TextBox();
            this.rgSoyisim = new System.Windows.Forms.Label();
            this.tbAd = new System.Windows.Forms.TextBox();
            this.rgAd = new System.Windows.Forms.Label();
            this.kayit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterBackground)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegisterBackground
            // 
            this.RegisterBackground.Image = ((System.Drawing.Image)(resources.GetObject("RegisterBackground.Image")));
            this.RegisterBackground.Location = new System.Drawing.Point(0, 0);
            this.RegisterBackground.Name = "RegisterBackground";
            this.RegisterBackground.Size = new System.Drawing.Size(621, 347);
            this.RegisterBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RegisterBackground.TabIndex = 0;
            this.RegisterBackground.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbCinsiyet);
            this.panel2.Controls.Add(this.dateTimeDg);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnKayıt);
            this.panel2.Controls.Add(this.rbregSifreTekrar);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbRegSifre);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbregmail);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbSoyad);
            this.panel2.Controls.Add(this.rgSoyisim);
            this.panel2.Controls.Add(this.tbAd);
            this.panel2.Controls.Add(this.rgAd);
            this.panel2.Controls.Add(this.kayit);
            this.panel2.Location = new System.Drawing.Point(12, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 311);
            this.panel2.TabIndex = 2;
            // 
            // cbCinsiyet
            // 
            this.cbCinsiyet.FormattingEnabled = true;
            this.cbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cbCinsiyet.Location = new System.Drawing.Point(124, 115);
            this.cbCinsiyet.Name = "cbCinsiyet";
            this.cbCinsiyet.Size = new System.Drawing.Size(100, 21);
            this.cbCinsiyet.TabIndex = 18;
            // 
            // dateTimeDg
            // 
            this.dateTimeDg.Location = new System.Drawing.Point(18, 116);
            this.dateTimeDg.Name = "dateTimeDg";
            this.dateTimeDg.Size = new System.Drawing.Size(97, 20);
            this.dateTimeDg.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Doğum Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cinsiyet:";
            // 
            // btnKayıt
            // 
            this.btnKayıt.BackColor = System.Drawing.Color.DarkGray;
            this.btnKayıt.Location = new System.Drawing.Point(79, 274);
            this.btnKayıt.Name = "btnKayıt";
            this.btnKayıt.Size = new System.Drawing.Size(80, 28);
            this.btnKayıt.TabIndex = 14;
            this.btnKayıt.Text = "Kayıt Ol";
            this.btnKayıt.UseVisualStyleBackColor = false;
            this.btnKayıt.Click += new System.EventHandler(this.btnKayıt_Click);
            // 
            // rbregSifreTekrar
            // 
            this.rbregSifreTekrar.Location = new System.Drawing.Point(18, 241);
            this.rbregSifreTekrar.Name = "rbregSifreTekrar";
            this.rbregSifreTekrar.PasswordChar = '*';
            this.rbregSifreTekrar.Size = new System.Drawing.Size(206, 20);
            this.rbregSifreTekrar.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Şifre Tekrar:";
            // 
            // tbRegSifre
            // 
            this.tbRegSifre.Location = new System.Drawing.Point(18, 200);
            this.tbRegSifre.Name = "tbRegSifre";
            this.tbRegSifre.PasswordChar = '*';
            this.tbRegSifre.Size = new System.Drawing.Size(206, 20);
            this.tbRegSifre.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Şifre:";
            // 
            // tbregmail
            // 
            this.tbregmail.Location = new System.Drawing.Point(18, 162);
            this.tbregmail.Name = "tbregmail";
            this.tbregmail.Size = new System.Drawing.Size(206, 20);
            this.tbregmail.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "E-Mail:";
            // 
            // tbSoyad
            // 
            this.tbSoyad.Location = new System.Drawing.Point(124, 60);
            this.tbSoyad.Name = "tbSoyad";
            this.tbSoyad.Size = new System.Drawing.Size(100, 20);
            this.tbSoyad.TabIndex = 5;
            // 
            // rgSoyisim
            // 
            this.rgSoyisim.AutoSize = true;
            this.rgSoyisim.Location = new System.Drawing.Point(121, 44);
            this.rgSoyisim.Name = "rgSoyisim";
            this.rgSoyisim.Size = new System.Drawing.Size(45, 13);
            this.rgSoyisim.TabIndex = 4;
            this.rgSoyisim.Text = "Soyisim:";
            // 
            // tbAd
            // 
            this.tbAd.Location = new System.Drawing.Point(18, 60);
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(100, 20);
            this.tbAd.TabIndex = 3;
            // 
            // rgAd
            // 
            this.rgAd.AutoSize = true;
            this.rgAd.Location = new System.Drawing.Point(15, 44);
            this.rgAd.Name = "rgAd";
            this.rgAd.Size = new System.Drawing.Size(28, 13);
            this.rgAd.TabIndex = 2;
            this.rgAd.Text = "İsim:";
            // 
            // kayit
            // 
            this.kayit.AutoSize = true;
            this.kayit.Font = new System.Drawing.Font("NSimSun", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayit.Location = new System.Drawing.Point(74, 12);
            this.kayit.Name = "kayit";
            this.kayit.Size = new System.Drawing.Size(87, 27);
            this.kayit.TabIndex = 1;
            this.kayit.Text = "KAYIT";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 23);
            this.panel1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(15, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Beslenme Takip Sistemi \r\n";
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_exit.Location = new System.Drawing.Point(598, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(23, 23);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 347);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.RegisterBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.RegisterBackground)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox RegisterBackground;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label kayit;
        private System.Windows.Forms.Label rgSoyisim;
        private System.Windows.Forms.TextBox tbAd;
        private System.Windows.Forms.Label rgAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbregmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSoyad;
        private System.Windows.Forms.TextBox rbregSifreTekrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRegSifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKayıt;
        private System.Windows.Forms.DateTimePicker dateTimeDg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCinsiyet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label6;
    }
}