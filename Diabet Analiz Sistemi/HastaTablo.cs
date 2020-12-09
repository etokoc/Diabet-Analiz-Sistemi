using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;


namespace Diabet_Analiz_Sistemi
{
    public partial class HastaTablo : Form
    {
        public HastaTablo()
        {
            InitializeComponent();
        }
        public HastaKayit HastaKayit = new HastaKayit();

        //Age,Gender,Polyuria,Polydipsia,sudden weight loss,weakness,Polyphagia,Genital thrush,visual blurring,Itching,Irritability,delayed healing,partial paresis,muscle stiffness,Alopecia,Obesity,class

        public List<VeriSinifi> veriSinif = new List<VeriSinifi>();
        public List<string> satir;
        public int hastaSayisi = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            HastaKayit hastaKayit = new HastaKayit();
            hastaKayit.Show();
            hastaKayit.Visible = false;
            // HastaKayit.Show();
            // HastaKayit.Visible = false;
            tablo_Doldur();
        }
        public void tablo_Doldur()
        {
            satir = File.ReadAllLines(Application.StartupPath.ToString() + @"\diabetes_data_upload.csv").ToList();
            for (int i = 1; i < satir.Count; i++)
            {
                veriListele(i);
                hastaSayisi++;
            }
            dataGridView1.DataSource = veriSinif;
            label2.Text = hastaSayisi.ToString();
        }


        public void veriListele(int i)
        {
            string[] data = satir[i].Split(',');
            veriSinif.Add(new VeriSinifi()
            {
                Age = data[0],
                Gender = data[1],
                Polyuria = data[2],
                Polydipsia = data[3],
                Sudden_weight_loss = data[4],
                weakness = data[5],
                Polyphagia = data[6],
                Genital_thrush = data[7],
                visual_blurring = data[8],
                Itching = data[9],
                Irrıtability = data[10],
                delayed_Healing = data[11],
                partial_Paresis = data[12],
                muscle_Stiffness = data[13],
                Alopecia = data[14],
                Obesity = data[15],
                _class = data[16]
            });
        }
        public int isartliSatir = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string[] data = satir[e.RowIndex].Split(',');

                string age = data[0];
                string gender = data[1] == "Male" ? "Male" : "Female";
                string polyuria = data[2] == "Yes" ? "Yes" : "No";
                string polydipsia = data[3] == "Yes" ? "Yes" : "No";
                string sudden = data[4] == "Yes" ? "Yes" : "No";
                string weakness = data[5] == "Yes" ? "Yes" : "No";
                string polyphagia = data[6] == "Yes" ? "Yes" : "No";
                string genital = data[7] == "Yes" ? "Yes" : "No";
                string visual = data[8] == "Yes" ? "Yes" : "No";
                string itching = data[9] == "Yes" ? "Yes" : "No";
                string irrability = data[10] == "Yes" ? "Yes" : "No";
                string delayed = data[11] == "Yes" ? "Yes" : "No";
                string partial = data[12] == "Yes" ? "Yes" : "No";
                string muscle = data[13] == "Yes" ? "Yes" : "No";
                string alopceia = data[14] == "Yes" ? "Yes" : "No";
                string obesity = data[15] == "Yes" ? "Yes" : "No";
                string clas = data[16] == "Positive" ? "Positive" : "Negative";

                isartliSatir = e.RowIndex + 1;
                //formu dolduruyorum.Güncelleme için
                HastaKayit.formDoldur(age, gender, polyuria, polydipsia, sudden, weakness, polyphagia, genital, visual, itching, irrability, delayed, partial, muscle, alopceia, obesity, clas);
            }
            catch (Exception)
            { }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Düzenleme İşlemi
            //tablo_Doldur();
            // this.Close();
            
            HastaKayit.Visible = true;
            HastaKayit.satirNo = isartliSatir;
            // veriTemizle("Verisini Güncellemek İstiyor musunuz ?", "Kayıt Guncelleme", true, HastaKayit.yeniSatir);
            // HastaKayit.HastaGuncelleme();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ////Silme İşlemi
            ///

            HastaTabloSinifi hastaTabloSinifi = new HastaTabloSinifi();
            hastaTabloSinifi.veriTemizle("Verisini Silmek İstiyor musunuz ?", "Kayıt Silme", false,satir,null,isartliSatir);
        }
    }
}
