
namespace VTY
{
    partial class Anasayfa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.randevuBilgi = new System.Windows.Forms.Button();
            this.ameliyathane = new System.Windows.Forms.Button();
            this.acilServis = new System.Windows.Forms.Button();
            this.ilac = new System.Windows.Forms.Button();
            this.kanIstekleri = new System.Windows.Forms.Button();
            this.poliklinik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // randevuBilgi
            // 
            this.randevuBilgi.Location = new System.Drawing.Point(121, 59);
            this.randevuBilgi.Name = "randevuBilgi";
            this.randevuBilgi.Size = new System.Drawing.Size(139, 66);
            this.randevuBilgi.TabIndex = 0;
            this.randevuBilgi.Text = "Randevu Bilgileri";
            this.randevuBilgi.UseVisualStyleBackColor = true;
            this.randevuBilgi.Click += new System.EventHandler(this.randevuBilgi_Click);
            // 
            // ameliyathane
            // 
            this.ameliyathane.Location = new System.Drawing.Point(352, 59);
            this.ameliyathane.Name = "ameliyathane";
            this.ameliyathane.Size = new System.Drawing.Size(127, 66);
            this.ameliyathane.TabIndex = 1;
            this.ameliyathane.Text = "Ameliyathane Modülü";
            this.ameliyathane.UseVisualStyleBackColor = true;
            this.ameliyathane.Click += new System.EventHandler(this.ameliyathane_Click);
            // 
            // acilServis
            // 
            this.acilServis.Location = new System.Drawing.Point(579, 59);
            this.acilServis.Name = "acilServis";
            this.acilServis.Size = new System.Drawing.Size(134, 66);
            this.acilServis.TabIndex = 2;
            this.acilServis.Text = "Acil Servis Modülü";
            this.acilServis.UseVisualStyleBackColor = true;
            this.acilServis.Click += new System.EventHandler(this.acilServis_Click);
            // 
            // ilac
            // 
            this.ilac.Location = new System.Drawing.Point(352, 178);
            this.ilac.Name = "ilac";
            this.ilac.Size = new System.Drawing.Size(127, 65);
            this.ilac.TabIndex = 6;
            this.ilac.Text = "İlaç Modülü";
            this.ilac.UseVisualStyleBackColor = true;
            this.ilac.Click += new System.EventHandler(this.ilac_Click);
            // 
            // kanIstekleri
            // 
            this.kanIstekleri.Location = new System.Drawing.Point(565, 172);
            this.kanIstekleri.Name = "kanIstekleri";
            this.kanIstekleri.Size = new System.Drawing.Size(139, 71);
            this.kanIstekleri.TabIndex = 7;
            this.kanIstekleri.Text = "Kan İstekleri";
            this.kanIstekleri.UseVisualStyleBackColor = true;
            this.kanIstekleri.Click += new System.EventHandler(this.kanIstekleri_Click);
            // 
            // poliklinik
            // 
            this.poliklinik.Location = new System.Drawing.Point(131, 178);
            this.poliklinik.Name = "poliklinik";
            this.poliklinik.Size = new System.Drawing.Size(139, 65);
            this.poliklinik.TabIndex = 9;
            this.poliklinik.Text = "Poliklinik-Klinik";
            this.poliklinik.UseVisualStyleBackColor = true;
            this.poliklinik.Click += new System.EventHandler(this.poliklinik_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 507);
            this.Controls.Add(this.poliklinik);
            this.Controls.Add(this.kanIstekleri);
            this.Controls.Add(this.ilac);
            this.Controls.Add(this.acilServis);
            this.Controls.Add(this.ameliyathane);
            this.Controls.Add(this.randevuBilgi);
            this.Name = "Anasayfa";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button randevuBilgi;
        private System.Windows.Forms.Button ameliyathane;
        private System.Windows.Forms.Button acilServis;
        private System.Windows.Forms.Button ilac;
        private System.Windows.Forms.Button kanIstekleri;
        private System.Windows.Forms.Button poliklinik;
    }
}

