using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kantin
{
    public partial class OdemeYontemi : Form
    {
        public OdemeYontemi()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Girilen verilerin JSON formnatinda kaydedilmesi icin Gunsonu adinda class olusturuyorum.
        /// </summary>
        public class Gunsonu
        {
            public Gunsonu( string dateTime, string hour,string odemeTuru, int hesap)
            {
                this.dateTime = dateTime;
                this.hour = hour;
                this.odemeTuru = odemeTuru;
                this.hesap = hesap;
            }

            public string dateTime { get; set; }
            public string hour { get; set; }
            public string odemeTuru { get; set; }
            public int hesap { get; set; }
        }


        string odeme_turu=" ";
        string date=" ";
        string hour=" ";


        /// <summary>
        /// Nakit adinda button olusturarak JSon dosyasinda odeme turu ve toplam  hesabin degiskenlere atanamsi islemini gerceklestiriyorum. Ayriyeten nakit islemi icin para ustrun hesaplayan tex=t box ekledim.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            odeme_turu = " ";
            int paraUstu = 0;

            paraUstu =int.Parse(textBox1.Text) - int.Parse(label2.Text);

            label4.Text=paraUstu.ToString();

            odeme_turu = "Nakit";
        }
        /// <summary>
        /// Kredi Karti adinda button olusturarak JSon dosyasinda odeme turu ve toplam  hesabin degiskenlere atanamsi islemini gerceklestiriyorum.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button2_Click(object sender, EventArgs e)
        {
            odeme_turu = " ";
            odeme_turu = "Kredi Karti";
        }
        
        /// <summary>
        /// Odeme adinda button olusturarak Hesap hakkindaki bilgilertin (tarih,saat, hesap turu, toplam hesap) JSON formatina cevirilip bir JSON dosyasina kaydetme islemini gerceklestriiyorum.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdeme_Click(object sender, EventArgs e)
        {

            if (odeme_turu==" ")
            {
                MessageBox.Show("Lutfen odeme tipini seciniz!!!");
            }
            else
            {
                if (!File.Exists("gunsonu.json"))
                {
                    string json = "[]";
                    FileStream fs = new FileStream("gunsonu.json", FileMode.Create, FileAccess.ReadWrite);
                    fs.Write(Encoding.ASCII.GetBytes(json));
                    fs.Close();
                }
                date = DateTime.Now.ToString("M/d/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                hour = DateTime.Now.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                var gunsonu = new Gunsonu(date, hour, odeme_turu, int.Parse(label2.Text));


                var file = File.ReadAllText("gunsonu.json");
                var list = JsonConvert.DeserializeObject<List<Gunsonu>>(file);
                list.Add(gunsonu);
                var jsonVal = JsonConvert.SerializeObject(list);
                File.WriteAllText("gunsonu.json", jsonVal);


                MessageBox.Show("Odeme Alindi");
                odeme_turu = " ";
                this.Close();
            }
        }
        /// <summary>
        /// textBox1 icersine integer deger disinde deger girilmesini engelleme islemini gerceklestiriyorum
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

    }
}
