using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Trackmate___Finance_Tracker_Management_System
{
    public partial class Income : Form
    {
        public Income()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\QUIENIE MAE\OneDrive\Documents\FInanceDb.mdf"";Integrated Security=True;Connect Timeout=30");
        private void Clear()
        {
            Lbl_Source.Text = "";
            Lbl_Earned.Text = "";
            Lbl_Date.Text = "";
            Lbl_Description.Text = "";
            Lbl_CatCb.Text = "0";
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (Lbl_Source.Text == "" || Lbl_Earned.Text == "" || Lbl_Date.Text == "" || Lbl_Description.Text == "" || Lbl_CatCb.Text == "-1" ) 
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into IncomeTable(IncName, IncAmt, IncomeCat, IncomeDescript, IncomeDate) values (@IN, @IA, @IC, @ID, @IT)", Con);
                    cmd.Parameters.AddWithValue("@IN", Lbl_Source.Text);
                    cmd.Parameters.AddWithValue("@IA", Lbl_Earned.Text);
                    cmd.Parameters.AddWithValue("@IC", Lbl_CatCb.Text);
                    cmd.Parameters.AddWithValue("@ID", Lbl_Description.Text);
                    cmd.Parameters.AddWithValue("@IT", Lbl_Date.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("You are now Registered !!!");
                    Con.Close();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }



        }

        private void Income_Load(object sender, EventArgs e)
        {
            if (Lbl_Source.Text == "" || Lbl_Earned.Text == "" || Lbl_Description.Text == "" || Lbl_CatCb.Text == "-1" || Lbl_Date.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();

                    // Insert the data into the database
                    SqlCommand cmd = new SqlCommand("insert into IncomeTab(UName, UPass, ConfirmPass, EmailAdd, ContactNum) values (@UN, @UP, @CP, @EA, @CN)", Con);
                    cmd.Parameters.AddWithValue("@UN", Lbl_Source.Text);
                    cmd.Parameters.AddWithValue("@UP", Lbl_Earned.Text);
                    cmd.Parameters.AddWithValue("@CP", Lbl_Description.Text);
                    cmd.Parameters.AddWithValue("@EA", Lbl_CatCb.Text);
                    cmd.Parameters.AddWithValue("@CN", Lbl_Date.Text);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
