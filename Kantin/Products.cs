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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        OdemeYontemi odemeYontemi = new OdemeYontemi();

        GunSonu GunSonu = new GunSonu();

        /// <summary>
        /// JSON dosyasindan urun adi ve fiyatlari cekebilmek icin Atistirmaliklar adinda class olustrdum
        /// </summary>
        public class Atistirmaliklar
        {
            public string urunAdi { get; set; }
            public int fiyat { get; set; }
        }
        /// <summary>
        /// JSON dosyasindan urun adi ve fiyatlari cekebilmek icin FastFood adinda class olustrdum
        /// </summary>
        public class FastFood
        {
            public string urunAdi { get; set; }
            public int fiyat { get; set; }
        }
        /// <summary>
        /// JSON dosyasindan urun adi ve fiyatlari cekebilmek icin Icecekler adinda class olustrdum
        /// </summary>
        public class Icecekler
        {
            public string urunAdi { get; set; }
            public int fiyat { get; set; }
        }
        /// <summary>
        /// JSON dosyasindan cektigimz verilerin listelenmesi icin ayri bir sinif olusturdum
        /// </summary>
        public class _Products
        {
            public bool success { get; set; }
            public string status { get; set; }
            public List<Atistirmaliklar> Atistirmaliklar { get; set; }
            public List<FastFood> FastFood { get; set; }
            public List<Icecekler> Icecekler { get; set; }
        }
        /// <summary>
        /// 
        /// </summary>
        public class Root
        {
            public _Products products { get; set; }
        }

        /// <summary>
        /// Secilen urunlerin toplam fiyatini hesaplayip OdemeYontemi formundaki label2 label ine aktarma islemini gerceklestiriyorum.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            int secilenSayisi = listView1.CheckedItems.Count;
            if (listView1.Items.Count!=0)
            {
                int toplamHesap = 0;
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    toplamHesap += int.Parse(listView1.Items[i].SubItems[1].Text) * int.Parse(listView1.Items[i].SubItems[2].Text);
                }

                odemeYontemi.label2.Text = toplamHesap.ToString();

                odemeYontemi.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lutfen urun ekleyiniz.");
            }
        }
        /// <summary>
        /// Form yuklendiginde JSON dosyasindaki verilerin listview2 icersine yazdirilmasi islemini gerceklestiriyorum.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Products_Load(object sender, EventArgs e)
        {
            string fileName = @"products.json";
            string jsonText = File.ReadAllText(fileName);

            Root data = Newtonsoft.Json.JsonConvert.DeserializeObject<Root>(jsonText);

            foreach (var item in data.products.Atistirmaliklar)
            {
                ListViewItem okunan = new ListViewItem(
               new string[]{
               item.urunAdi,item.fiyat.ToString()});
                listView2.Items.Add(okunan);
            }
        }
        /// <summary>
        /// listview2 icerisinde secilen urunlerin adedi ile birlikte odeme yapilmasini saglayabilmek icin listview1 icerisine gonderme islemini gerceklestiriyorum.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            int secilenSayisi = listView2.CheckedItems.Count;
            if (secilenSayisi == 1)
            {
                foreach (ListViewItem item in listView2.CheckedItems)
                {
                    if (textBox1.Text != string.Empty && textBox1.Text != "0")
                    {
                            ListViewItem okunan = new ListViewItem(
                           new string[]{
                           item.SubItems[0].Text,textBox1.Text,item.SubItems[1].Text
                           });
                            listView1.Items.Add(okunan);
                    }
                    else
                    {
                        MessageBox.Show("Lutfen urun adedi giriniz.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Birden Fazla Isaretli Not Acilamaz", "Hata");
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

            if (!Char.IsDigit(ch) && ch!=8 && ch!=46)
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Secilen urunlerin arasindan urun iptalini gerceklestirebilmek icin secilen urunun silinmesi islemini gerceklestrdim.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            int secilenSayisi = listView1.CheckedItems.Count;
            foreach (ListViewItem seciliKayitBilgisi in listView1.CheckedItems)
            {
                seciliKayitBilgisi.Remove();
            }
        }
        /// <summary>
        /// listView2 ogesi icindeki urunleri silip JSON yardimi ile Atistirmalik urunlerinin listview2 icerisine aktarilmasi islemini gerceklestiriyorum
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtistirmaliklar_Click(object sender, EventArgs e)
        {
            string fileName = @"products.json";
            string jsonText = File.ReadAllText(fileName);

            Root data = Newtonsoft.Json.JsonConvert.DeserializeObject<Root>(jsonText);
            listView2.Items.Clear();
            foreach (var item in data.products.Atistirmaliklar)
            {
                ListViewItem okunan = new ListViewItem(
               new string[]{
               item.urunAdi,item.fiyat.ToString()});
                listView2.Items.Add(okunan);
            }
        }
        /// <summary>
        /// listView2 ogesi icindeki urunleri silip JSON yardimi ile Fast Food urunlerinin listview2 icerisine aktarilmasi islemini gerceklestiriyorum
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFastFood_Click(object sender, EventArgs e)
        {
            string fileName = @"products.json";
            string jsonText = File.ReadAllText(fileName);

            Root data = Newtonsoft.Json.JsonConvert.DeserializeObject<Root>(jsonText);
            listView2.Items.Clear();
            foreach (var item in data.products.FastFood)
            {
                ListViewItem okunan = new ListViewItem(
               new string[]{
               item.urunAdi,item.fiyat.ToString()});
                listView2.Items.Add(okunan);
            }
        }
        /// <summary>
        /// listView2 ogesi icindeki urunleri silip JSON yardimi ile Icecek urunlerinin listview2 icerisine aktarilmasi islemini gerceklestiriyorum
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIcecekler_Click(object sender, EventArgs e)
        {
            string fileName = @"products.json";
            string jsonText = File.ReadAllText(fileName);

            Root data = Newtonsoft.Json.JsonConvert.DeserializeObject<Root>(jsonText);
            listView2.Items.Clear();
            foreach (var item in data.products.Icecekler)
            {
                ListViewItem okunan = new ListViewItem(
               new string[]{
               item.urunAdi,item.fiyat.ToString()});
                listView2.Items.Add(okunan);
            }
        }
        /// <summary>
        /// GunSonu formunu acilmasi islemini gerceklestiriyorum.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGunsonu_Click(object sender, EventArgs e)
        {
            GunSonu.ShowDialog();
        }
    }
}
