using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diabet_Analiz_Sistemi
{
    public partial class HastaKayit : Form
    {
        public HastaKayit()
        {
            InitializeComponent();
        }
        public string yeniSatir;
        List<string> satir;
        public int satirNo=1;
        private void HastaKayit_Load(object sender, EventArgs e)
        {
            satir = File.ReadAllLines(Application.StartupPath.ToString() + @"\diabetes_data_upload.csv").ToList();
        }

        private void linkLabel1_MouseClick(object sender, MouseEventArgs e)
        {
            ObeziteHesaplama obeziteHesaplama = new ObeziteHesaplama();
            obeziteHesaplama.ShowDialog();
        }
        HastaTablo HastaTablo;
        private void button1_Click(object sender, EventArgs e)
        {
            VeriSinifi yeniVeri = new VeriSinifi();
            yeniVeri.Age = textBox1.Text + ",";
            yeniVeri.Gender = radioButton1.Checked ? "Male," : "Female,";
            yeniVeri.Polyuria = radioButton3.Checked ? "Yes," : "No,";
            yeniVeri.Polydipsia = radioButton5.Checked ? "Yes," : "No,";
            yeniVeri.Sudden_weight_loss = radioButton7.Checked ? "Yes," : "No,";
            yeniVeri.weakness = radioButton9.Checked ? "Yes," : "No,";
            yeniVeri.Polyphagia = radioButton11.Checked ? "Yes," : "No,";
            yeniVeri.Genital_thrush = radioButton13.Checked ? "Yes," : "No,";
            yeniVeri.visual_blurring = radioButton15.Checked ? "Yes," : "No,";
            yeniVeri.Itching = radioButton17.Checked ? "Yes," : "No,";
            yeniVeri.Irrıtability = radioButton19.Checked ? "Yes," : "No,";
            yeniVeri.delayed_Healing = radioButton21.Checked ? "Yes," : "No,";
            yeniVeri.partial_Paresis = radioButton23.Checked ? "Yes," : "No,";
            yeniVeri.muscle_Stiffness = radioButton25.Checked ? "Yes," : "No,";
            yeniVeri.Alopecia = radioButton27.Checked ? "Yes," : "No,";
            yeniVeri.Obesity = radioButton29.Checked ? "Yes," : "No,";
            yeniVeri._class = radioButton1.Checked ? "Positive" : "Negative";

            string yeniSatir = yeniVeri.Age + yeniVeri.Gender + yeniVeri.Polyuria + yeniVeri.Polydipsia + yeniVeri.Sudden_weight_loss + yeniVeri.weakness + yeniVeri.Polyphagia + yeniVeri.Genital_thrush + yeniVeri.visual_blurring + yeniVeri.Itching + yeniVeri.Irrıtability + yeniVeri.delayed_Healing + yeniVeri.partial_Paresis + yeniVeri.muscle_Stiffness + yeniVeri.Alopecia + yeniVeri.Obesity + yeniVeri._class;

            HastaTabloSinifi hastaTabloSinifi = new HastaTabloSinifi();
               
                MessageBox.Show("sdfa");

            hastaTabloSinifi.veriTemizle("Verisini Güncellemek İstiyor musunuz ?", "Kayıt Guncelleme", true, satir, yeniSatir, satirNo);
            excelYazdir(yeniSatir);
            


        }
        public void hastaGuncelleme()
        {
            
        }
        public void excelYazdir(string yeniSatir)
        {
            using (System.IO.StreamWriter stream = new System.IO.StreamWriter(Application.StartupPath.ToString() + @"\diabetes_data_upload.csv", true))
            {
                stream.WriteLine(yeniSatir);
            }

        }

        public void formDoldur(string age, string gender, string polyuria, string polydipsia, string sudden, string weakness, string polyphagia, string genital, string visual, string itching, string irriability, string delayed, string partial, string muscle, string alopecia, string obesity, string __class)
        {
            //Formu otomatik dolduruyorum
            if (age != "")
            {
                textBox1.Text = age;
            }
            if (gender == "Male")
            {
                radioButton1.Checked = true;
            }
            else if (gender == "Female")
            {
                radioButton2.Checked = true;
            }
            if (polyuria == "Yes")
            {
                radioButton3.Checked = true;
            }
            else if (polyuria == "No")
            {
                radioButton4.Checked = true;
            }
            if (polydipsia == "Yes")
            {
                radioButton5.Checked = true;
            }
            else if (polydipsia == "No")
            {
                radioButton6.Checked = true;
            }
            if (sudden == "Yes")
            {
                radioButton7.Checked = true;
            }
            else if (sudden == "No")
            {
                radioButton8.Checked = true;
            }
            if (weakness == "Yes")
            {
                radioButton9.Checked = true;
            }
            else if (weakness == "No")
            {
                radioButton10.Checked = true;
            }
            if (polyphagia == "Yes")
            {
                radioButton11.Checked = true;
            }
            else if (polyphagia == "No")
            {
                radioButton12.Checked = true;
            }
            if (genital == "Yes")
            {
                radioButton13.Checked = true;
            }
            else if (genital == "No")
            {
                radioButton14.Checked = true;
            }
            if (visual == "Yes")
            {
                radioButton15.Checked = true;
            }
            else if (visual == "No")
            {
                radioButton16.Checked = true;
            }
            if (itching == "Yes")
            {
                radioButton17.Checked = true;
            }
            else if (itching == "No")
            {
                radioButton18.Checked = true;
            }
            if (irriability == "Yes")
            {
                radioButton19.Checked = true;
            }
            else if (irriability == "No")
            {
                radioButton20.Checked = true;
            }
            if (delayed == "Yes")
            {
                radioButton21.Checked = true;
            }
            else if (delayed == "No")
            {
                radioButton22.Checked = true;
            }
            if (partial == "Yes")
            {
                radioButton23.Checked = true;
            }
            else if (partial == "No")
            {
                radioButton24.Checked = true;
            }
            if (muscle == "Yes")
            {
                radioButton25.Checked = true;
            }
            else if (muscle == "No")
            {
                radioButton26.Checked = true;
            }
            if (alopecia == "Yes")
            {
                radioButton27.Checked = true;
            }
            else if (alopecia == "No")
            {
                radioButton28.Checked = true;
            }
            if (obesity == "Yes")
            {
                radioButton29.Checked = true;
            }
            else if (obesity == "No")
            {
                radioButton30.Checked = true;
            }
            if (__class == "Positive")
            {
                radioButton5.Checked = true;
            }
            else if (__class == "Negative")
            {
                radioButton6.Checked = true;
            }
        }
    }


}

