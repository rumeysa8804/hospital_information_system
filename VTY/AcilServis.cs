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
    public partial class AcilServis : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432;Database=vty;user ID=postgres;password=123456");
        public AcilServis()
        {
            InitializeComponent();
            baglanti.Open();
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter("select * from doktor_bilgileri", baglanti);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            comboBox1.DisplayMember = "doktor_adi";
            comboBox1.ValueMember = "id";
            comboBox1.DataSource = dt1;
            DataTable dt = new DataTable();
            da1.Fill(dt);
            comboBox2.DisplayMember = "doktor_adi";
            comboBox2.ValueMember = "id";
            comboBox2.DataSource = dt;
            baglanti.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void listele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from acil_servis";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand komut = new NpgsqlCommand("insert into acil_servis (hasta_adi,hasta_soyadi,hasta_tc,doktor_id,gelis_sebebi) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
                komut.Parameters.AddWithValue("@p1", hasta_adi.Text);
                komut.Parameters.AddWithValue("@p2", hasta_soyadi.Text);
                komut.Parameters.AddWithValue("@p3", hasta_tc.Text);
                komut.Parameters.AddWithValue("@p4", comboBox1.SelectedValue);
                komut.Parameters.AddWithValue("@p5", gelis_sebebi.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Başarıyla eklendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }

        private void sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("delete from acil_servis where id = @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(acil_id.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla silindi");
        }

        private void l_listele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from labaratuvar";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void l_ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into labaratuvar (doktor_id,hasta_id,sonuc,tarih) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", comboBox2.SelectedValue);
            komut.Parameters.AddWithValue("@p2", int.Parse(l_hasta_id.Text));
            komut.Parameters.AddWithValue("@p3", sonuc.Text);
            komut.Parameters.AddWithValue("@p4", tarih.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla eklendi");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void AcilServis_Load(object sender, EventArgs e)
        {

        }
    }
}
