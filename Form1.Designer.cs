namespace calısmadosyası
{
    partial class PizzaSipariş
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Malzemeler = new System.Windows.Forms.GroupBox();
            this.salam = new System.Windows.Forms.CheckBox();
            this.mısır = new System.Windows.Forms.CheckBox();
            this.sucuk = new System.Windows.Forms.CheckBox();
            this.zeytin = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sosvepeynirler = new System.Windows.Forms.GroupBox();
            this.parmesan = new System.Windows.Forms.RadioButton();
            this.mozarella = new System.Windows.Forms.RadioButton();
            this.domatessosu = new System.Windows.Forms.RadioButton();
            this.feslegensosu = new System.Windows.Forms.RadioButton();
            this.soslar = new System.Windows.Forms.GroupBox();
            this.Malzemeler.SuspendLayout();
            this.sosvepeynirler.SuspendLayout();
            this.soslar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Moccasin;
            this.label1.Location = new System.Drawing.Point(23, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(597, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç fiyatı 75 TLdir. Sosu ve peynir türlerini seçtikten sonra ek malzeemele" +
    "ri ekleyerek fiyat hesapla buttonuna tıklayınız...\r\n\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Malzemeler
            // 
            this.Malzemeler.Controls.Add(this.salam);
            this.Malzemeler.Controls.Add(this.mısır);
            this.Malzemeler.Controls.Add(this.sucuk);
            this.Malzemeler.Controls.Add(this.zeytin);
            this.Malzemeler.Location = new System.Drawing.Point(277, 179);
            this.Malzemeler.Name = "Malzemeler";
            this.Malzemeler.Size = new System.Drawing.Size(224, 196);
            this.Malzemeler.TabIndex = 1;
            this.Malzemeler.TabStop = false;
            this.Malzemeler.Text = "Malzemeler";
            // 
            // salam
            // 
            this.salam.AutoSize = true;
            this.salam.Location = new System.Drawing.Point(6, 91);
            this.salam.Name = "salam";
            this.salam.Size = new System.Drawing.Size(73, 17);
            this.salam.TabIndex = 3;
            this.salam.Text = "Salam(20)";
            this.salam.UseVisualStyleBackColor = true;
            this.salam.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // mısır
            // 
            this.mısır.AutoSize = true;
            this.mısır.Location = new System.Drawing.Point(7, 67);
            this.mısır.Name = "mısır";
            this.mısır.Size = new System.Drawing.Size(65, 17);
            this.mısır.TabIndex = 2;
            this.mısır.Text = "Mısır(10)";
            this.mısır.UseVisualStyleBackColor = true;
            // 
            // sucuk
            // 
            this.sucuk.AutoSize = true;
            this.sucuk.Location = new System.Drawing.Point(7, 43);
            this.sucuk.Name = "sucuk";
            this.sucuk.Size = new System.Drawing.Size(75, 17);
            this.sucuk.TabIndex = 1;
            this.sucuk.Text = "Sucuk(25)";
            this.sucuk.UseVisualStyleBackColor = true;
            // 
            // zeytin
            // 
            this.zeytin.AutoSize = true;
            this.zeytin.Location = new System.Drawing.Point(6, 19);
            this.zeytin.Name = "zeytin";
            this.zeytin.Size = new System.Drawing.Size(73, 17);
            this.zeytin.TabIndex = 0;
            this.zeytin.Text = "Zeytin(15)";
            this.zeytin.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(526, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(624, 252);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // sosvepeynirler
            // 
            this.sosvepeynirler.Controls.Add(this.mozarella);
            this.sosvepeynirler.Controls.Add(this.parmesan);
            this.sosvepeynirler.Location = new System.Drawing.Point(26, 179);
            this.sosvepeynirler.Name = "sosvepeynirler";
            this.sosvepeynirler.Size = new System.Drawing.Size(201, 84);
            this.sosvepeynirler.TabIndex = 4;
            this.sosvepeynirler.TabStop = false;
            this.sosvepeynirler.Text = "Peynirler";
            // 
            // parmesan
            // 
            this.parmesan.AutoSize = true;
            this.parmesan.Location = new System.Drawing.Point(11, 19);
            this.parmesan.Name = "parmesan";
            this.parmesan.Size = new System.Drawing.Size(90, 17);
            this.parmesan.TabIndex = 5;
            this.parmesan.TabStop = true;
            this.parmesan.Text = "Parmesan(40)";
            this.parmesan.UseVisualStyleBackColor = true;
            // 
            // mozarella
            // 
            this.mozarella.AutoSize = true;
            this.mozarella.Location = new System.Drawing.Point(11, 43);
            this.mozarella.Name = "mozarella";
            this.mozarella.Size = new System.Drawing.Size(88, 17);
            this.mozarella.TabIndex = 6;
            this.mozarella.TabStop = true;
            this.mozarella.Text = "Mozarella(30)";
            this.mozarella.UseVisualStyleBackColor = true;
            // 
            // domatessosu
            // 
            this.domatessosu.AutoSize = true;
            this.domatessosu.Location = new System.Drawing.Point(11, 19);
            this.domatessosu.Name = "domatessosu";
            this.domatessosu.Size = new System.Drawing.Size(112, 17);
            this.domatessosu.TabIndex = 5;
            this.domatessosu.TabStop = true;
            this.domatessosu.Text = "Domates Sosu(15)";
            this.domatessosu.UseVisualStyleBackColor = true;
            this.domatessosu.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // feslegensosu
            // 
            this.feslegensosu.AutoSize = true;
            this.feslegensosu.Location = new System.Drawing.Point(10, 42);
            this.feslegensosu.Name = "feslegensosu";
            this.feslegensosu.Size = new System.Drawing.Size(113, 17);
            this.feslegensosu.TabIndex = 6;
            this.feslegensosu.TabStop = true;
            this.feslegensosu.Text = "Fesleğen Sosu(20)";
            this.feslegensosu.UseVisualStyleBackColor = true;
            // 
            // soslar
            // 
            this.soslar.Controls.Add(this.domatessosu);
            this.soslar.Controls.Add(this.feslegensosu);
            this.soslar.Location = new System.Drawing.Point(26, 288);
            this.soslar.Name = "soslar";
            this.soslar.Size = new System.Drawing.Size(200, 87);
            this.soslar.TabIndex = 7;
            this.soslar.TabStop = false;
            this.soslar.Text = "Soslar";
            // 
            // PizzaSipariş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.soslar);
            this.Controls.Add(this.sosvepeynirler);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Malzemeler);
            this.Controls.Add(this.label1);
            this.Name = "PizzaSipariş";
            this.Text = "Pizza Sipariş";
            this.Malzemeler.ResumeLayout(false);
            this.Malzemeler.PerformLayout();
            this.sosvepeynirler.ResumeLayout(false);
            this.sosvepeynirler.PerformLayout();
            this.soslar.ResumeLayout(false);
            this.soslar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Malzemeler;
        private System.Windows.Forms.CheckBox salam;
        private System.Windows.Forms.CheckBox mısır;
        private System.Windows.Forms.CheckBox sucuk;
        private System.Windows.Forms.CheckBox zeytin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox sosvepeynirler;
        private System.Windows.Forms.RadioButton mozarella;
        private System.Windows.Forms.RadioButton parmesan;
        private System.Windows.Forms.RadioButton domatessosu;
        private System.Windows.Forms.RadioButton feslegensosu;
        private System.Windows.Forms.GroupBox soslar;
    }
}

