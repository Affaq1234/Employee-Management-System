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
    public partial class Dept_panel2 : Form
    {
        BL.Department dept_data;
        bool flag;
        public Dept_panel2()
        {
            InitializeComponent();
            
        }
        public Dept_panel2(BL.Department data)
        {
            InitializeComponent();
            this.dept_data = data;
            nametxt.Text = dept_data.Name;
            flag = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                int id = dept_data.Id;
                String name = nametxt.Text;
               
                BL.Department dept= new BL.Department(id, name);
                DepartmentDL.UpdateDept(dept);
                flag = false;
                //HOD.ShowMain();
            }
            else
            {
                String name = nametxt.Text;
                
                BL.Department dept= new BL.Department(name);
                DepartmentDL.AddDeptinDB(dept);
            }
            
        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
