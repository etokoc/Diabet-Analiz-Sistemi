using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diabet_Analiz_Sistemi
{
    class HastaTabloSinifi
    {
        public HastaKayit hasta;
        public HastaTablo hastaTablo;

        public void veriTemizle(string mesaj, string baslik, bool guncellemeDurumu, List<string> satir, string guncellikveri = "", int isaretliSatir = 1)
        {
            hasta = new HastaKayit();
            hastaTablo = new HastaTablo();

            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show(satir[isaretliSatir] + " \n" + mesaj, baslik, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //Önce dosya içini tamamen temizliyorum sadece başlıkları silmiyorum. 
                //Sonra tüm verileri yenilerle beraber yazınca güncelleme oluyor.

                TextWriter tw = new StreamWriter(Application.StartupPath.ToString() + @"\diabetes_data_upload.csv");
                string basliklar = satir[0];
                tw.Write("");
                tw.Close();
                for (int i = 0; i < satir.Count; i++)
                {
                    if (i == 0)
                    {
                        satir[i] = basliklar;
                    }
                    if (isaretliSatir == i)
                    {
                        if (guncellemeDurumu == true)
                        {
                            satir[i] = guncellikveri;
                            hasta.excelYazdir(satir[i]);
                        }
                        else
                        {
                            satir[i] = "";
                        }
                    }
                    else
                    {
                        
                        hasta.excelYazdir(satir[i]);
                    }
                }

                hastaTablo.Show();
            }
        }
    }
}