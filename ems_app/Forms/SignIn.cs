using ComponentFactory.Krypton.Toolkit;
using ems_app.BL;
using ems_app.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ems_app.Forms
{
    public partial class SignIn : KryptonForm
    {

        public SignIn()
        {
            
            InitializeComponent();
            
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                HOD_DL.LoadUserFromDB();
                DepartmentDL.LoadDeptFromDB();
                if (emailtxt.Text == "CEO" && passtxt.Text == "CEO")
                {
                    this.Hide();
                    Form form = new CEODashboard();
                    form.ShowDialog();
                }

                foreach (BL.HOD data in HOD_DL.HOD_list)
                {
                    if (data.Email == emailtxt.Text && data.Password == passtxt.Text)
                    {
                        //this.Hide();
                        //Form form = new SignUp();
                        //form.ShowDialog();
                        MessageBox.Show("Logged in Successfully");
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            
            Form form = new SignUp();
            form.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
