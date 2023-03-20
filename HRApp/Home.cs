using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRBusinessObjects;

namespace HRApp
{
    public partial class Home : Form
    {
        HRDBContext context;
      
        public Home()
        {

            InitializeComponent();
            context = new HRDBContext();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            ddlDepartments.DataSource = context.Departments.ToList();
            ddlDepartments.DisplayMember = "DepartmentName";
            ddlDepartments.ValueMember = "DepartmentId";
            ddlDepartments.Text = "";
            txtFilterEmployeeID.Text = "";
            refreshGridView();
            
        }

        private void refreshGridView()
        {

            dgvEmployees.DataSource = null;

            var EmpToShow = context.Employees.AsQueryable();

            if (ddlDepartments.Text != "" && txtFilterEmployeeID.Text == "")
            {
                EmpToShow = EmpToShow.Where(x => x.Department.DepartmentName == ddlDepartments.Text);
            }
            else if (ddlDepartments.Text == "" && txtFilterEmployeeID.Text != "")
            {
                EmpToShow = EmpToShow.Where(x => x.EmployeeId == Convert.ToInt32(txtFilterEmployeeID.Text));
            }
            else if (ddlDepartments.Text != "" && txtFilterEmployeeID.Text != "")
            {
                EmpToShow = EmpToShow.Where(x => x.EmployeeId == Convert.ToInt32(txtFilterEmployeeID.Text)).Where(n => n.Department.DepartmentId == Convert.ToInt32(ddlDepartments.SelectedValue));
            }

            dgvEmployees.DataSource = EmpToShow.Select(x => new
            {
                EmployeeID = x.EmployeeId,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Dept = x.Department.DepartmentName,
                JobTitle = x.Job.JobTitle,
                Manager = x.Manager.FirstName + " " + x.Manager.LastName

            }

            ).ToList();

           
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            refreshGridView();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ddlDepartments.Text = "";
            txtFilterEmployeeID.Text = "";
            refreshGridView();
        }

        private void btnViewDependants_Click(object sender, EventArgs e)
        {
            int firstCell = Convert.ToInt32(dgvEmployees.SelectedCells[0].OwningRow.Cells[0].Value);
            Dependants frm = new Dependants(firstCell);
            frm.ShowDialog();
        }
    }
}
