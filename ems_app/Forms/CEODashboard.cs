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
using ems_app.UC;

namespace ems_app.Forms
{
    public partial class CEODashboard : KryptonForm
    {
        private Form currentChildForm;
        private void openChildForm(Form childform)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childform;
            childform.TopLevel = false;
            childform.Dock = DockStyle.Fill;
            panelCont.Controls.Add(childform);
            panelCont.Tag = childform;
            childform.BringToFront();
            childform.Show();

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
            openChildForm(new Department());
        }

        private void HodClick(object sender, EventArgs e)
        {
            openChildForm(new HOD());
        }
    }
}
