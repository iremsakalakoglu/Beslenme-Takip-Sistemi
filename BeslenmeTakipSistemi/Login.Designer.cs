namespace BeslenmeTakipSistemi
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.loginBackground = new System.Windows.Forms.PictureBox();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cbSifreGoster = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkRegister = new System.Windows.Forms.LinkLabel();
            this.btnGiris = new System.Windows.Forms.Button();
            this.tbSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.giris = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_ext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loginBackground)).BeginInit();
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBackground
            // 
            this.loginBackground.Image = ((System.Drawing.Image)(resources.GetObject("loginBackground.Image")));
            this.loginBackground.Location = new System.Drawing.Point(0, -1);
            this.loginBackground.Name = "loginBackground";
            this.loginBackground.Size = new System.Drawing.Size(621, 347);
            this.loginBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginBackground.TabIndex = 0;
            this.loginBackground.TabStop = false;
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.pictureBox3);
            this.loginPanel.Controls.Add(this.cbSifreGoster);
            this.loginPanel.Controls.Add(this.pictureBox2);
            this.loginPanel.Controls.Add(this.pictureBox1);
            this.loginPanel.Controls.Add(this.linkRegister);
            this.loginPanel.Controls.Add(this.btnGiris);
            this.loginPanel.Controls.Add(this.tbSifre);
            this.loginPanel.Controls.Add(this.label3);
            this.loginPanel.Controls.Add(this.tbMail);
            this.loginPanel.Controls.Add(this.email);
            this.loginPanel.Controls.Add(this.giris);
            this.loginPanel.Location = new System.Drawing.Point(358, 29);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(240, 311);
            this.loginPanel.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(88, 170);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 14);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // cbSifreGoster
            // 
            this.cbSifreGoster.AutoSize = true;
            this.cbSifreGoster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbSifreGoster.Location = new System.Drawing.Point(109, 170);
            this.cbSifreGoster.Name = "cbSifreGoster";
            this.cbSifreGoster.Size = new System.Drawing.Size(88, 17);
            this.cbSifreGoster.TabIndex = 11;
            this.cbSifreGoster.Text = "Şifreyi Göster";
            this.cbSifreGoster.UseVisualStyleBackColor = true;
            this.cbSifreGoster.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(34, 147);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 14);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 14);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // linkRegister
            // 
            this.linkRegister.AutoSize = true;
            this.linkRegister.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkRegister.Location = new System.Drawing.Point(72, 284);
            this.linkRegister.Name = "linkRegister";
            this.linkRegister.Size = new System.Drawing.Size(96, 13);
            this.linkRegister.TabIndex = 8;
            this.linkRegister.TabStop = true;
            this.linkRegister.Text = "Hesabınız yok mu?";
            this.linkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegister_LinkClicked);
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.DarkGray;
            this.btnGiris.Location = new System.Drawing.Point(88, 208);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(80, 28);
            this.btnGiris.TabIndex = 7;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = false;
            // 
            // tbSifre
            // 
            this.tbSifre.Location = new System.Drawing.Point(62, 146);
            this.tbSifre.Name = "tbSifre";
            this.tbSifre.PasswordChar = '*';
            this.tbSifre.Size = new System.Drawing.Size(131, 20);
            this.tbSifre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şifre";
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(62, 95);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(131, 20);
            this.tbMail.TabIndex = 3;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(102, 79);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(36, 13);
            this.email.TabIndex = 1;
            this.email.Text = "E-Mail";
            // 
            // giris
            // 
            this.giris.AutoSize = true;
            this.giris.Font = new System.Drawing.Font("NSimSun", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giris.Location = new System.Drawing.Point(81, 22);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(87, 27);
            this.giris.TabIndex = 0;
            this.giris.Text = "GİRİŞ ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 23);
            this.panel1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(15, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Beslenme Takip Sistemi \r\n";
            // 
            // btn_ext
            // 
            this.btn_ext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ext.BackgroundImage")));
            this.btn_ext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ext.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_ext.Location = new System.Drawing.Point(598, 0);
            this.btn_ext.Name = "btn_ext";
            this.btn_ext.Size = new System.Drawing.Size(23, 23);
            this.btn_ext.TabIndex = 6;
            this.btn_ext.UseVisualStyleBackColor = true;
            this.btn_ext.Click += new System.EventHandler(this.btn_ext_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 346);
            this.Controls.Add(this.btn_ext);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.loginBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.loginBackground)).EndInit();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox loginBackground;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label giris;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox tbSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkRegister;
        private System.Windows.Forms.CheckBox cbSifreGoster;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_ext;
    }
}