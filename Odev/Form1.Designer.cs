namespace Odev
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.adTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.adresTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.yasTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mesaibox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.birimCmbx = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb2Cmbx = new System.Windows.Forms.ComboBox();
            this.adTxt2 = new System.Windows.Forms.TextBox();
            this.adresTxt2 = new System.Windows.Forms.TextBox();
            this.yasTxt2 = new System.Windows.Forms.TextBox();
            this.mesai2Txt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbboxisci = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbbox3 = new System.Windows.Forms.ComboBox();
            this.adTxt3 = new System.Windows.Forms.TextBox();
            this.adresTxt3 = new System.Windows.Forms.TextBox();
            this.yasTxt3 = new System.Windows.Forms.TextBox();
            this.mesaiTxt3 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(123, 283);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Personel Oluştur";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(43, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adınız :";
            // 
            // adTxt
            // 
            this.adTxt.Location = new System.Drawing.Point(113, 26);
            this.adTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adTxt.Name = "adTxt";
            this.adTxt.Size = new System.Drawing.Size(100, 29);
            this.adTxt.TabIndex = 2;
            this.adTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(7, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adresiniz :";
            // 
            // adresTxt
            // 
            this.adresTxt.Location = new System.Drawing.Point(113, 66);
            this.adresTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adresTxt.Name = "adresTxt";
            this.adresTxt.Size = new System.Drawing.Size(100, 29);
            this.adresTxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(35, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yaşınız :";
            // 
            // yasTxt
            // 
            this.yasTxt.Location = new System.Drawing.Point(113, 106);
            this.yasTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yasTxt.Name = "yasTxt";
            this.yasTxt.Size = new System.Drawing.Size(100, 29);
            this.yasTxt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(7, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mesai Saati:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // mesaibox
            // 
            this.mesaibox.Location = new System.Drawing.Point(123, 207);
            this.mesaibox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mesaibox.Name = "mesaibox";
            this.mesaibox.Size = new System.Drawing.Size(100, 29);
            this.mesaibox.TabIndex = 8;
            this.mesaibox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "İşçi ",
            "Mühendis"});
            this.comboBox1.Location = new System.Drawing.Point(113, 151);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 32);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(35, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Unvan:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.adTxt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.mesaibox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.adresTxt);
            this.panel1.Controls.Add(this.yasTxt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(29, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 428);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.birimCmbx);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cmb2Cmbx);
            this.panel2.Controls.Add(this.adTxt2);
            this.panel2.Controls.Add(this.adresTxt2);
            this.panel2.Controls.Add(this.yasTxt2);
            this.panel2.Controls.Add(this.mesai2Txt);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel2.Location = new System.Drawing.Point(680, 33);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(536, 428);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // birimCmbx
            // 
            this.birimCmbx.FormattingEnabled = true;
            this.birimCmbx.Items.AddRange(new object[] {
            "Arge",
            "Bakım ",
            "Satış"});
            this.birimCmbx.Location = new System.Drawing.Point(169, 277);
            this.birimCmbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.birimCmbx.Name = "birimCmbx";
            this.birimCmbx.Size = new System.Drawing.Size(121, 32);
            this.birimCmbx.TabIndex = 19;
            this.birimCmbx.SelectedIndexChanged += new System.EventHandler(this.birimCmbx_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(76, 283);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 24);
            this.label16.TabIndex = 18;
            this.label16.Text = "Birim:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(169, 320);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 50);
            this.button2.TabIndex = 16;
            this.button2.Text = "Mühendis Oluştur";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(49, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 24);
            this.label10.TabIndex = 15;
            this.label10.Text = "Mesai Saati:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(80, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "Unvan:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(80, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "Yaşınız :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(63, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Adresiniz :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(76, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Adınız :";
            // 
            // cmb2Cmbx
            // 
            this.cmb2Cmbx.FormattingEnabled = true;
            this.cmb2Cmbx.Items.AddRange(new object[] {
            "İşçi ",
            "Mühendis"});
            this.cmb2Cmbx.Location = new System.Drawing.Point(169, 166);
            this.cmb2Cmbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb2Cmbx.Name = "cmb2Cmbx";
            this.cmb2Cmbx.Size = new System.Drawing.Size(121, 32);
            this.cmb2Cmbx.TabIndex = 10;
            // 
            // adTxt2
            // 
            this.adTxt2.Location = new System.Drawing.Point(169, 22);
            this.adTxt2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adTxt2.Name = "adTxt2";
            this.adTxt2.Size = new System.Drawing.Size(100, 29);
            this.adTxt2.TabIndex = 6;
            // 
            // adresTxt2
            // 
            this.adresTxt2.Location = new System.Drawing.Point(169, 68);
            this.adresTxt2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adresTxt2.Name = "adresTxt2";
            this.adresTxt2.Size = new System.Drawing.Size(100, 29);
            this.adresTxt2.TabIndex = 5;
            // 
            // yasTxt2
            // 
            this.yasTxt2.Location = new System.Drawing.Point(169, 117);
            this.yasTxt2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yasTxt2.Name = "yasTxt2";
            this.yasTxt2.Size = new System.Drawing.Size(100, 29);
            this.yasTxt2.TabIndex = 4;
            // 
            // mesai2Txt
            // 
            this.mesai2Txt.Location = new System.Drawing.Point(169, 228);
            this.mesai2Txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mesai2Txt.Name = "mesai2Txt";
            this.mesai2Txt.Size = new System.Drawing.Size(100, 29);
            this.mesai2Txt.TabIndex = 3;
            this.mesai2Txt.TextChanged += new System.EventHandler(this.mesai2Txt_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.cmbboxisci);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.cmbbox3);
            this.panel3.Controls.Add(this.adTxt3);
            this.panel3.Controls.Add(this.adresTxt3);
            this.panel3.Controls.Add(this.yasTxt3);
            this.panel3.Controls.Add(this.mesaiTxt3);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel3.Location = new System.Drawing.Point(1299, 33);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(536, 428);
            this.panel3.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(76, 277);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 24);
            this.label17.TabIndex = 18;
            this.label17.Text = "Tür:";
            // 
            // cmbboxisci
            // 
            this.cmbboxisci.FormattingEnabled = true;
            this.cmbboxisci.Items.AddRange(new object[] {
            "Gündelik",
            "Kadro"});
            this.cmbboxisci.Location = new System.Drawing.Point(169, 273);
            this.cmbboxisci.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbboxisci.Name = "cmbboxisci";
            this.cmbboxisci.Size = new System.Drawing.Size(121, 32);
            this.cmbboxisci.TabIndex = 17;
            this.cmbboxisci.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(169, 320);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 50);
            this.button3.TabIndex = 16;
            this.button3.Text = "İşçi Oluştur";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(53, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 24);
            this.label11.TabIndex = 15;
            this.label11.Text = "Mesai Saati:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(80, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 24);
            this.label12.TabIndex = 14;
            this.label12.Text = "Unvan:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(80, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 24);
            this.label13.TabIndex = 13;
            this.label13.Text = "Yaşınız :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(63, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 24);
            this.label14.TabIndex = 12;
            this.label14.Text = "Adresiniz :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(76, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 24);
            this.label15.TabIndex = 11;
            this.label15.Text = "Adınız :";
            // 
            // cmbbox3
            // 
            this.cmbbox3.FormattingEnabled = true;
            this.cmbbox3.Items.AddRange(new object[] {
            "İşçi ",
            "Mühendis"});
            this.cmbbox3.Location = new System.Drawing.Point(169, 166);
            this.cmbbox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbbox3.Name = "cmbbox3";
            this.cmbbox3.Size = new System.Drawing.Size(121, 32);
            this.cmbbox3.TabIndex = 10;
            // 
            // adTxt3
            // 
            this.adTxt3.Location = new System.Drawing.Point(169, 22);
            this.adTxt3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adTxt3.Name = "adTxt3";
            this.adTxt3.Size = new System.Drawing.Size(100, 29);
            this.adTxt3.TabIndex = 6;
            // 
            // adresTxt3
            // 
            this.adresTxt3.Location = new System.Drawing.Point(169, 68);
            this.adresTxt3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adresTxt3.Name = "adresTxt3";
            this.adresTxt3.Size = new System.Drawing.Size(100, 29);
            this.adresTxt3.TabIndex = 5;
            // 
            // yasTxt3
            // 
            this.yasTxt3.Location = new System.Drawing.Point(169, 117);
            this.yasTxt3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yasTxt3.Name = "yasTxt3";
            this.yasTxt3.Size = new System.Drawing.Size(100, 29);
            this.yasTxt3.TabIndex = 4;
            // 
            // mesaiTxt3
            // 
            this.mesaiTxt3.Location = new System.Drawing.Point(169, 228);
            this.mesaiTxt3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mesaiTxt3.Name = "mesaiTxt3";
            this.mesaiTxt3.Size = new System.Drawing.Size(100, 29);
            this.mesaiTxt3.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1924, 803);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adresTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox yasTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mesaibox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb2Cmbx;
        private System.Windows.Forms.TextBox adTxt2;
        private System.Windows.Forms.TextBox adresTxt2;
        private System.Windows.Forms.TextBox yasTxt2;
        private System.Windows.Forms.TextBox mesai2Txt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbbox3;
        private System.Windows.Forms.TextBox adTxt3;
        private System.Windows.Forms.TextBox adresTxt3;
        private System.Windows.Forms.TextBox yasTxt3;
        private System.Windows.Forms.TextBox mesaiTxt3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbboxisci;
        private System.Windows.Forms.ComboBox birimCmbx;
    }
}

