using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ems_app.BL;
using ems_app.DL;

namespace ems_app.Forms
{
    public partial class SignUp : KryptonForm
    {
        public SignUp()
        {
            InitializeComponent();
            DepartmentDL.LoadDeptFromDB();
            foreach (BL.Department data in DepartmentDL.dept_list)
            {
                cbdepartment.Items.Add(data.Name);
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
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
                    BL.HOD hodUser = new BL.HOD(name, email, password, age, department, gender);
                    HOD_DL.AddUserinDB(hodUser);
                    break;
                }
            }
        }
    }
}
