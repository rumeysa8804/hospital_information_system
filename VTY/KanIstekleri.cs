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
    public partial class KanIstekleri : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432;Database=vty;user ID=postgres;password=123456");
        public KanIstekleri()
        {
            InitializeComponent();
        }

        private void kan_istek_id_Click(object sender, EventArgs e)
        {

        }

        private void kan_listele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from kan_istekleri";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void kan_ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into kan_istekleri (doktor_id,hasta_id,rapor_bilgisi,tarih) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(doktor_id.Text));
            komut.Parameters.AddWithValue("@p2", int.Parse(hasta_id.Text));
            komut.Parameters.AddWithValue("@p3", rapor_bilgisi.Text);
            komut.Parameters.AddWithValue("@p4", tarih.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla eklendi");
        }

        private void kan_sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("delete from kan_istekleri where id = @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(kan_istek_id.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla silindi");
        }
    }
}
