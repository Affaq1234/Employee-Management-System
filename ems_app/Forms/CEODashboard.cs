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
    public partial class CEODashboard : KryptonForm
    {
        private static CEODashboard _instance;
        public static CEODashboard Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CEODashboard();
                }
                return _instance;
            }
        }
        public CEODashboard()
        {
            InitializeComponent();
        }

        private void CEODashboard_Load(object sender, EventArgs e)
        {

        }

        private void addBudgetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void departmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            navigate.ToHOD();

        }
    }
}
