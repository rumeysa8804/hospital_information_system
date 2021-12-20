
namespace VTY
{
    partial class Ameliyathane
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ameliyat_listele = new System.Windows.Forms.Button();
            this.ameliyat_ekle = new System.Windows.Forms.Button();
            this.ameliyat_sil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ameliyat_rid = new System.Windows.Forms.TextBox();
            this.ameliyat_tarih = new System.Windows.Forms.TextBox();
            this.ameliyathane_no = new System.Windows.Forms.TextBox();
            this.ameliyat_ucret = new System.Windows.Forms.TextBox();
            this.ameliyat_tur = new System.Windows.Forms.ComboBox();
            this.randevu_listele = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ameliyat_id_sil = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 69);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(504, 236);
            this.dataGridView2.TabIndex = 1;
            // 
            // ameliyat_listele
            // 
            this.ameliyat_listele.Location = new System.Drawing.Point(908, 168);
            this.ameliyat_listele.Name = "ameliyat_listele";
            this.ameliyat_listele.Size = new System.Drawing.Size(122, 29);
            this.ameliyat_listele.TabIndex = 2;
            this.ameliyat_listele.Text = "Ameliyat Listele";
            this.ameliyat_listele.UseVisualStyleBackColor = true;
            this.ameliyat_listele.Click += new System.EventHandler(this.ameliyat_listele_Click);
            // 
            // ameliyat_ekle
            // 
            this.ameliyat_ekle.Location = new System.Drawing.Point(908, 69);
            this.ameliyat_ekle.Name = "ameliyat_ekle";
            this.ameliyat_ekle.Size = new System.Drawing.Size(115, 29);
            this.ameliyat_ekle.TabIndex = 3;
            this.ameliyat_ekle.Text = "Ameliyat Ekle";
            this.ameliyat_ekle.UseVisualStyleBackColor = true;
            this.ameliyat_ekle.Click += new System.EventHandler(this.ameliyat_ekle_Click);
            // 
            // ameliyat_sil
            // 
            this.ameliyat_sil.Location = new System.Drawing.Point(908, 115);
            this.ameliyat_sil.Name = "ameliyat_sil";
            this.ameliyat_sil.Size = new System.Drawing.Size(115, 29);
            this.ameliyat_sil.TabIndex = 4;
            this.ameliyat_sil.Text = "Ameliyat Sil";
            this.ameliyat_sil.UseVisualStyleBackColor = true;
            this.ameliyat_sil.Click += new System.EventHandler(this.ameliyat_sil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(579, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Randevu id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(561, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ameliyat Türü:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(561, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ameliyat Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(548, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ameliyathane No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(561, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ameliyat Ücreti:";
            // 
            // ameliyat_rid
            // 
            this.ameliyat_rid.Location = new System.Drawing.Point(692, 69);
            this.ameliyat_rid.Name = "ameliyat_rid";
            this.ameliyat_rid.Size = new System.Drawing.Size(125, 27);
            this.ameliyat_rid.TabIndex = 10;
            // 
            // ameliyat_tarih
            // 
            this.ameliyat_tarih.Location = new System.Drawing.Point(692, 150);
            this.ameliyat_tarih.Name = "ameliyat_tarih";
            this.ameliyat_tarih.Size = new System.Drawing.Size(125, 27);
            this.ameliyat_tarih.TabIndex = 11;
            // 
            // ameliyathane_no
            // 
            this.ameliyathane_no.Location = new System.Drawing.Point(692, 189);
            this.ameliyathane_no.Name = "ameliyathane_no";
            this.ameliyathane_no.Size = new System.Drawing.Size(125, 27);
            this.ameliyathane_no.TabIndex = 12;
            // 
            // ameliyat_ucret
            // 
            this.ameliyat_ucret.Location = new System.Drawing.Point(692, 225);
            this.ameliyat_ucret.Name = "ameliyat_ucret";
            this.ameliyat_ucret.Size = new System.Drawing.Size(125, 27);
            this.ameliyat_ucret.TabIndex = 13;
            // 
            // ameliyat_tur
            // 
            this.ameliyat_tur.FormattingEnabled = true;
            this.ameliyat_tur.Location = new System.Drawing.Point(692, 107);
            this.ameliyat_tur.Name = "ameliyat_tur";
            this.ameliyat_tur.Size = new System.Drawing.Size(125, 28);
            this.ameliyat_tur.TabIndex = 14;
            // 
            // randevu_listele
            // 
            this.randevu_listele.Location = new System.Drawing.Point(908, 218);
            this.randevu_listele.Name = "randevu_listele";
            this.randevu_listele.Size = new System.Drawing.Size(142, 34);
            this.randevu_listele.TabIndex = 15;
            this.randevu_listele.Text = "Randevuları Listele";
            this.randevu_listele.UseVisualStyleBackColor = true;
            this.randevu_listele.Click += new System.EventHandler(this.randevu_listele_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(561, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ameliyat id:";
            // 
            // ameliyat_id_sil
            // 
            this.ameliyat_id_sil.Location = new System.Drawing.Point(692, 278);
            this.ameliyat_id_sil.Name = "ameliyat_id_sil";
            this.ameliyat_id_sil.Size = new System.Drawing.Size(125, 27);
            this.ameliyat_id_sil.TabIndex = 17;
            // 
            // Ameliyathane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 374);
            this.Controls.Add(this.ameliyat_id_sil);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.randevu_listele);
            this.Controls.Add(this.ameliyat_tur);
            this.Controls.Add(this.ameliyat_ucret);
            this.Controls.Add(this.ameliyathane_no);
            this.Controls.Add(this.ameliyat_tarih);
            this.Controls.Add(this.ameliyat_rid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ameliyat_sil);
            this.Controls.Add(this.ameliyat_ekle);
            this.Controls.Add(this.ameliyat_listele);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Ameliyathane";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button ameliyat_listele;
        private System.Windows.Forms.Button ameliyat_ekle;
        private System.Windows.Forms.Button ameliyat_sil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ameliyat_rid;
        private System.Windows.Forms.TextBox ameliyat_tarih;
        private System.Windows.Forms.TextBox ameliyathane_no;
        private System.Windows.Forms.TextBox ameliyat_ucret;
        private System.Windows.Forms.ComboBox ameliyat_tur;
        private System.Windows.Forms.Button randevu_listele;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ameliyat_id_sil;
    }
}