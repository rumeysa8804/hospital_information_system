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
    public partial class Ameliyathane : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432;Database=vty;user ID=postgres;password=123456");
        public Ameliyathane()
        {
            InitializeComponent();
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from ameliyat_turu", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ameliyat_tur.DisplayMember = "ameliyat_turu";
            ameliyat_tur.ValueMember = "id";
            ameliyat_tur.DataSource = dt;
            baglanti.Close();
        }

        private void randevu_listele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from randevu where bolum_id = 6";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void ameliyat_ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("call ameliyat_ekle(:randevu_id, :ameliyat_turu,:ameliyat_tarih,:ameliyathane_no ,:ameliyat_ucret)", baglanti);
            komut.Parameters.AddWithValue("randevu_id",int.Parse(ameliyat_rid.Text));
            komut.Parameters.AddWithValue("ameliyat_turu", ameliyat_tur.SelectedValue);
            komut.Parameters.AddWithValue("ameliyat_tarih", ameliyat_tarih.Text);
            komut.Parameters.AddWithValue("ameliyathane_no", int.Parse(ameliyathane_no.Text));
            komut.Parameters.AddWithValue("ameliyat_ucret", int.Parse(ameliyat_ucret.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla eklendi");
        }

        private void ameliyat_listele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from ameliyathane_bilgileri";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void ameliyat_sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("call ameliyat_sil(:ameliyat_id_sil)", baglanti);
            komut.Parameters.AddWithValue("ameliyat_id_sil", int.Parse(ameliyat_id_sil.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla silindi");
        }
    }
}
