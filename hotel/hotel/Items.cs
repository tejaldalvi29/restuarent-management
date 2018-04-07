using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hotel
{
    public partial class Items : Form
    {
        SqlConnection cs = new SqlConnection("data source=.;initial catalog=menulist;integrated security=true ");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        public static string SetItem = "";
        public static string Setprice = "";

       
        public Items()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            da.SelectCommand = new SqlCommand("select * from Mexican", cs);
            ds.Clear();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            //s.DataSource = ds.Tables[0];
            //.DataBindings.Add(new Binding("text", bs, "items"));
            //extBox3.DataBindings.Add(new Binding("text", bs, "price"));
            //bs.DataSource = ds.Tables[0];

           //a.DataBindings.Add(new Binding("text", bs, "items"));
            //textBox3.DataBindings.Add(new Binding("text", bs, "price"));
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            da.SelectCommand = new SqlCommand("select * from Indian", cs);
            ds.Clear();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            bs.DataSource = ds.Tables[0];
            a.DataBindings.Add(new Binding("text", bs, "items"));
            textBox3.DataBindings.Add(new Binding("text", bs, "price"));


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            da.SelectCommand = new SqlCommand("select * from chinese", cs);
            ds.Clear();
            da.Fill(ds);
           
            dataGridView1.DataSource = ds.Tables[0];
            //.DataSource = ds.Tables[0];
            //.DataBindings.Add(new Binding("text", bs, "items"));
            //extBox3.DataBindings.Add(new Binding("text", bs, "price"));
            //bs.DataSource = ds.Tables[0];
            //a.DataBindings.Add(new Binding("text", bs, "items"));
            //textBox3.DataBindings.Add(new Binding("text", bs, "price"));
        }

        
        private void button9_Click(object sender, EventArgs e)
        {
            da.SelectCommand = new SqlCommand("select * from Beverages", cs);
            ds.Clear();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            //bs.DataSource = ds.Tables[0];
            //a.DataBindings.Add(new Binding("text", bs, "items"));
            //textBox3.DataBindings.Add(new Binding("text", bs, "price"));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            da.SelectCommand = new SqlCommand("select * from FastFood", cs);
            ds.Clear();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            //bs.DataSource = ds.Tables[0];
            //a.DataBindings.Add(new Binding("text", bs, "items"));
            //textBox3.DataBindings.Add(new Binding("text", bs, "price"));
        }
        private void dgb()
        {
            dataGridView1.ClearSelection();
            dataGridView1.Rows[bs.Position].Selected = true;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
            dgb();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
            dgb();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            da.InsertCommand = new SqlCommand("insert into menulist values(@items,@price)",cs);
            da.InsertCommand.Parameters.Add("items", SqlDbType.VarChar).Value = a.Text;
            da.InsertCommand.Parameters.Add("price", SqlDbType.Int).Value = textBox3.Text;
            cs.Open();
            da.InsertCommand.ExecuteNonQuery();
            cs.Close();
            MessageBox.Show("INserted");
        }

    public  void button7_Click(object sender, EventArgs e)
        {
            BIll objb = new BIll();
            objb.Show();
            this.Hide();

        }

        private void a_TextChanged(object sender, EventArgs e)
        {

        }

    public  void button8_Click(object sender, EventArgs e)
        {
            BIll objb = new BIll();
            // objb.listBox1.Items.Add(a.Text);
            //    objb.listBox2.Items.Add(textBox3.Text);
            //   objb.listBox5.Items.Add(comboBox1.SelectedText);
            da.InsertCommand = new SqlCommand("insert into detailss values(@ITEMS,@QUANTITY,@PRICE)",cs);
            da.InsertCommand.Parameters.Add("ITEMS",SqlDbType.VarChar).Value=a.Text;
            da.InsertCommand.Parameters.Add("QUANTITY",SqlDbType.Int).Value=comboBox1.Text;
            da.InsertCommand.Parameters.Add("PRICE",SqlDbType.Int).Value=textBox3.Text;
            cs.Open();
            da.InsertCommand.ExecuteNonQuery();
            cs.Close();
            
            MessageBox.Show("Added");
          
        }

      

        private void button11_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
            dgb();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
            dgb();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
