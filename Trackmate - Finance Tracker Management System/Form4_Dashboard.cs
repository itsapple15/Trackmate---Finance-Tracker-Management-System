using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trackmate___Finance_Tracker_Management_System
{
    public partial class Form4_Dashboard : Form
    {
        public Form4_Dashboard()
        {
            InitializeComponent();
        }

        private void Dahboard_btn_Click(object sender, EventArgs e)
        {
            Form4_Dashboard Obj = new Form4_Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void Income_btn_Click(object sender, EventArgs e)
        {
            Income Obj = new Income();
            Obj.Show();
            this.Hide();
        }

        private void Expense_btn_Click(object sender, EventArgs e)
        {

            Expense Obj = new Expense();
            Obj.Show();
            this.Hide();

        }

        private void IncomeInfo_btn_Click(object sender, EventArgs e)
        {
            IncomeInfo Obj = new IncomeInfo();
            Obj.Show();
            this.Hide();
        }

        private void ExpenseInfo_btn_Click(object sender, EventArgs e)
        {
            ExpenseInfo Obj = new ExpenseInfo();
            Obj.Show();
            this.Hide();
        }

        private void Goal_btn_Click(object sender, EventArgs e)
        {
            Goals Obj = new Goals();
            Obj.Show();
            this.Hide();
        }

        private void Gtracking_btn_Click(object sender, EventArgs e)
        {
            GoalTracking Obj = new GoalTracking();
            Obj.Show();
            this.Hide();
        }

        private void Reminder_btn_Click(object sender, EventArgs e)
        {
            Reminders Obj = new Reminders();
            Obj.Show();
            this.Hide();
        } 

    }
}
