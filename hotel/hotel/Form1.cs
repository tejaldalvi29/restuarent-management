using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new1 f2=new new1();
            if (textBox1.Text == "Sneha Chavan" && textBox2.Text == "snehachavan" ||
                textBox1.Text == "Anushree Ghag" && textBox2.Text == "anushreeghag" ||
                //textBox1.Text == "Tushar Bhadarka" && textBox2.Text == "tusharbhadarka" ||
                //textBox1.Text == "Avinash Monde" && textBox2.Text == "avinashmonde" ||
                textBox1.Text == "Tejal Dalvi" && textBox2.Text == "tejaldalvi" ||
                textBox1.Text == "" && textBox2.Text == "")

            {
                f2.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("You are not our member");
                textBox1.Text = "";
                textBox2.Text = "";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Left -= 3;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            first f = new first();
            f.Show();
            this.Hide();
        }
    }
}
