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
    public partial class ObeziteHesaplama : Form
    {
        public ObeziteHesaplama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float boy;
            float kilo;

            boy = int.Parse(textBox1.Text);
            kilo = int.Parse(textBox2.Text);

            float sonuc = (kilo*10000) / (boy * boy);


            if (sonuc<28)
            {
                label4.Text = "Vücut kitle endeksiniz :"+sonuc.ToString()+"\nOBEZİTE DEĞİLSİNİZ!";
                label4.BackColor = Color.Green;
            }
            else if(sonuc>28)
            {
                label4.Text = "Vücut kitle endeksiniz :" + sonuc.ToString() + "\nOBEZİTESİNİZ!";
                label4.BackColor = Color.Red;
            }


        }
    }
}
