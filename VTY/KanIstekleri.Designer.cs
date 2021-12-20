
namespace VTY
{
    partial class KanIstekleri
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
            this.tarih = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rapor_bilgisi = new System.Windows.Forms.TextBox();
            this.hasta_id = new System.Windows.Forms.TextBox();
            this.doktor_id = new System.Windows.Forms.TextBox();
            this.kan_sil = new System.Windows.Forms.Button();
            this.kan_ekle = new System.Windows.Forms.Button();
            this.kan_listele = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kan_istek_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tarih
            // 
            this.tarih.Location = new System.Drawing.Point(670, 223);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(125, 27);
            this.tarih.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(563, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tarih:";
            // 
            // rapor_bilgisi
            // 
            this.rapor_bilgisi.Location = new System.Drawing.Point(670, 179);
            this.rapor_bilgisi.Name = "rapor_bilgisi";
            this.rapor_bilgisi.Size = new System.Drawing.Size(125, 27);
            this.rapor_bilgisi.TabIndex = 25;
            // 
            // hasta_id
            // 
            this.hasta_id.Location = new System.Drawing.Point(670, 129);
            this.hasta_id.Name = "hasta_id";
            this.hasta_id.Size = new System.Drawing.Size(125, 27);
            this.hasta_id.TabIndex = 23;
            // 
            // doktor_id
            // 
            this.doktor_id.Location = new System.Drawing.Point(670, 84);
            this.doktor_id.Name = "doktor_id";
            this.doktor_id.Size = new System.Drawing.Size(125, 27);
            this.doktor_id.TabIndex = 22;
            // 
            // kan_sil
            // 
            this.kan_sil.Location = new System.Drawing.Point(878, 190);
            this.kan_sil.Name = "kan_sil";
            this.kan_sil.Size = new System.Drawing.Size(94, 29);
            this.kan_sil.TabIndex = 21;
            this.kan_sil.Text = "Sil";
            this.kan_sil.UseVisualStyleBackColor = true;
            this.kan_sil.Click += new System.EventHandler(this.kan_sil_Click);
            // 
            // kan_ekle
            // 
            this.kan_ekle.Location = new System.Drawing.Point(878, 134);
            this.kan_ekle.Name = "kan_ekle";
            this.kan_ekle.Size = new System.Drawing.Size(94, 29);
            this.kan_ekle.TabIndex = 20;
            this.kan_ekle.Text = "Ekle";
            this.kan_ekle.UseVisualStyleBackColor = true;
            this.kan_ekle.Click += new System.EventHandler(this.kan_ekle_Click);
            // 
            // kan_listele
            // 
            this.kan_listele.Location = new System.Drawing.Point(878, 75);
            this.kan_listele.Name = "kan_listele";
            this.kan_listele.Size = new System.Drawing.Size(94, 29);
            this.kan_listele.TabIndex = 19;
            this.kan_listele.Text = "Listele";
            this.kan_listele.UseVisualStyleBackColor = true;
            this.kan_listele.Click += new System.EventHandler(this.kan_listele_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(563, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Rapor Bilgisi:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(605, 38);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(25, 20);
            this.label.TabIndex = 17;
            this.label.Text = "İd:";
            this.label.Click += new System.EventHandler(this.kan_istek_id_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(563, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Hasta id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(563, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Doktor id:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(509, 188);
            this.dataGridView1.TabIndex = 14;
            // 
            // kan_istek_id
            // 
            this.kan_istek_id.Location = new System.Drawing.Point(670, 31);
            this.kan_istek_id.Name = "kan_istek_id";
            this.kan_istek_id.Size = new System.Drawing.Size(125, 27);
            this.kan_istek_id.TabIndex = 28;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 358);
            this.Controls.Add(this.kan_istek_id);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rapor_bilgisi);
            this.Controls.Add(this.hasta_id);
            this.Controls.Add(this.doktor_id);
            this.Controls.Add(this.kan_sil);
            this.Controls.Add(this.kan_ekle);
            this.Controls.Add(this.kan_listele);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rapor_bilgisi;
        private System.Windows.Forms.TextBox hasta_id;
        private System.Windows.Forms.TextBox doktor_id;
        private System.Windows.Forms.Button kan_sil;
        private System.Windows.Forms.Button kan_ekle;
        private System.Windows.Forms.Button kan_listele;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox kan_istek_id;
    }
}