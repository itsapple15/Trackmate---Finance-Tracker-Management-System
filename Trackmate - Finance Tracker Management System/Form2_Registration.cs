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

namespace Trackmate___Finance_Tracker_Management_System
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\QUIENIE MAE\OneDrive\Documents\FInanceDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void Clear()
        {
            textBox1.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
        private void Btn_Done_Click(object sender, EventArgs e)
        {
            if
                (textBox1.Text == "" && textBox3.Text == "" && textBox2.Text == "" && textBox4.Text == "" && textBox5.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();

                    // Insert the data into the database
                    SqlCommand cmd = new SqlCommand("insert into RegisterTab(UName, UPass, ConfirmPass, EmailAdd, ContactNum) values (@UN, @UP, @CP, @EA, @CN)", Con);
                    cmd.Parameters.AddWithValue("@UN", textBox1.Text);
                    cmd.Parameters.AddWithValue("@UP", textBox3.Text);
                    cmd.Parameters.AddWithValue("@CP", textBox2.Text);
                    cmd.Parameters.AddWithValue("@EA", textBox4.Text);
                    cmd.Parameters.AddWithValue("@CN", textBox5.Text);
                    cmd.ExecuteNonQuery();

                    Con.Close();
                    Clear();

                    MessageBox.Show("You are now Registered !!!");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }





        }
    }
}
