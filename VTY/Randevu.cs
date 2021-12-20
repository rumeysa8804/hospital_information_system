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
    public partial class Randevu : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432;Database=vty;user ID=postgres;password=123456");
        public Randevu()
        {
            InitializeComponent();
            baglanti.Open();
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter("select * from bolumler", baglanti);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            comboBox1.DisplayMember = "bolum_adi";
            comboBox1.ValueMember = "id";
            comboBox1.DataSource = dt1;
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from doktor_bilgileri ", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox2.DisplayMember = "doktor_adi";
            comboBox2.ValueMember = "id";
            comboBox2.DataSource = dt;
            baglanti.Close();

        }
        private void randevuListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from randevu";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void randevuEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand komut = new NpgsqlCommand("call randevu_ekle(:hasta_adi,:hasta_soyadi,:hasta_tc,:doktor_id,:bolum_id,:tarih)", baglanti);
                komut.Parameters.AddWithValue("hasta_adi", hastaAditxt.Text);
                komut.Parameters.AddWithValue("hasta_soyadi", hastaSoyadtxt.Text);
                komut.Parameters.AddWithValue("hasta_tc", hastaTctxt.Text);
                komut.Parameters.AddWithValue("doktor_id", comboBox2.SelectedValue);
                komut.Parameters.AddWithValue("bolum_id", comboBox1.SelectedValue);
                komut.Parameters.AddWithValue("tarih", randevuTarihtxt.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Başarıyla eklendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }

        private void randevuSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("call randevu_sil(:randevu_id)", baglanti);
            komut.Parameters.AddWithValue("randevu_id", int.Parse(randevuId.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla silindi");
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void randevu_guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("update randevu set bolum_id= @p1,doktor_id = @p2, tarih = @p3 where id= @p4", baglanti);
            komut.Parameters.AddWithValue("@p1", comboBox1.SelectedValue);
            komut.Parameters.AddWithValue("@p2", comboBox2.SelectedValue);
            komut.Parameters.AddWithValue("@p3", randevuTarihtxt.Text);
            komut.Parameters.AddWithValue("@p4",int.Parse( randevuId.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla güncellendi");
        }
    }
}
