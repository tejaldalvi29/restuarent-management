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
    public partial class BIll : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;
        string str1,str2,str3;
        
        public BIll(string str1,string str2,string str3)
            
        {
            InitializeComponent();
            this.str1 = str1;
            this.str2 = str2;
            this.str3 = str3;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BIll_Load(object sender, EventArgs e)
        {
            
            listBox1.Items.Add(str1);
            listBox2.Items.Add(str2);
            listBox5.Items.Add(str3);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
           

        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text=="0")||(operation_pressed))
            {
                textBox1.Clear();
            }
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value =Double.Parse( textBox1.Text);
            operation_pressed = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            switch(operation)
            {
                case "+":
                    textBox1.Text=(value+ Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (value - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (value *  Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (value / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
            operation_pressed = false;
            textBox2.Text = textBox1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

       
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void listBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
           
            Items i = new Items();
            i.Show();

        }

        private void button19_Click(object sender, EventArgs e)
        {
          
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox3.Text = comboBox1.Text;
            textBox4.Text = textBox6.Text;

            do
            {
                listBox3.Items.Add(listBox1.Text);
            }
            while (listBox1.SelectedIndex > 0);
            do
            {
                listBox4.Items.Add(listBox2.Text);
            }
            while (listBox2.SelectedIndex > 0);

            do
            {
                listBox6.Items.Add(listBox5.Text);
            }
            while (listBox5.SelectedIndex > 0);

            table tb = new table();
            tb.button1.BackColor = Color.Green;
            tb.button2.BackColor = Color.Green;
            tb.button3.BackColor = Color.Green;
            tb.button4.BackColor = Color.Green;
            tb.button5.BackColor = Color.Green;
            tb.button6.BackColor = Color.Green;
            tb.button7.BackColor = Color.Green;
            tb.button8.BackColor = Color.Green;
            tb.button9.BackColor = Color.Green;
            tb.button10.BackColor = Color.Green;
            tb.button11.BackColor = Color.Green;
            tb.button12.BackColor = Color.Green;
            tb.button13.BackColor = Color.Green;
            tb.button14.BackColor = Color.Green;
            tb.button15.BackColor = Color.Green;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBox6.Text = "";
            textBox2.Text = "";
            checkBox1.Checked = false;
            listBox1.Text = "";
            listBox2.Text = "";
            listBox5.Text = "";


        
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if(checkBox1.Checked==true)
            {
                textBox6.Text = (25 + Double.Parse(textBox2.Text)).ToString();
            }
        }

        private void listBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }
    }
}
