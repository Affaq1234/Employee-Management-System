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
    public partial class Dept_panel1 : Form
    {
        BL.Department deptData;
        
        public Dept_panel1(BL.Department data, int qty)
        {
            InitializeComponent();
            this.deptData = data;
            idlbl.Text = deptData.Id.ToString();
            namelbl.Text = deptData.Name;
            deptqtylbl.Text = qty.ToString();
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
    }
}
