﻿namespace Proje_Hastane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnHastaGirişi = new System.Windows.Forms.Button();
            this.btnDoktorGirişi = new System.Windows.Forms.Button();
            this.btnSekreterGirişi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHastaGirişi
            // 
            this.btnHastaGirişi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHastaGirişi.BackgroundImage")));
            this.btnHastaGirişi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHastaGirişi.Location = new System.Drawing.Point(63, 191);
            this.btnHastaGirişi.Name = "btnHastaGirişi";
            this.btnHastaGirişi.Size = new System.Drawing.Size(128, 128);
            this.btnHastaGirişi.TabIndex = 0;
            this.btnHastaGirişi.UseVisualStyleBackColor = true;
            this.btnHastaGirişi.Click += new System.EventHandler(this.btnHastaGirişi_Click);
            // 
            // btnDoktorGirişi
            // 
            this.btnDoktorGirişi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDoktorGirişi.BackgroundImage")));
            this.btnDoktorGirişi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoktorGirişi.Location = new System.Drawing.Point(264, 191);
            this.btnDoktorGirişi.Name = "btnDoktorGirişi";
            this.btnDoktorGirişi.Size = new System.Drawing.Size(128, 128);
            this.btnDoktorGirişi.TabIndex = 1;
            this.btnDoktorGirişi.UseVisualStyleBackColor = true;
            this.btnDoktorGirişi.Click += new System.EventHandler(this.btnDoktorGirişi_Click);
            // 
            // btnSekreterGirişi
            // 
            this.btnSekreterGirişi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSekreterGirişi.BackgroundImage")));
            this.btnSekreterGirişi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSekreterGirişi.Location = new System.Drawing.Point(464, 191);
            this.btnSekreterGirişi.Name = "btnSekreterGirişi";
            this.btnSekreterGirişi.Size = new System.Drawing.Size(128, 128);
            this.btnSekreterGirişi.TabIndex = 2;
            this.btnSekreterGirişi.UseVisualStyleBackColor = true;
            this.btnSekreterGirişi.Click += new System.EventHandler(this.btnSekreterGirişi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(66, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(272, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(467, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreter";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(505, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(439, 53);
            this.label4.TabIndex = 7;
            this.label4.Text = "SEA GREEN HOSPİTAL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSekreterGirişi);
            this.Controls.Add(this.btnDoktorGirişi);
            this.Controls.Add(this.btnHastaGirişi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Sea Green Hospital Giris";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHastaGirişi;
        private System.Windows.Forms.Button btnDoktorGirişi;
        private System.Windows.Forms.Button btnSekreterGirişi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

