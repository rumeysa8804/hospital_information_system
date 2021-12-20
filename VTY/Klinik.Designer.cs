
namespace VTY
{
    partial class Form7
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.p_id = new System.Windows.Forms.TextBox();
            this.p_randevu_id = new System.Windows.Forms.TextBox();
            this.p_ucret = new System.Windows.Forms.TextBox();
            this.p_ekle = new System.Windows.Forms.Button();
            this.p_listele = new System.Windows.Forms.Button();
            this.p_guncelle = new System.Windows.Forms.Button();
            this.p_r_listele = new System.Windows.Forms.Button();
            this.k_ucret = new System.Windows.Forms.TextBox();
            this.k_randevu_id = new System.Windows.Forms.TextBox();
            this.k_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.k_guncelle = new System.Windows.Forms.Button();
            this.k_listele = new System.Windows.Forms.Button();
            this.k_ekle = new System.Windows.Forms.Button();
            this.k_r_listele = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(894, 190);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "İd:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Randevu İd:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Muayene Ücreti:";
            // 
            // p_id
            // 
            this.p_id.Location = new System.Drawing.Point(154, 297);
            this.p_id.Name = "p_id";
            this.p_id.Size = new System.Drawing.Size(125, 27);
            this.p_id.TabIndex = 7;
            // 
            // p_randevu_id
            // 
            this.p_randevu_id.Location = new System.Drawing.Point(154, 344);
            this.p_randevu_id.Name = "p_randevu_id";
            this.p_randevu_id.Size = new System.Drawing.Size(125, 27);
            this.p_randevu_id.TabIndex = 8;
            // 
            // p_ucret
            // 
            this.p_ucret.Location = new System.Drawing.Point(154, 398);
            this.p_ucret.Name = "p_ucret";
            this.p_ucret.Size = new System.Drawing.Size(125, 27);
            this.p_ucret.TabIndex = 9;
            // 
            // p_ekle
            // 
            this.p_ekle.Location = new System.Drawing.Point(316, 290);
            this.p_ekle.Name = "p_ekle";
            this.p_ekle.Size = new System.Drawing.Size(94, 29);
            this.p_ekle.TabIndex = 13;
            this.p_ekle.Text = "Ekle";
            this.p_ekle.UseVisualStyleBackColor = true;
            this.p_ekle.Click += new System.EventHandler(this.p_ekle_Click);
            // 
            // p_listele
            // 
            this.p_listele.Location = new System.Drawing.Point(316, 337);
            this.p_listele.Name = "p_listele";
            this.p_listele.Size = new System.Drawing.Size(94, 29);
            this.p_listele.TabIndex = 14;
            this.p_listele.Text = "Listele";
            this.p_listele.UseVisualStyleBackColor = true;
            this.p_listele.Click += new System.EventHandler(this.p_listele_Click);
            // 
            // p_guncelle
            // 
            this.p_guncelle.Location = new System.Drawing.Point(316, 395);
            this.p_guncelle.Name = "p_guncelle";
            this.p_guncelle.Size = new System.Drawing.Size(94, 29);
            this.p_guncelle.TabIndex = 15;
            this.p_guncelle.Text = "Güncelle";
            this.p_guncelle.UseVisualStyleBackColor = true;
            this.p_guncelle.Click += new System.EventHandler(this.p_guncelle_Click);
            // 
            // p_r_listele
            // 
            this.p_r_listele.Location = new System.Drawing.Point(96, 463);
            this.p_r_listele.Name = "p_r_listele";
            this.p_r_listele.Size = new System.Drawing.Size(311, 43);
            this.p_r_listele.TabIndex = 16;
            this.p_r_listele.Text = "Poliklinik Randevu Listele";
            this.p_r_listele.UseVisualStyleBackColor = true;
            this.p_r_listele.Click += new System.EventHandler(this.p_r_listele_Click);
            // 
            // k_ucret
            // 
            this.k_ucret.Location = new System.Drawing.Point(625, 391);
            this.k_ucret.Name = "k_ucret";
            this.k_ucret.Size = new System.Drawing.Size(125, 27);
            this.k_ucret.TabIndex = 22;
            // 
            // k_randevu_id
            // 
            this.k_randevu_id.Location = new System.Drawing.Point(625, 337);
            this.k_randevu_id.Name = "k_randevu_id";
            this.k_randevu_id.Size = new System.Drawing.Size(125, 27);
            this.k_randevu_id.TabIndex = 21;
            // 
            // k_id
            // 
            this.k_id.Location = new System.Drawing.Point(625, 290);
            this.k_id.Name = "k_id";
            this.k_id.Size = new System.Drawing.Size(125, 27);
            this.k_id.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(499, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Muayene Ücreti:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(528, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Randevu İd:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(589, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "İd:";
            // 
            // k_guncelle
            // 
            this.k_guncelle.Location = new System.Drawing.Point(816, 396);
            this.k_guncelle.Name = "k_guncelle";
            this.k_guncelle.Size = new System.Drawing.Size(94, 31);
            this.k_guncelle.TabIndex = 25;
            this.k_guncelle.Text = "Güncelle";
            this.k_guncelle.UseVisualStyleBackColor = true;
            this.k_guncelle.Click += new System.EventHandler(this.k_guncelle_Click);
            // 
            // k_listele
            // 
            this.k_listele.Location = new System.Drawing.Point(816, 338);
            this.k_listele.Name = "k_listele";
            this.k_listele.Size = new System.Drawing.Size(94, 31);
            this.k_listele.TabIndex = 24;
            this.k_listele.Text = "Listele";
            this.k_listele.UseVisualStyleBackColor = true;
            this.k_listele.Click += new System.EventHandler(this.k_listele_Click);
            // 
            // k_ekle
            // 
            this.k_ekle.Location = new System.Drawing.Point(816, 291);
            this.k_ekle.Name = "k_ekle";
            this.k_ekle.Size = new System.Drawing.Size(94, 31);
            this.k_ekle.TabIndex = 23;
            this.k_ekle.Text = "Ekle";
            this.k_ekle.UseVisualStyleBackColor = true;
            this.k_ekle.Click += new System.EventHandler(this.k_ekle_Click);
            // 
            // k_r_listele
            // 
            this.k_r_listele.Location = new System.Drawing.Point(585, 453);
            this.k_r_listele.Name = "k_r_listele";
            this.k_r_listele.Size = new System.Drawing.Size(311, 43);
            this.k_r_listele.TabIndex = 26;
            this.k_r_listele.Text = "Klinik Randevu Listele";
            this.k_r_listele.UseVisualStyleBackColor = true;
            this.k_r_listele.Click += new System.EventHandler(this.k_r_listele_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Poliklinik Bilgileri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(682, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Klinik Bilgileri";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 533);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.k_r_listele);
            this.Controls.Add(this.k_guncelle);
            this.Controls.Add(this.k_listele);
            this.Controls.Add(this.k_ekle);
            this.Controls.Add(this.k_ucret);
            this.Controls.Add(this.k_randevu_id);
            this.Controls.Add(this.k_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.p_r_listele);
            this.Controls.Add(this.p_guncelle);
            this.Controls.Add(this.p_listele);
            this.Controls.Add(this.p_ekle);
            this.Controls.Add(this.p_ucret);
            this.Controls.Add(this.p_randevu_id);
            this.Controls.Add(this.p_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form7";
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox p_id;
        private System.Windows.Forms.TextBox p_randevu_id;
        private System.Windows.Forms.TextBox p_ucret;
        private System.Windows.Forms.Button p_ekle;
        private System.Windows.Forms.Button p_listele;
        private System.Windows.Forms.Button p_guncelle;
        private System.Windows.Forms.Button p_r_listele;
        private System.Windows.Forms.TextBox k_ucret;
        private System.Windows.Forms.TextBox k_randevu_id;
        private System.Windows.Forms.TextBox k_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button k_guncelle;
        private System.Windows.Forms.Button k_listele;
        private System.Windows.Forms.Button k_ekle;
        private System.Windows.Forms.Button k_r_listele;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}