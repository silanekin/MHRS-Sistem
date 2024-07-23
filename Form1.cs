using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _210601046_Şilan_Ekin_veri_finalproje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hastaEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastaEkleme hastaEkleme = new HastaEkleme();
            hastaEkleme.Show();
            this.Hide();
        }

        private void muayeKaydıOluşturmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuayeneKayit muayeneKayit = new MuayeneKayit();
            muayeneKayit.Show();
            this.Hide();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void hastaSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastaSil hastaSil = new HastaSil();
            hastaSil.Show();
            this.Hide();
        }

        private void hastaBilgileriniGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastaBilgiGuncelle hastaBilgiGuncelle = new HastaBilgiGuncelle();
            hastaBilgiGuncelle.Show();
            this.Hide();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ilaçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide(); 
        }

        private void kayıtDefteriniGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            poliklinikkayıtdefter Poliklinikkayıtdefter = new poliklinikkayıtdefter();
            Poliklinikkayıtdefter.Show();
            this.Hide();
                
        }
    }
}
