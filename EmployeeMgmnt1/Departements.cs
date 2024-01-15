using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeMgmnt1
{
    public partial class Departements : Form
    {
        Functions Con;
        public Departements()
        {
            InitializeComponent();
            Con = new Functions();
            ShowDepartements();
        }
        private void ShowDepartements()
        {
            string Query = "Select * from DepartementTbl";
            DepList.DataSource = Con.GetData(Query);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                    string Query = "insert into DepartementTbl values('{0}')";
                    Query = string.Format(Query, DepNameTb.Text);
                    Con.SetData(Query);
                    ShowDepartements();
                    MessageBox.Show("Departement Added!!!");
                    DepNameTb.Text = "";
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        int Key = 0;
        private void DepList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DepNameTb.Text = DepList.SelectedRows[0].Cells[1].Value.ToString();
            if (DepNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(DepList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                    string Query = "Update DepartementTbl set DepName = '{0}' where DepId = {1}";
                    Query = string.Format(Query, DepNameTb.Text, Key);
                    Con.SetData(Query);
                    ShowDepartements();
                    MessageBox.Show("Departement Updated!!!");
                    DepNameTb.Text = "";
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                    string Query = "Delete from DepartementTbl where DepId = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    ShowDepartements();
                    MessageBox.Show("Departement Deleted!!!");
                    DepNameTb.Text = "";
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void EmpLbl_Click(object sender, EventArgs e)
        {
            Employees Obj = new Employees();
            Obj.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Salaries Obj = new Salaries();
            Obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
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
