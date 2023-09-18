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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

       

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ob1 = new Form1();
            ob1.Show();
        }
    }
}
