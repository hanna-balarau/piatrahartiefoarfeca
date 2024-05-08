using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace piatrahartiefoarfeca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random x = new Random();
            int n = x.Next(3);
            Image a = Image.FromFile(@"C:\Users\elev\Desktop\piatra.jpg");
            pictureBox2.Image = a;
            if (n == 0)
            {
                Image p = Image.FromFile(@"C:\Users\elev\Desktop\piatra.jpg");
                pictureBox1.Image = p;
                MessageBox.Show("egalitate");
            }
            if (n == 1)
            {
                Image p = Image.FromFile(@"C:\Users\elev\Desktop\hartie.jpg");
                pictureBox1.Image = p;
                MessageBox.Show("ai pierdut");
            }
            if (n == 2)
            {
                Image p = Image.FromFile(@"C:\Users\elev\Desktop\foarfeca.jpg");
                pictureBox1.Image = p;
                MessageBox.Show("ai castigat");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random x = new Random();
            int n = x.Next(3);
            Image a = Image.FromFile(@"C:\Users\elev\Desktop\hartie.jpg");
            pictureBox2.Image = a;
            if (n == 0)
            {
                Image p = Image.FromFile(@"C:\Users\elev\Desktop\piatra.jpg");
                pictureBox1.Image = p;
                MessageBox.Show("ai castigat");
            }
            if (n == 1)
            {
                Image p = Image.FromFile(@"C:\Users\elev\Desktop\hartie.jpg");
                pictureBox1.Image = p;
                MessageBox.Show("egalitate");
            }
            if (n == 2)
            {
                Image p = Image.FromFile(@"C:\Users\elev\Desktop\foarfeca.jpg");
                pictureBox1.Image = p;
                MessageBox.Show("ai pierdut");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random x = new Random();
            int n = x.Next(3);
            Image a = Image.FromFile(@"C:\Users\elev\Desktop\foarfeca.jpg");
            pictureBox2.Image = a;
            if (n == 0)
            {
                Image p = Image.FromFile(@"C:\Users\elev\Desktop\piatra.jpg");
                pictureBox1.Image = p;
                MessageBox.Show("ai pierdut");
            }
            if (n == 1)
            {
                Image p = Image.FromFile(@"C:\Users\elev\Desktop\hartie.jpg");
                pictureBox1.Image = p;
                MessageBox.Show("ai castigat");
            }
            if (n == 2)
            {
                Image p = Image.FromFile(@"C:\Users\elev\Desktop\foarfeca.jpg");
                pictureBox1.Image = p;
                MessageBox.Show("egalitate");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
