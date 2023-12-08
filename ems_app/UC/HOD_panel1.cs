using ems_app.BL;
using ems_app.DL;
using ems_app.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ems_app.UC
{
    public partial class HOD_panel1 : Form
    {
        BL.HOD hoddata;
        public HOD_panel1(BL.HOD data)
        {
            InitializeComponent();
            this.hoddata = data;
            namelbl.Text = hoddata.Name;
            genderlbl.Text = hoddata.Gender;
            foreach(BL.Department dept in DepartmentDL.dept_list)
            {
                if (dept.Id == hoddata.Department) 
                {
                    deptlbl.Text = dept.Name;
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HOD_panel1_Load(object sender, EventArgs e)
        {

        }

        private void namelbl_Click(object sender, EventArgs e)
        {

        }
    }
}
