namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.vakifadi = new System.Windows.Forms.TextBox();
            this.uyeno = new System.Windows.Forms.TextBox();
            this.uyead = new System.Windows.Forms.TextBox();
            this.vakifuyesayisi = new System.Windows.Forms.TextBox();
            this.uyetel = new System.Windows.Forms.TextBox();
            this.uyeyas = new System.Windows.Forms.TextBox();
            this.uyedogum = new System.Windows.Forms.TextBox();
            this.vakifkayit = new System.Windows.Forms.Button();
            this.uyekayıt = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.aidatodeme = new System.Windows.Forms.Button();
            this.uyeaidatodememik = new System.Windows.Forms.TextBox();
            this.giderekle = new System.Windows.Forms.Button();
            this.vakifgidertl = new System.Windows.Forms.TextBox();
            this.vakifgider = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.uyeaidatisim = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.hesapsorgula = new System.Windows.Forms.Button();
            this.uyegoster = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.uyesec = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(50, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "VAKIF OLUŞTURMA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "VAKIF ADI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "VAKIF ÜYE SAYISI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(52, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "ÜYE KAYIT EKRANI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "ÜYE ADI SOYADI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "ÜYE NO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "ÜYE DOĞUM YILI";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "ÜYE YAŞ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "ÜYE TEL";
            // 
            // vakifadi
            // 
            this.vakifadi.Location = new System.Drawing.Point(166, 76);
            this.vakifadi.Name = "vakifadi";
            this.vakifadi.Size = new System.Drawing.Size(158, 22);
            this.vakifadi.TabIndex = 9;
            // 
            // uyeno
            // 
            this.uyeno.Location = new System.Drawing.Point(166, 271);
            this.uyeno.Name = "uyeno";
            this.uyeno.Size = new System.Drawing.Size(158, 22);
            this.uyeno.TabIndex = 10;
            // 
            // uyead
            // 
            this.uyead.Location = new System.Drawing.Point(166, 238);
            this.uyead.Name = "uyead";
            this.uyead.Size = new System.Drawing.Size(158, 22);
            this.uyead.TabIndex = 11;
            // 
            // vakifuyesayisi
            // 
            this.vakifuyesayisi.Location = new System.Drawing.Point(166, 109);
            this.vakifuyesayisi.Name = "vakifuyesayisi";
            this.vakifuyesayisi.Size = new System.Drawing.Size(158, 22);
            this.vakifuyesayisi.TabIndex = 12;
            // 
            // uyetel
            // 
            this.uyetel.Location = new System.Drawing.Point(166, 360);
            this.uyetel.Name = "uyetel";
            this.uyetel.Size = new System.Drawing.Size(158, 22);
            this.uyetel.TabIndex = 13;
            // 
            // uyeyas
            // 
            this.uyeyas.Location = new System.Drawing.Point(166, 329);
            this.uyeyas.Name = "uyeyas";
            this.uyeyas.Size = new System.Drawing.Size(158, 22);
            this.uyeyas.TabIndex = 14;
            // 
            // uyedogum
            // 
            this.uyedogum.Location = new System.Drawing.Point(166, 300);
            this.uyedogum.Name = "uyedogum";
            this.uyedogum.Size = new System.Drawing.Size(158, 22);
            this.uyedogum.TabIndex = 15;
            // 
            // vakifkayit
            // 
            this.vakifkayit.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.vakifkayit.Location = new System.Drawing.Point(362, 75);
            this.vakifkayit.Name = "vakifkayit";
            this.vakifkayit.Size = new System.Drawing.Size(143, 58);
            this.vakifkayit.TabIndex = 16;
            this.vakifkayit.Text = "VAKIF KAYIT";
            this.vakifkayit.UseVisualStyleBackColor = true;
            this.vakifkayit.Click += new System.EventHandler(this.vakifkayit_Click);
            // 
            // uyekayıt
            // 
            this.uyekayıt.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyekayıt.Location = new System.Drawing.Point(362, 285);
            this.uyekayıt.Name = "uyekayıt";
            this.uyekayıt.Size = new System.Drawing.Size(143, 55);
            this.uyekayıt.TabIndex = 17;
            this.uyekayıt.Text = "ÜYE KAYIT";
            this.uyekayıt.UseVisualStyleBackColor = true;
            this.uyekayıt.Click += new System.EventHandler(this.uyekayıt_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(614, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(212, 29);
            this.label13.TabIndex = 18;
            this.label13.Text = "ÜYE AİDAT ÖDEME";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(593, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "ÜYE ADI SOYADI";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(593, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "ÖDEME MİKTARI";
            // 
            // aidatodeme
            // 
            this.aidatodeme.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aidatodeme.Location = new System.Drawing.Point(902, 75);
            this.aidatodeme.Name = "aidatodeme";
            this.aidatodeme.Size = new System.Drawing.Size(143, 63);
            this.aidatodeme.TabIndex = 24;
            this.aidatodeme.Text = "AİDAT ÖDEME";
            this.aidatodeme.UseVisualStyleBackColor = true;
            this.aidatodeme.Click += new System.EventHandler(this.aidatodeme_Click);
            // 
            // uyeaidatodememik
            // 
            this.uyeaidatodememik.Location = new System.Drawing.Point(730, 111);
            this.uyeaidatodememik.Name = "uyeaidatodememik";
            this.uyeaidatodememik.Size = new System.Drawing.Size(158, 22);
            this.uyeaidatodememik.TabIndex = 23;
            // 
            // giderekle
            // 
            this.giderekle.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giderekle.Location = new System.Drawing.Point(902, 238);
            this.giderekle.Name = "giderekle";
            this.giderekle.Size = new System.Drawing.Size(143, 55);
            this.giderekle.TabIndex = 30;
            this.giderekle.Text = "GİDER EKLE";
            this.giderekle.UseVisualStyleBackColor = true;
            this.giderekle.Click += new System.EventHandler(this.giderekle_Click);
            // 
            // vakifgidertl
            // 
            this.vakifgidertl.Location = new System.Drawing.Point(730, 271);
            this.vakifgidertl.Name = "vakifgidertl";
            this.vakifgidertl.Size = new System.Drawing.Size(158, 22);
            this.vakifgidertl.TabIndex = 29;
            // 
            // vakifgider
            // 
            this.vakifgider.Location = new System.Drawing.Point(730, 238);
            this.vakifgider.Name = "vakifgider";
            this.vakifgider.Size = new System.Drawing.Size(158, 22);
            this.vakifgider.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(593, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "GİDER MİKTARI";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(593, 244);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 16);
            this.label14.TabIndex = 26;
            this.label14.Text = "GİDER AÇIKLAMASI";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(614, 197);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(159, 29);
            this.label15.TabIndex = 25;
            this.label15.Text = "VAKIF GİDER ";
            // 
            // uyeaidatisim
            // 
            this.uyeaidatisim.FormattingEnabled = true;
            this.uyeaidatisim.Location = new System.Drawing.Point(730, 76);
            this.uyeaidatisim.Name = "uyeaidatisim";
            this.uyeaidatisim.Size = new System.Drawing.Size(158, 24);
            this.uyeaidatisim.TabIndex = 31;
            this.uyeaidatisim.SelectedIndexChanged += new System.EventHandler(this.uyeaidatno_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(614, 455);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(326, 29);
            this.label16.TabIndex = 32;
            this.label16.Text = "HESAP CÜZDANI SORGULAMA";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(592, 497);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(210, 20);
            this.label17.TabIndex = 33;
            this.label17.Text = "HESAP CÜZDANI NEDİR?";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(649, 517);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(343, 32);
            this.label18.TabIndex = 34;
            this.label18.Text = "Hesap Cüzdanı, vakıf dernek gibi kuruluşların gelir - gider\r\nfarkının gösterildiğ" +
    "i basit bir ekrandır. ";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hesapsorgula
            // 
            this.hesapsorgula.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesapsorgula.Location = new System.Drawing.Point(700, 570);
            this.hesapsorgula.Name = "hesapsorgula";
            this.hesapsorgula.Size = new System.Drawing.Size(143, 82);
            this.hesapsorgula.TabIndex = 35;
            this.hesapsorgula.Text = "HESAP CÜZDANI SORGULA";
            this.hesapsorgula.UseVisualStyleBackColor = true;
            this.hesapsorgula.Click += new System.EventHandler(this.hesapsorgula_Click);
            // 
            // uyegoster
            // 
            this.uyegoster.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyegoster.Location = new System.Drawing.Point(166, 517);
            this.uyegoster.Name = "uyegoster";
            this.uyegoster.Size = new System.Drawing.Size(143, 72);
            this.uyegoster.TabIndex = 47;
            this.uyegoster.Text = "BİLGİLERİ GÖSTER";
            this.uyegoster.UseVisualStyleBackColor = true;
            this.uyegoster.Click += new System.EventHandler(this.uyegoster_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(29, 470);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(113, 16);
            this.label23.TabIndex = 37;
            this.label23.Text = "ÜYE ADI SOYADI";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.Location = new System.Drawing.Point(52, 420);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(169, 29);
            this.label24.TabIndex = 36;
            this.label24.Text = "ÜYE BİLGİLERİ";
            // 
            // uyesec
            // 
            this.uyesec.FormattingEnabled = true;
            this.uyesec.Location = new System.Drawing.Point(166, 462);
            this.uyesec.Name = "uyesec";
            this.uyesec.Size = new System.Drawing.Size(158, 24);
            this.uyesec.TabIndex = 48;
            this.uyesec.SelectedIndexChanged += new System.EventHandler(this.uyesec_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1071, 698);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.uyesec);
            this.Controls.Add(this.hesapsorgula);
            this.Controls.Add(this.uyegoster);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.uyeaidatisim);
            this.Controls.Add(this.giderekle);
            this.Controls.Add(this.vakifgidertl);
            this.Controls.Add(this.vakifgider);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.aidatodeme);
            this.Controls.Add(this.uyeaidatodememik);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.uyekayıt);
            this.Controls.Add(this.vakifkayit);
            this.Controls.Add(this.uyedogum);
            this.Controls.Add(this.uyeyas);
            this.Controls.Add(this.uyetel);
            this.Controls.Add(this.vakifuyesayisi);
            this.Controls.Add(this.uyead);
            this.Controls.Add(this.uyeno);
            this.Controls.Add(this.vakifadi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "VAKIF DERNEK OTOMASYONU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox vakifadi;
        private System.Windows.Forms.TextBox uyeno;
        private System.Windows.Forms.TextBox uyead;
        private System.Windows.Forms.TextBox vakifuyesayisi;
        private System.Windows.Forms.TextBox uyetel;
        private System.Windows.Forms.TextBox uyeyas;
        private System.Windows.Forms.TextBox uyedogum;
        private System.Windows.Forms.Button vakifkayit;
        private System.Windows.Forms.Button uyekayıt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button aidatodeme;
        private System.Windows.Forms.TextBox uyeaidatodememik;
        private System.Windows.Forms.Button giderekle;
        private System.Windows.Forms.TextBox vakifgidertl;
        private System.Windows.Forms.TextBox vakifgider;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox uyeaidatisim;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button hesapsorgula;
        private System.Windows.Forms.Button uyegoster;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox uyesec;
    }
}

