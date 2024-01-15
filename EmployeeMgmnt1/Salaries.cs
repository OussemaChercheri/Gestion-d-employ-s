using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeMgmnt1
{
    public partial class Salaries : Form
    {
        Functions Con;
        public Salaries()
        {
            InitializeComponent();
            Con = new Functions();
            ShowSal();
            GetEmployees();
        }

        private void ShowSal()
        {
            try
            {
                string Query = "Select * from SalaryTbl";
                SalList.DataSource = Con.GetData(Query);
            }
            catch (Exception)
            {
                throw;
            }

        }
        private void GetEmployees()
        {
            string Query = "select * from EmployeeTbl";
            EmployeeCb.DisplayMember = Con.GetData(Query).Columns["EmpName"].ToString();
            EmployeeCb.ValueMember = Con.GetData(Query).Columns["EmpId"].ToString();
            EmployeeCb.DataSource = Con.GetData(Query);
        }
        int DSal = 0;
        string Period = "";
        private void GetSalary()
        {
            string Query = "select EmpSal from EmployeeTbl where EmpId = {0}";
            Query = string.Format(Query, EmployeeCb.SelectedValue.ToString());
            foreach (DataRow dr in Con.GetData(Query).Rows)
            {
                DSal = Convert.ToInt32(dr["EmpSal"].ToString());
            }
            //MessageBox.Show("" + DSal);
            if (DaysTb.Text == "")
            {
                AmountTb.Text = "Rs " + (DSal);
            }
            else if (Convert.ToInt32(DaysTb.Text) > 31)
            {
                MessageBox.Show("Days Can not Be Greater Then 31");
            }
            {
                d = Convert.ToInt32(DaysTb.Text);
                AmountTb.Text = "Rs " + (d * DSal);
            }
        }
        private void ShowSalaries()
        {
            try
            {
                string Query = "Select * from SalaryTbl";
                SalList.DataSource = Con.GetData(Query);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SalList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int d = 1;
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmployeeCb.SelectedIndex == -1 || DaysTb.Text == "" || PeriodTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string period = PeriodTb.Value.Date.ToString("yyyy-MM-dd");
                    int Amount = DSal * Convert.ToInt32(DaysTb.Text);
                    int Days = Convert.ToInt32(DaysTb.Text);
                    string Query = "insert into SalaryTbl values({0},{1},'{2}',{3},'{4:yyyy-MM-dd}')";
                    Query = string.Format(Query, EmployeeCb.SelectedValue.ToString(), Days, Period, Amount, DateTime.Today.Date);
                    Con.SetData(Query);
                    ShowSalaries();
                    MessageBox.Show("Employee Paid!!!");
                    DaysTb.Text = "";
                }


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);

            }
        }

        private void EmployeeCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetSalary();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            LoginAccount Obj = new LoginAccount();
            Obj.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Employees Obj = new Employees();
            Obj.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Departements Obj = new Departements();
            Obj.Show();
            this.Hide();
        }
    }
}
