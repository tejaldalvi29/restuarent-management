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
    public partial class first : Form
    {
        public first()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.maxresdefault;
            Timer tim = new Timer();
            tim.Interval = 1000;
            tim.Tick += new EventHandler(ChangeImage);
            tim.Start();
        }
        private void ChangeImage(object sender, EventArgs e)
        {
            List<Bitmap> b1 = new List<Bitmap>();
            
            b1.Add(Properties.Resources.my_bar_headquarters_connaught_place_11);
            b1.Add(Properties.Resources.my_bar_headquarters_connaught_place_21);
            b1.Add(Properties.Resources.my_bar_headquarters_connaught_place_3);
            b1.Add(Properties.Resources.my_bar_headquarters_connaught_place_5);
            b1.Add(Properties.Resources.my_bar_headquarters_connaught_place_7);
            b1.Add(Properties.Resources.my_bar_headquarters_connaught_place_9);
            b1.Add(Properties.Resources.o);
            b1.Add(Properties.Resources.maxresdefault);
            
           
            int index = DateTime.Now.Second % b1.Count;
            this.BackgroundImage = b1[index];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void first_Load(object sender, EventArgs e)
        {

        }
    }
}
