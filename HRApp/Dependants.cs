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
    public partial class Dependants : Form
    {
        HRDBContext context;
        int empId;
        Employee emp;
        public Dependants(int empId)
        {
            InitializeComponent();
            context = new HRDBContext();
            this.empId = empId;
        }

        private void Dependants_Load(object sender, EventArgs e)
        {
            emp = context.Employees.First(x => x.EmployeeId == empId);
            lblEmployeeName.Text = emp.FirstName + " " + emp.LastName;
            populateFields();

        }

        private void populateFields()
        {

            dgvDependants.DataSource = context.Dependents.Where(x => x.Employee.EmployeeId == empId).ToList();
        }

        private void btnAddDependant_Click(object sender, EventArgs e)
        {
            d
        }
    }
}
