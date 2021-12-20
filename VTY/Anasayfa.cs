using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTY
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void randevuBilgi_Click(object sender, EventArgs e)
        {
            Randevu form2 = new Randevu();
            form2.Show();
        }

        private void ameliyathane_Click(object sender, EventArgs e)
        {
            Ameliyathane form = new Ameliyathane();
            form.Show();
        }

        private void acilServis_Click(object sender, EventArgs e)
        {
            AcilServis form = new AcilServis();
            form.Show();
        }

        private void poliklinik_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7();
            form.Show();
        }

        private void ilac_Click(object sender, EventArgs e)
        {
            Ilac form = new Ilac();
            form.Show();
        }

        private void kanIstekleri_Click(object sender, EventArgs e)
        {
            KanIstekleri form = new KanIstekleri();
            form.Show();
        }
    }
}
