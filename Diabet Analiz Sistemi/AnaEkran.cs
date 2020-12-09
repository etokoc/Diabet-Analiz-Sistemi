using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diabet_Analiz_Sistemi
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            System.Diagnostics.Process.Start("https://archive.ics.uci.edu/ml/datasets/Early+stage+diabetes+risk+prediction+dataset.");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HastaKayit hasta = new HastaKayit();
            hasta.Show();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HastaTablo hastatablo = new HastaTablo();
            hastatablo.Show();
        }
    }
}
