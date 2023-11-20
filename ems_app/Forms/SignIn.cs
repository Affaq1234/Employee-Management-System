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
            this.Hide();
            Form form = new SignUp();
            form.ShowDialog();
        }
    }
}
