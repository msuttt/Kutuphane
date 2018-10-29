namespace Kutuphane
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.txtkullanici = new System.Windows.Forms.TextBox();
            this.lblkullanici = new System.Windows.Forms.Label();
            this.lblsifre = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.lblhosgeldin = new System.Windows.Forms.Label();
            this.linkyonetici = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtkullanici
            // 
            this.txtkullanici.ForeColor = System.Drawing.Color.Maroon;
            this.txtkullanici.Location = new System.Drawing.Point(299, 140);
            this.txtkullanici.Name = "txtkullanici";
            this.txtkullanici.Size = new System.Drawing.Size(138, 20);
            this.txtkullanici.TabIndex = 0;
            // 
            // lblkullanici
            // 
            this.lblkullanici.AutoSize = true;
            this.lblkullanici.BackColor = System.Drawing.Color.Transparent;
            this.lblkullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkullanici.ForeColor = System.Drawing.Color.LightGreen;
            this.lblkullanici.Location = new System.Drawing.Point(131, 135);
            this.lblkullanici.Name = "lblkullanici";
            this.lblkullanici.Size = new System.Drawing.Size(132, 24);
            this.lblkullanici.TabIndex = 1;
            this.lblkullanici.Text = "Kullanıcı Adı:";
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.BackColor = System.Drawing.Color.Transparent;
            this.lblsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsifre.ForeColor = System.Drawing.Color.LightGreen;
            this.lblsifre.Location = new System.Drawing.Point(205, 206);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(58, 24);
            this.lblsifre.TabIndex = 2;
            this.lblsifre.Text = "Şifre:";
            // 
            // txtsifre
            // 
            this.txtsifre.ForeColor = System.Drawing.Color.Maroon;
            this.txtsifre.Location = new System.Drawing.Point(299, 206);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(138, 20);
            this.txtsifre.TabIndex = 3;
            // 
            // lblhosgeldin
            // 
            this.lblhosgeldin.AutoSize = true;
            this.lblhosgeldin.BackColor = System.Drawing.Color.Transparent;
            this.lblhosgeldin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblhosgeldin.ForeColor = System.Drawing.Color.Lime;
            this.lblhosgeldin.Location = new System.Drawing.Point(131, 26);
            this.lblhosgeldin.Name = "lblhosgeldin";
            this.lblhosgeldin.Size = new System.Drawing.Size(332, 24);
            this.lblhosgeldin.TabIndex = 4;
            this.lblhosgeldin.Text = "KÜTÜPHANEMİZE HOŞGELDİNİZ!";
            // 
            // linkyonetici
            // 
            this.linkyonetici.AutoSize = true;
            this.linkyonetici.BackColor = System.Drawing.Color.Transparent;
            this.linkyonetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkyonetici.ForeColor = System.Drawing.Color.Bisque;
            this.linkyonetici.Location = new System.Drawing.Point(455, 348);
            this.linkyonetici.Name = "linkyonetici";
            this.linkyonetici.Size = new System.Drawing.Size(168, 24);
            this.linkyonetici.TabIndex = 5;
            this.linkyonetici.TabStop = true;
            this.linkyonetici.Text = "YÖNETİCİ GİRİŞİ";
            this.linkyonetici.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkyonetici_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(313, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Giriş";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel1.Location = new System.Drawing.Point(12, 359);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(202, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Kayıtlı değilseniz buradan kayıt olabilirsiniz";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(635, 398);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkyonetici);
            this.Controls.Add(this.lblhosgeldin);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.lblkullanici);
            this.Controls.Add(this.txtkullanici);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtkullanici;
        private System.Windows.Forms.Label lblkullanici;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Label lblhosgeldin;
        private System.Windows.Forms.LinkLabel linkyonetici;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}