namespace Seçim_VeriTabani
{
    partial class OyGiris
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
            this.txtaparti = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbparti = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcparti = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdparti = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txteparti = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btngrafik = new System.Windows.Forms.Button();
            this.btntemizle = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.cmbsehir = new System.Windows.Forms.ComboBox();
            this.lnksehir = new System.Windows.Forms.LinkLabel();
            this.btncikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(42, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ŞEHİR :";
            // 
            // txtaparti
            // 
            this.txtaparti.Location = new System.Drawing.Point(119, 87);
            this.txtaparti.Name = "txtaparti";
            this.txtaparti.Size = new System.Drawing.Size(286, 32);
            this.txtaparti.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "A PARTİ :";
            // 
            // txtbparti
            // 
            this.txtbparti.Location = new System.Drawing.Point(119, 125);
            this.txtbparti.Name = "txtbparti";
            this.txtbparti.Size = new System.Drawing.Size(286, 32);
            this.txtbparti.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(32, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "B PARTİ:";
            // 
            // txtcparti
            // 
            this.txtcparti.Location = new System.Drawing.Point(119, 163);
            this.txtcparti.Name = "txtcparti";
            this.txtcparti.Size = new System.Drawing.Size(286, 32);
            this.txtcparti.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(28, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "C PARTİ :";
            // 
            // txtdparti
            // 
            this.txtdparti.Location = new System.Drawing.Point(119, 201);
            this.txtdparti.Name = "txtdparti";
            this.txtdparti.Size = new System.Drawing.Size(286, 32);
            this.txtdparti.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(27, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "D PARTİ :";
            // 
            // txteparti
            // 
            this.txteparti.Location = new System.Drawing.Point(119, 239);
            this.txteparti.Name = "txteparti";
            this.txteparti.Size = new System.Drawing.Size(286, 32);
            this.txteparti.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(29, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "E PARTİ :";
            // 
            // btngrafik
            // 
            this.btngrafik.Location = new System.Drawing.Point(414, 148);
            this.btngrafik.Name = "btngrafik";
            this.btngrafik.Size = new System.Drawing.Size(182, 37);
            this.btngrafik.TabIndex = 14;
            this.btngrafik.Text = "GRAFİKLER";
            this.btngrafik.UseVisualStyleBackColor = true;
            this.btngrafik.Click += new System.EventHandler(this.btngrafik_Click);
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(414, 191);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(182, 37);
            this.btntemizle.TabIndex = 15;
            this.btntemizle.Text = "TEMİZLE";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(119, 277);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(286, 37);
            this.btnguncelle.TabIndex = 16;
            this.btnguncelle.Text = "YENİ OY GİRİŞİ ";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // cmbsehir
            // 
            this.cmbsehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsehir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbsehir.FormattingEnabled = true;
            this.cmbsehir.Location = new System.Drawing.Point(119, 35);
            this.cmbsehir.Name = "cmbsehir";
            this.cmbsehir.Size = new System.Drawing.Size(286, 32);
            this.cmbsehir.TabIndex = 17;
            // 
            // lnksehir
            // 
            this.lnksehir.AutoSize = true;
            this.lnksehir.Font = new System.Drawing.Font("Corbel", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnksehir.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnksehir.LinkColor = System.Drawing.Color.Blue;
            this.lnksehir.Location = new System.Drawing.Point(411, 45);
            this.lnksehir.Name = "lnksehir";
            this.lnksehir.Size = new System.Drawing.Size(106, 15);
            this.lnksehir.TabIndex = 18;
            this.lnksehir.TabStop = true;
            this.lnksehir.Text = "YENİ ŞEHİR EKLE";
            this.lnksehir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnksehir_LinkClicked);
            // 
            // btncikis
            // 
            this.btncikis.Font = new System.Drawing.Font("Corbel", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncikis.Location = new System.Drawing.Point(518, 12);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(75, 23);
            this.btncikis.TabIndex = 20;
            this.btncikis.Text = "ÇIKIŞ";
            this.btncikis.UseVisualStyleBackColor = true;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // OyGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(605, 340);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.lnksehir);
            this.Controls.Add(this.cmbsehir);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.btngrafik);
            this.Controls.Add(this.txteparti);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdparti);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcparti);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbparti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtaparti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "OyGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SEÇİM SİSTEMİ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtaparti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbparti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcparti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdparti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txteparti;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btngrafik;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.ComboBox cmbsehir;
        private System.Windows.Forms.LinkLabel lnksehir;
        private System.Windows.Forms.Button btncikis;
    }
}

