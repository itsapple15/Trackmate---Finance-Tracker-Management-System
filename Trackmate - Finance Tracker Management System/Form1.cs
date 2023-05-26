using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Trackmate___Finance_Tracker_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\QUIENIE MAE\\OneDrive\\Documents\\FInanceDb.mdf;Integrated Security=True;Connect Timeout=30");
        public static string Registration;     
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_username.Text) && string.IsNullOrEmpty(txt_password.Text))
            {
                MessageBox.Show("Enter both Username and Password");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "SELECT COUNT(*) FROM RegisterTab WHERE UName=@UName AND UPass=@UPass";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@UName", txt_username.Text);
                    cmd.Parameters.AddWithValue("@UPass", txt_password.Text);

                    int count = (int)cmd.ExecuteScalar();

                    if (count == 1)
                    {
                        Registration = txt_username.Text;
                        Form4_Dashboard dashboard = new Form4_Dashboard();
                        dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password!");
                        txt_username.Text = "";
                        txt_password.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    Con.Close();
                }
            }

        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            Registration Obj = new Registration();
            Obj.Show();
        }

        private void Btn_ForgetPass_Click(object sender, EventArgs e)
        {
            Form3_ForgetPassword Obj = new Form3_ForgetPassword();
            Obj.Show();

        }
    }
}