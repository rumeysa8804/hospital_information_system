using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VTY
{
    public partial class Ilac : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432;Database=vty;user ID=postgres;password=123456");
        public Ilac()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ilacListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from ilac_bilgileri";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void ilacEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into ilac_bilgileri (ilac_adi,recete_bilgisi,stok_sayisi,fiyat) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", ilacAdi.Text);
            komut.Parameters.AddWithValue("@p2", recete.Text);
            komut.Parameters.AddWithValue("@p3", stokSayisi.Value);
            komut.Parameters.AddWithValue("@p4",int.Parse(fiyat.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla eklendi");
        }

        private void ilacSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("delete from ilac_bilgileri where id = @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(ilac_id.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla silindi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into ilac_istekleri (doktor_id,hasta_id,istenilen_ilac_id) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(doktor_id.Text));
            komut.Parameters.AddWithValue("@p2", int.Parse(hasta_id.Text));
            komut.Parameters.AddWithValue("@p3", int.Parse(istenilen_ilac_id.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla eklendi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("delete from ilac_istekleri where id = @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(istenilen_i_id.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla silindi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from ilac_istekleri";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
