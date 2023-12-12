using ems_app.BL;
using ems_app.DL;
using ems_app.Forms;
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

namespace ems_app.UC
{
    public partial class Emp_panel2 : Form
    {
        BL.Employees emp_data;
        bool flag;
        public Emp_panel2()
        {
            InitializeComponent();
            DepartmentDL.LoadDeptFromDB();
            foreach (BL.Department data in DepartmentDL.dept_list)
            {
                cbdepartment.Items.Add(data.Name);
            }
        }
        public Emp_panel2(BL.Employees data)
        {
            InitializeComponent();
            DepartmentDL.LoadDeptFromDB();
            foreach (BL.Department dept_data in DepartmentDL.dept_list)
            {
                cbdepartment.Items.Add(dept_data.Name);
            }
            this.emp_data = data;
            nametxt.Text = emp_data.Name;
            salarytxt.Text = emp_data.Salary.ToString();
            ratingtxt.Text = emp_data.Rating.ToString();
            foreach (BL.Department dept in DepartmentDL.dept_list)
            {
                if (dept.Id == emp_data.Department_Id)
                {
                    cbdepartment.Text = dept.Name;
                }
            }
            flag = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                int id = emp_data.Id;
                int attendance = emp_data.Attendance;
                int salary= emp_data.Salary;
                String name = nametxt.Text;
                int rating = Convert.ToInt32(ratingtxt.Text);
                int department;

                foreach (BL.Department dept in DepartmentDL.dept_list)
                {
                    if (dept.Name == cbdepartment.Text)
                    {
                        department = dept.Id;
                        BL.Employees empUser = new BL.Employees(id, name, department, salary,attendance, rating);
                        EmployeesDL.UpdateEmpinDB(empUser);
                        break;
                    }
                }           
            }
            else
            {
                int id = emp_data.Id;
                int attendance = emp_data.Attendance;
                int salary = emp_data.Salary;
                String name = nametxt.Text;
                int rating = Convert.ToInt32(ratingtxt.Text);
                int department;

                foreach (BL.Department dept in DepartmentDL.dept_list)
                {
                    if(dept.Name == cbdepartment.Text) 
                    {
                        department = dept.Id;
                        BL.Employees empUser = new BL.Employees(name, department, salary, attendance, rating);
                        EmployeesDL.AddUserinDB(empUser);
                        break;
                    }
                }

                
            }
            
        }
    }
}
