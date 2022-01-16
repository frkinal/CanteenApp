namespace Kantin
{
    partial class Products
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.grpHesap = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.btnGunsonu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.btnFastFood = new System.Windows.Forms.Button();
            this.btnAtistirmaliklar = new System.Windows.Forms.Button();
            this.btnIcecekler = new System.Windows.Forms.Button();
            this.grpHesap.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Odeme";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpHesap
            // 
            this.grpHesap.Controls.Add(this.button5);
            this.grpHesap.Controls.Add(this.listView1);
            this.grpHesap.Controls.Add(this.button1);
            this.grpHesap.Location = new System.Drawing.Point(559, 15);
            this.grpHesap.Name = "grpHesap";
            this.grpHesap.Size = new System.Drawing.Size(382, 559);
            this.grpHesap.TabIndex = 4;
            this.grpHesap.TabStop = false;
            this.grpHesap.Text = "Hesap";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 510);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 35);
            this.button5.TabIndex = 3;
            this.button5.Text = "Sil";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader9});
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.Location = new System.Drawing.Point(6, 26);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(370, 459);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Urun Adi";
            this.columnHeader1.Width = 170;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Urun Adedi";
            this.columnHeader2.Width = 110;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Urun Fiyati";
            this.columnHeader9.Width = 100;
            // 
            // btnGunsonu
            // 
            this.btnGunsonu.Location = new System.Drawing.Point(320, 505);
            this.btnGunsonu.Name = "btnGunsonu";
            this.btnGunsonu.Size = new System.Drawing.Size(233, 58);
            this.btnGunsonu.TabIndex = 9;
            this.btnGunsonu.Text = "Gun Sonu";
            this.btnGunsonu.UseVisualStyleBackColor = true;
            this.btnGunsonu.Click += new System.EventHandler(this.btnGunsonu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 559);
            this.panel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listView2);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 548);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Urunler";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 513);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 480);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 27);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Urun Adedi";
            // 
            // listView2
            // 
            this.listView2.CheckBoxes = true;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listView2.Location = new System.Drawing.Point(19, 26);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(246, 404);
            this.listView2.TabIndex = 3;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Urun Adi";
            this.columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Urun Fiyati";
            this.columnHeader4.Width = 100;
            // 
            // btnFastFood
            // 
            this.btnFastFood.Location = new System.Drawing.Point(320, 67);
            this.btnFastFood.Name = "btnFastFood";
            this.btnFastFood.Size = new System.Drawing.Size(233, 45);
            this.btnFastFood.TabIndex = 5;
            this.btnFastFood.Text = "Fast Food";
            this.btnFastFood.UseVisualStyleBackColor = true;
            this.btnFastFood.Click += new System.EventHandler(this.btnFastFood_Click);
            // 
            // btnAtistirmaliklar
            // 
            this.btnAtistirmaliklar.Location = new System.Drawing.Point(320, 15);
            this.btnAtistirmaliklar.Name = "btnAtistirmaliklar";
            this.btnAtistirmaliklar.Size = new System.Drawing.Size(233, 46);
            this.btnAtistirmaliklar.TabIndex = 5;
            this.btnAtistirmaliklar.Text = "Atistirmaliklar";
            this.btnAtistirmaliklar.UseVisualStyleBackColor = true;
            this.btnAtistirmaliklar.Click += new System.EventHandler(this.btnAtistirmaliklar_Click);
            // 
            // btnIcecekler
            // 
            this.btnIcecekler.Location = new System.Drawing.Point(320, 118);
            this.btnIcecekler.Name = "btnIcecekler";
            this.btnIcecekler.Size = new System.Drawing.Size(233, 51);
            this.btnIcecekler.TabIndex = 6;
            this.btnIcecekler.Text = "Icecekler";
            this.btnIcecekler.UseVisualStyleBackColor = true;
            this.btnIcecekler.Click += new System.EventHandler(this.btnIcecekler_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 575);
            this.Controls.Add(this.btnGunsonu);
            this.Controls.Add(this.btnFastFood);
            this.Controls.Add(this.btnIcecekler);
            this.Controls.Add(this.btnAtistirmaliklar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpHesap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Products_Load);
            this.grpHesap.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpUrunler;
        private Button button1;
        private GroupBox grpHesap;
        private Panel panel1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ListView listView2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private GroupBox groupBox1;
        private ColumnHeader columnHeader9;
        private Label label1;
        private TextBox textBox1;
        private Button button2;
        private Button button5;
        private Button btnFastFood;
        private Button btnAtistirmaliklar;
        private Button btnIcecekler;
        private Button btnGunsonu;
    }
}