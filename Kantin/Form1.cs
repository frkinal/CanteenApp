
namespace Kantin
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// JSON dosyasindan kullanici adi ve sifreleri cekebilmek icin User adinda class olustrdum
        /// </summary>
        public class User
        {
            public string kullaniciAdi { get; set; }
            public string sifre { get; set; }
        }

        /// <summary>
        /// JSON dosyasindaki verileri listelemek icin Root adinda ayri bir class olusturdum.
        /// </summary>
        public class Root
        {
            public List<User> users { get; set; }
        }
        /// <summary>
        /// Login butonuna basildigi zaman JSON  dosyasi icerisinde kaydedilen veriler ile kullanici tarafindan girilen bilgilerin kontrolu islemini gerceklestiriyorum.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string fileName = @"users.json";
            string jsonText = File.ReadAllText(fileName);

            Root data = Newtonsoft.Json.JsonConvert.DeserializeObject<Root>(jsonText);
            Products products = new Products();

            foreach (var item in data.users)
            {
                if (comboBox1.Text == item.kullaniciAdi && txtPassword.Text == item.sifre)
                {
                    products.ShowDialog();
                }
            }

            
        }
        /// <summary>
        /// form yuklendigi zaman kullanici isimlerinin JSON dosyasi icrisinden comboBox1 icerisinde aktarma islemini gerceklestiriyorum.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void frmLogin_Load(object sender, EventArgs e)
        {

            string fileName = @"users.json";
            string jsonText = File.ReadAllText(fileName);

            Root data = Newtonsoft.Json.JsonConvert.DeserializeObject<Root>(jsonText);
            Products products = new Products();

            foreach (var item in data.users)
            {
                comboBox1.Items.Add(item.kullaniciAdi);
            }
            comboBox1.Text = "inal";
        }
    }
}