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
using System.Text.RegularExpressions;

namespace online_voting_application
{
    public partial class ELECTIONS : Form
    {
        public ELECTIONS()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_page adm = new Admin_page();
            adm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!=""|| textBox4.Text != "" || dateTimePicker1.Text != "" || dateTimePicker2.Text != "")
            {
                SqlConnection con = new SqlConnection("Data Source=CSE-BUSINESSMAN\\SQLEXPRESS;Initial Catalog=VOTER1;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[elections]
           ([title]
           ,[start]
           ,[finish]
           ,[description])
     VALUES
           ('" + textBox1.Text + "',  '"  +dateTimePicker1.Text + "', '" + dateTimePicker2.Text + "','" + textBox4.Text + "')", con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
               

            }
            else
            {
                MessageBox.Show("Please complete the entire form!", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (SqlConnection datag = new SqlConnection("Data Source=CSE-BUSINESSMAN\\SQLEXPRESS;Initial Catalog=VOTER1;Integrated Security=True"))
            {

                datag.Open();

                SqlDataAdapter sda = new SqlDataAdapter("Select (*) from elections", datag);
                DataTable dt = new DataTable();
                object p = datag.Fill(dt);
                dataGridView1.DataSource = dt;
            }



        }
    }
}
