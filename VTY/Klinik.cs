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
    public partial class Form7 : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432;Database=vty;user ID=postgres;password=123456");
        public Form7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void p_ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into poliklinik (randevu_id,muayene_ucret) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(p_randevu_id.Text));
            komut.Parameters.AddWithValue("@p2", int.Parse(p_ucret.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla eklendi");
        }

        private void k_ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into klinik (randevu_id,muayene_ucret) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(k_randevu_id.Text));
            komut.Parameters.AddWithValue("@p2", int.Parse(k_ucret.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla eklendi");
        }

        private void p_listele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from poliklinik";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void k_listele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from klinik";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void p_r_listele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from randevu where bolum_id = 4";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void k_r_listele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from randevu where bolum_id = 3";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void p_guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("Update poliklinik set randevu_id=@p1,muayene_ucret=@p2 where id=@p3", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(p_randevu_id.Text));
            komut.Parameters.AddWithValue("@p2", int.Parse(p_ucret.Text));
            komut.Parameters.AddWithValue("@p3", int.Parse(p_id.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla güncellendi");
        }

        private void k_guncelle_Click(object sender, EventArgs e)
        {
            NpgsqlCommand komut = new NpgsqlCommand("Update klinik set randevu_id=@p1,muayene_ucret=@p2 where id=@p3", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(k_randevu_id.Text));
            komut.Parameters.AddWithValue("@p2", int.Parse(k_ucret.Text));
            komut.Parameters.AddWithValue("@p3", int.Parse(k_id.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla güncellendi");
        }
    }
}
