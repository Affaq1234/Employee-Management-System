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
    public partial class ucHOD : UserControl
    {
        private static ucHOD _instance;
        public static ucHOD Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucHOD();
                }
                return _instance;
            }
        }
        public ucHOD() {
            InitializeComponent();
            
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {

        }
    }
}
