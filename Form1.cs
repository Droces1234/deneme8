using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matematik_hesaplari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int birkenar, alan, cevre;
            birkenar = Convert.ToInt32(textBox1.Text);
            alan = birkenar * birkenar;
            cevre = 4 * birkenar;
            label4.Text = alan.ToString();
            label6.Text = cevre.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label7.Visible = false;
            textBox2.Visible = false;
            label1.Text = "Kare";
            button2.Visible = false;
            button4.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Dikdortgen";
            label2.Text = "Kısa Kenarı Girin";
            panel1.Visible = true;
            button4.Visible = false;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kisa, uzun, alan, cevre;
            kisa = Convert.ToInt32(textBox1.Text);
            uzun = Convert.ToInt32(textBox2.Text);
            alan = kisa * uzun;
            cevre = (2 * kisa) + (2 * uzun);
            label4.Text = alan.ToString();
            label6.Text = cevre.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
