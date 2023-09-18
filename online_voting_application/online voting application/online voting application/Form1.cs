using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace online_voting_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


       

        private void button1_Click(object sender, EventArgs e)// login button
        {
            this.Hide();
            Form2 ob2 = new Form2();
            ob2.Show();
        }

        private void button3_Click(object sender, EventArgs e)//register button
        {
            this.Hide();
            Form3 ob1 = new Form3();
            ob1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 ob4 = new Form4();
            ob4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }





    }
}
