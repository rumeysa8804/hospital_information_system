
namespace VTY
{
    partial class Ilac
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
            this.label4 = new System.Windows.Forms.Label();
            this.ilacListele = new System.Windows.Forms.Button();
            this.ilacEkle = new System.Windows.Forms.Button();
            this.ilacSil = new System.Windows.Forms.Button();
            this.ilacAdi = new System.Windows.Forms.TextBox();
            this.recete = new System.Windows.Forms.TextBox();
            this.stokSayisi = new System.Windows.Forms.NumericUpDown();
            this.fiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ilac_id = new System.Windows.Forms.TextBox();
            this.hasta_id = new System.Windows.Forms.TextBox();
            this.doktor_id = new System.Windows.Forms.TextBox();
            this.istenilen_ilac_sil = new System.Windows.Forms.Button();
            this.istenilen_ilac_ekle = new System.Windows.Forms.Button();
            this.istenilen_ilac_listele = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.istenilen_ilac_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.istenilen_i_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(508, 199);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(559, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "İlaç Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(559, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reçete Bilgisi:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(559, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Stok Sayısı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(559, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fiyat:";
            // 
            // ilacListele
            // 
            this.ilacListele.Location = new System.Drawing.Point(874, 44);
            this.ilacListele.Name = "ilacListele";
            this.ilacListele.Size = new System.Drawing.Size(94, 29);
            this.ilacListele.TabIndex = 5;
            this.ilacListele.Text = "Listele";
            this.ilacListele.UseVisualStyleBackColor = true;
            this.ilacListele.Click += new System.EventHandler(this.ilacListele_Click);
            // 
            // ilacEkle
            // 
            this.ilacEkle.Location = new System.Drawing.Point(874, 103);
            this.ilacEkle.Name = "ilacEkle";
            this.ilacEkle.Size = new System.Drawing.Size(94, 29);
            this.ilacEkle.TabIndex = 6;
            this.ilacEkle.Text = "Ekle";
            this.ilacEkle.UseVisualStyleBackColor = true;
            this.ilacEkle.Click += new System.EventHandler(this.ilacEkle_Click);
            // 
            // ilacSil
            // 
            this.ilacSil.Location = new System.Drawing.Point(874, 159);
            this.ilacSil.Name = "ilacSil";
            this.ilacSil.Size = new System.Drawing.Size(94, 29);
            this.ilacSil.TabIndex = 7;
            this.ilacSil.Text = "Sil";
            this.ilacSil.UseVisualStyleBackColor = true;
            this.ilacSil.Click += new System.EventHandler(this.ilacSil_Click);
            // 
            // ilacAdi
            // 
            this.ilacAdi.Location = new System.Drawing.Point(666, 20);
            this.ilacAdi.Name = "ilacAdi";
            this.ilacAdi.Size = new System.Drawing.Size(125, 27);
            this.ilacAdi.TabIndex = 8;
            // 
            // recete
            // 
            this.recete.Location = new System.Drawing.Point(666, 65);
            this.recete.Name = "recete";
            this.recete.Size = new System.Drawing.Size(125, 27);
            this.recete.TabIndex = 9;
            // 
            // stokSayisi
            // 
            this.stokSayisi.Location = new System.Drawing.Point(666, 100);
            this.stokSayisi.Name = "stokSayisi";
            this.stokSayisi.Size = new System.Drawing.Size(125, 27);
            this.stokSayisi.TabIndex = 10;
            // 
            // fiyat
            // 
            this.fiyat.Location = new System.Drawing.Point(666, 148);
            this.fiyat.Name = "fiyat";
            this.fiyat.Size = new System.Drawing.Size(125, 27);
            this.fiyat.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(559, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "İlaç id:";
            // 
            // ilac_id
            // 
            this.ilac_id.Location = new System.Drawing.Point(666, 192);
            this.ilac_id.Name = "ilac_id";
            this.ilac_id.Size = new System.Drawing.Size(125, 27);
            this.ilac_id.TabIndex = 13;
            // 
            // hasta_id
            // 
            this.hasta_id.Location = new System.Drawing.Point(655, 412);
            this.hasta_id.Name = "hasta_id";
            this.hasta_id.Size = new System.Drawing.Size(125, 27);
            this.hasta_id.TabIndex = 23;
            // 
            // doktor_id
            // 
            this.doktor_id.Location = new System.Drawing.Point(655, 367);
            this.doktor_id.Name = "doktor_id";
            this.doktor_id.Size = new System.Drawing.Size(125, 27);
            this.doktor_id.TabIndex = 22;
            // 
            // istenilen_ilac_sil
            // 
            this.istenilen_ilac_sil.Location = new System.Drawing.Point(866, 489);
            this.istenilen_ilac_sil.Name = "istenilen_ilac_sil";
            this.istenilen_ilac_sil.Size = new System.Drawing.Size(94, 29);
            this.istenilen_ilac_sil.TabIndex = 21;
            this.istenilen_ilac_sil.Text = "Sil";
            this.istenilen_ilac_sil.UseVisualStyleBackColor = true;
            this.istenilen_ilac_sil.Click += new System.EventHandler(this.button1_Click);
            // 
            // istenilen_ilac_ekle
            // 
            this.istenilen_ilac_ekle.Location = new System.Drawing.Point(866, 433);
            this.istenilen_ilac_ekle.Name = "istenilen_ilac_ekle";
            this.istenilen_ilac_ekle.Size = new System.Drawing.Size(94, 29);
            this.istenilen_ilac_ekle.TabIndex = 20;
            this.istenilen_ilac_ekle.Text = "Ekle";
            this.istenilen_ilac_ekle.UseVisualStyleBackColor = true;
            this.istenilen_ilac_ekle.Click += new System.EventHandler(this.button2_Click);
            // 
            // istenilen_ilac_listele
            // 
            this.istenilen_ilac_listele.Location = new System.Drawing.Point(866, 374);
            this.istenilen_ilac_listele.Name = "istenilen_ilac_listele";
            this.istenilen_ilac_listele.Size = new System.Drawing.Size(94, 29);
            this.istenilen_ilac_listele.TabIndex = 19;
            this.istenilen_ilac_listele.Text = "Listele";
            this.istenilen_ilac_listele.UseVisualStyleBackColor = true;
            this.istenilen_ilac_listele.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(529, 459);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "İstenilen İlaç id:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(573, 419);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Hasta id:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(558, 374);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Doktor id:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(-2, 360);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(509, 188);
            this.dataGridView2.TabIndex = 14;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // istenilen_ilac_id
            // 
            this.istenilen_ilac_id.Location = new System.Drawing.Point(655, 459);
            this.istenilen_ilac_id.Name = "istenilen_ilac_id";
            this.istenilen_ilac_id.Size = new System.Drawing.Size(125, 27);
            this.istenilen_ilac_id.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(583, 508);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "İstek id:";
            // 
            // istenilen_i_id
            // 
            this.istenilen_i_id.Location = new System.Drawing.Point(655, 508);
            this.istenilen_i_id.Name = "istenilen_i_id";
            this.istenilen_i_id.Size = new System.Drawing.Size(125, 27);
            this.istenilen_i_id.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(722, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "İstenilen İlaç Bilgisi";
            // 
            // Ilac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 593);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.istenilen_i_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.istenilen_ilac_id);
            this.Controls.Add(this.hasta_id);
            this.Controls.Add(this.doktor_id);
            this.Controls.Add(this.istenilen_ilac_sil);
            this.Controls.Add(this.istenilen_ilac_ekle);
            this.Controls.Add(this.istenilen_ilac_listele);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.ilac_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fiyat);
            this.Controls.Add(this.stokSayisi);
            this.Controls.Add(this.recete);
            this.Controls.Add(this.ilacAdi);
            this.Controls.Add(this.ilacSil);
            this.Controls.Add(this.ilacEkle);
            this.Controls.Add(this.ilacListele);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Ilac";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ilacListele;
        private System.Windows.Forms.Button ilacEkle;
        private System.Windows.Forms.Button ilacSil;
        private System.Windows.Forms.TextBox ilacAdi;
        private System.Windows.Forms.TextBox recete;
        private System.Windows.Forms.NumericUpDown stokSayisi;
        private System.Windows.Forms.TextBox fiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ilac_id;
        private System.Windows.Forms.TextBox hasta_id;
        private System.Windows.Forms.TextBox doktor_id;
        private System.Windows.Forms.Button istenilen_ilac_sil;
        private System.Windows.Forms.Button istenilen_ilac_ekle;
        private System.Windows.Forms.Button istenilen_ilac_listele;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox istenilen_ilac_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox istenilen_i_id;
        private System.Windows.Forms.Label label7;
    }
}