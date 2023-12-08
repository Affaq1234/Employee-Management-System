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
    public partial class HOD_panel2 : Form
    {
        BL.HOD hod_data;
        bool flag;
        public HOD_panel2()
        {
            InitializeComponent();
            DepartmentDL.LoadDeptFromDB();
            foreach (BL.Department data in DepartmentDL.dept_list)
            {
                cbdepartment.Items.Add(data.Name);
            }
        }
        public HOD_panel2(BL.HOD data)
        {
            InitializeComponent();
            DepartmentDL.LoadDeptFromDB();
            foreach (BL.Department dept_data in DepartmentDL.dept_list)
            {
                cbdepartment.Items.Add(dept_data.Name);
            }
            this.hod_data = data;
            nametxt.Text = hod_data.Name;
            emailtxt.Text = hod_data.Email;
            passwordtxt.Text = hod_data.Password;
            agetxt.Text = hod_data.Age.ToString();
            cbGender.Text = hod_data.Gender.ToString();
            foreach (BL.Department dept in DepartmentDL.dept_list)
            {
                if (dept.Id == hod_data.Department)
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
                int id = hod_data.Id;
                String name = nametxt.Text;
                String email = emailtxt.Text;
                String password = passwordtxt.Text;
                int age = Convert.ToInt32(agetxt.Text);
                String gender = cbGender.Text;
                int department;

                foreach (BL.Department dept in DepartmentDL.dept_list)
                {
                    if (dept.Name == cbdepartment.Text)
                    {
                        department = dept.Id;
                        BL.HOD hodUser = new BL.HOD(id, name, email, password, age, department, gender);
                        HOD_DL.UpdateHodinDB(hodUser);
                        break;
                    }
                }           
            }
            else
            {
                String name = nametxt.Text;
                String email = emailtxt.Text;
                String password = passwordtxt.Text;
                int age = Convert.ToInt32(agetxt.Text);
                String gender = cbGender.Text;
                int department;

                foreach (BL.Department dept in DepartmentDL.dept_list)
                {
                    if(dept.Name == cbdepartment.Text) 
                    {
                        department = dept.Id;
                        BL.HOD hodUser = new BL.HOD(name, email, password, age, department, gender);
                        HOD_DL.AddUserinDB(hodUser);
                        break;
                    }
                }

                
            }
            
        }
    }
}
