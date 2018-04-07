using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Web;
using System.Data.SqlClient;
namespace hotel
{
    public partial class BIll : Form
    {

        SqlConnection cs = new SqlConnection("data source=.;initial catalog=menulist;integrated security=true ");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;
        string message;

        private double accumulator = 0;
        private char lastOperation;

        public BIll()


        {
            InitializeComponent();

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
            //  listBox1.Text = message;
            da.SelectCommand = new SqlCommand("select * from detailss", cs);
            ds.Clear();
            da.Fill(ds);
            grid.DataSource = ds.Tables[0];

            da.SelectCommand = new SqlCommand("select * from detailss", cs);
            ds.Clear();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Display.Text = "0";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {


        }

        private void button_Click(object sender, EventArgs e)
        {

            // Add it to the display.
            string number = (sender as Button).Text;
            Display.Text = Display.Text == "0" ? number : Display.Text + number;
        }
    

        private void operator_click(object sender, EventArgs e)
        {
            char operation = (sender as Button).Text[0];
            if (operation == 'C')
            {
                accumulator = 0;
            }
            else
            {
                double currentValue = double.Parse(Display.Text);
                switch (lastOperation)
                {
                    case '+': accumulator += currentValue; break;
                    case '-': accumulator -= currentValue; break;
                    case '*': accumulator *= currentValue; break;
                    case '/': accumulator /= currentValue; break;
                    default: accumulator = currentValue; break;
                        
                }
            }

            lastOperation = operation;
            Display.Text = operation == '=' ? accumulator.ToString() : "0";
            textBox2.Text = Display.Text;
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

        /*
        do
            {
                //listBox3.Items.Add(listBox1.Text);
            }
            while (listBox1.SelectedIndex > 0);
            do
            {
               // listBox4.Items.Add(listBox2.Text);
            }
            while (listBox2.SelectedIndex > 0);

            do
            {
                //listBox6.Items.Add(listBox5.Text);
            }
            while (listBox5.SelectedIndex > 0);  */

            new1 tb = new new1();
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
            tb.button16.BackColor = Color.Green;
            tb.button17.BackColor = Color.Green;
            tb.button18.BackColor = Color.Green;
            tb.button19.BackColor = Color.Green;
            tb.button20.BackColor = Color.Green;
            tb.button21.BackColor = Color.Green;
            tb.button22.BackColor = Color.Green;
            tb.button23.BackColor = Color.Green;
            tb.button24.BackColor = Color.Green;
            tb.button25.BackColor = Color.Green;
            tb.button26.BackColor = Color.Green;
            tb.button27.BackColor = Color.Green;
          
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBox6.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            checkBox1.Checked = false;
            //listBox1.Text = "";
            //listBox2.Text = "";
            //listBox5.Text = "";
            ds.Clear();
            dataGridView1.DataSource = ds.Tables[0];
            grid.DataSource = ds.Tables[0];




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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            String from = "paradisehotel383@gmail.com";
            String body = "Thankyou for Ordering";
            String subject = "Paradise Hotel";
            String password = "avinash123";
            String smtp12 = "smtp.gmail.com";
            MailMessage mail = new MailMessage(from,textBox5.Text,subject,body);
            SmtpClient client = new SmtpClient(smtp12);
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential(from,password);
            client.EnableSsl = true;
            client.Send(mail);
            da.DeleteCommand = new SqlCommand("delete  from detailss",cs);
            cs.Open();
            da.DeleteCommand.ExecuteNonQuery();
            cs.Close();
            MessageBox.Show("Order Completed");
            da.SelectCommand = new SqlCommand("Select * from detailss",cs);
            ds.Clear();
            da.Fill(ds);
            bs.DataSource = ds.Tables[0];
           
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
