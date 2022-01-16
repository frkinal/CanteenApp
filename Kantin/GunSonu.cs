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
    public partial class GunSonu : Form
    {
        public GunSonu()
        {
            InitializeComponent();
        }
        string odeme_turu = " ";
        string date = " ";
        string hour = " ";
        int hesap = 0;
        int ciro = 0;

        /// <summary>
        /// JSON dosyasi okuma ve JSON dosyasina veri kaytdetme islemlerinin gerceklesebilmesi icin Root adinda class olusturdum
        /// </summary>
        public class Root
        {
            public Root(string dateTime, string hour, string odemeTuru, int hesap)
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

        /// <summary>
        /// Secilen gun icin gun sonunun yazdirilmasi islemini gerceklestiriyorum.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSec_Click(object sender, EventArgs e)
        {
            date = dateTimePicker1.Text;
            ciro = 0;
            listView1.Items.Clear();

            string fileName = @"gunsonu.json";
            string jsonText = File.ReadAllText(fileName);

            var data = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Root>>(jsonText);


            foreach (var item in data)
            {
                ListViewItem okunan = new ListViewItem(
                    new string[]
                    {
                        item.dateTime,item.hour,item.odemeTuru,item.hesap.ToString()
                    });
                if (date == item.dateTime)
                {
                    ciro = ciro + item.hesap;
                    listView1.Items.Add(okunan);
                }
            }
            foreach (ListViewItem item in listView1.Items)
            {
                item.Checked = true;
            }
            lblCiro.Text = ciro.ToString();
        }


        /// <summary>
        /// Bulunudugunuz gun icin gun sonunun form yuklendigi an listview1 icersine aktarilmasi oislemini gerceklestiriyorum..
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GunSonu_Load(object sender, EventArgs e)
        {

            date = dateTimePicker1.Text;

            string fileName = @"gunsonu.json";
            string jsonText = File.ReadAllText(fileName);

            var data = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Root>>(jsonText);

            foreach (var item in data)
            {
                ListViewItem okunan = new ListViewItem(
                    new string[]
                    {
                        item.dateTime,item.hour,item.odemeTuru,item.hesap.ToString()
                    });
                if (date == item.dateTime)
                {
                    ciro = ciro + item.hesap;
                    listView1.Items.Add(okunan);
                }
            }
            foreach (ListViewItem item in listView1.Items)
            {
                item.Checked = true;
            }
            lblCiro.Text = ciro.ToString();
        }


        /// <summary>
        /// Bulundugunuz gunun gunsonunu Bulunudugunuz gunun tarihi isminde bir dosya olusturarak gunsonunu JSON formatina gecirip kaydetme islemini gerceklestitriyorum.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGunSonuCikar_Click(object sender, EventArgs e)
        {
            var gunsonusec = new Root(date, hour, odeme_turu, hesap);
            int dongu = 0;

            foreach (ListViewItem item in listView1.CheckedItems)
            {
                if (item.SubItems[0].Text== DateTime.Now.ToString("M/d/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo))
                {
                    if (!File.Exists(DateTime.Now + ".json"))
                    {
                        string json = "[]";
                        FileStream fs = new FileStream(DateTime.Now.ToString("M.d.yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo) + ".json", FileMode.Create, FileAccess.ReadWrite);
                        fs.Write(Encoding.ASCII.GetBytes(json));
                        fs.Close();
                    }

                        gunsonusec = new Root(item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text, int.Parse(item.SubItems[3].Text));



                    var file = File.ReadAllText(DateTime.Now.ToString("M.d.yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo) + ".json");
                    var list = JsonConvert.DeserializeObject<List<Root>>(file);
                    list.Add(gunsonusec);
                    var jsonVal = JsonConvert.SerializeObject(list);
                    File.WriteAllText(DateTime.Now.ToString("M.d.yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo) + ".json", jsonVal);
                }
                else
                {
                    MessageBox.Show("Sadece bugun icin gunsonu cikarabilirsiniz!!!");
                    break;
                }
                dongu++;
            }
            if (dongu!=0)
            {
                    MessageBox.Show(@DateTime.Now.ToString("M.d.yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo) + ".json " + "konumunda bulabilirsiniz.");
            }
        }
    }
}
