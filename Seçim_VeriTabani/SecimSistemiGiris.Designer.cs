namespace Seçim_VeriTabani
{
    partial class SecimSistemiGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecimSistemiGiris));
            this.picturegiris = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picturegiris)).BeginInit();
            this.SuspendLayout();
            // 
            // picturegiris
            // 
            this.picturegiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.picturegiris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picturegiris.Image = ((System.Drawing.Image)(resources.GetObject("picturegiris.Image")));
            this.picturegiris.Location = new System.Drawing.Point(0, 0);
            this.picturegiris.Name = "picturegiris";
            this.picturegiris.Size = new System.Drawing.Size(783, 563);
            this.picturegiris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturegiris.TabIndex = 1;
            this.picturegiris.TabStop = false;
            this.picturegiris.Click += new System.EventHandler(this.picturegiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Impact", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(286, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "SİSTEME GİR";
            // 
            // SecimSistemiGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(783, 563);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picturegiris);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SecimSistemiGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecimSistemiGiris";
            ((System.ComponentModel.ISupportInitialize)(this.picturegiris)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picturegiris;
        private System.Windows.Forms.Label label1;
    }
}