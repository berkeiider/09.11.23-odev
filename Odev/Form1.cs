using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Odev
{
    public partial class Form1 : Form
    {
        private object mesaitxt;
        private object mesaiTxt2;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel pers = new Personel(adTxt.Text, adresTxt.Text, Convert.ToInt32(yasTxt.Text), Convert.ToInt32(mesaibox.Text), comboBox1.Text);
            
            if (comboBox1.Text== "İşçi")
            {
                MessageBox.Show(pers.ucretHesapla().ToString());
            }
          else
            {
                pers.ucretHesapla(100);

            }
            comboBox1.Items.Add("İşçi");
            comboBox1.Items.Add("Mühendis");

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            muhendis muh = new muhendis();
            muh.Ad = adTxt2.Text;
            muh.Adres = adresTxt2.Text;
            muh.Yas = Convert.ToInt32 (yasTxt2.Text);
            muh.Unvan = cmb2Cmbx.Text;
            muh.Birim = birimCmbx.Text;
            muh.Mesai = Convert.ToInt32 (mesai2Txt.Text);
            MessageBox.Show(muh.ucretHesapla().ToString());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
         

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void mesai2Txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void birimCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            isci iscim = new isci();
            iscim.Ad = adTxt3.Text;
            iscim.Adres = adresTxt3.Text;
            iscim.Unvan = cmbbox3.Text;
            iscim.Tur = cmbboxisci.Text;
            iscim.Yas = Convert.ToInt32(yasTxt3.Text);
            iscim.Mesai = Convert.ToInt32(mesaiTxt3.Text);
            MessageBox.Show(iscim.ucretHesapla2().ToString());
        }
    }
}
