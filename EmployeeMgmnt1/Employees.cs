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
    public partial class Employees : Form
    {
        Functions Con;
        public Employees()
        {
            InitializeComponent();
            Con = new Functions();
            ShowEmp();
            GetDepartement();
        }
        private void ShowEmp()
        {
            try
            {
                string Query = "Select * from EmployeeTbl";
                EmpList.DataSource = Con.GetData(Query);
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void GetDepartement()
        {
            string Query = "select * from DepartementTbl";
            DepCb.DisplayMember = Con.GetData(Query).Columns["DepName"].ToString();
            DepCb.ValueMember = Con.GetData(Query).Columns["DepId"].ToString();
            DepCb.DataSource = Con.GetData(Query);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNameTb.Text == "" || GenCb.SelectedIndex == -1 || DepCb.SelectedIndex == -1 || DailySalTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!");
                }
                else
                {
                    string Name = EmpNameTb.Text;
                    string Gender = GenCb.SelectedItem.ToString();
                    int Dep = Convert.ToInt32(DepCb.SelectedValue.ToString());
                    string DOB = DOBTb.Value.ToString("yyyy-MM-dd");
                    string JDate = JDateTb.Value.ToString("yyyy-MM-dd");
                    int Salary = Convert.ToInt32(DailySalTb.Text);
                    string Query = "insert into EmployeeTbl (EmpName, EmpGen, EmpDep, EmpDOB, EmpJDate, EmpSal) values('{0}','{1}',{2},'{3}','{4}',{5})";
                    Query = string.Format(Query, Name, Gender, Dep, DOB, JDate, Salary);
                    Con.SetData(Query);
                    ShowEmp();
                    MessageBox.Show("Employee Added!!!");
                    EmpNameTb.Text = "";
                    DailySalTb.Text = "";
                    GenCb.SelectedIndex = -1;
                    DepCb.SelectedIndex = -1;

                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (key == 0)
                {
                    MessageBox.Show("Missing Data!!");
                }
                else
                {

                    string Query = "delete from  EmployeeTbl where EmpId ={0}";
                    Query = string.Format(Query, key);
                    Con.SetData(Query);
                    ShowEmp();
                    MessageBox.Show("Employee Deleted!!!");
                    EmpNameTb.Text = "";
                    DailySalTb.Text = "";
                    GenCb.SelectedIndex = -1;
                    DepCb.SelectedIndex = -1;

                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }


        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNameTb.Text == "" || GenCb.SelectedIndex == -1 || DepCb.SelectedIndex == -1 || DailySalTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!");
                }
                else
                {
                    string Name = EmpNameTb.Text;
                    string Gender = GenCb.SelectedItem.ToString();
                    int Dep = Convert.ToInt32(DepCb.SelectedValue.ToString());
                    string DOB = DOBTb.Value.ToString("yyyy-MM-dd");
                    string JDate = JDateTb.Value.ToString("yyyy-MM-dd");
                    int Salary = Convert.ToInt32(DailySalTb.Text);
                    string Query = "update EmployeeTbl set EmpName = '{0}' , EmpGen = '{1}', EmpDep = {2}, EmpDOB = '{3}', EmpJDate = '{4}', EmpSal = {5} where EmpId ={6}";
                    Query = string.Format(Query, Name, Gender, Dep, DOB, JDate, Salary, key);
                    Con.SetData(Query);
                    ShowEmp();
                    MessageBox.Show("Employee Updated!!!");
                    EmpNameTb.Text = "";
                    DailySalTb.Text = "";
                    GenCb.SelectedIndex = -1;
                    DepCb.SelectedIndex = -1;

                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        int key = 0;
        private void EmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpNameTb.Text = EmpList.SelectedRows[0].Cells[1].Value.ToString();
            GenCb.Text = EmpList.SelectedRows[0].Cells[2].Value.ToString();
            DepCb.SelectedValue = EmpList.SelectedRows[0].Cells[3].Value.ToString();
            DOBTb.Text = EmpList.SelectedRows[0].Cells[4].Value.ToString();
            JDateTb.Text = EmpList.SelectedRows[0].Cells[5].Value.ToString();
            DailySalTb.Text = EmpList.SelectedRows[0].Cells[6].Value.ToString();

            if (EmpNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(EmpList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Salaries Obj = new Salaries();
            Obj.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            LoginAccount Obj = new LoginAccount();
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
