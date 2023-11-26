using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ems_app.Forms;
using ems_app;

namespace ems_app
{
    public class navigate
    {
        public static void ToHOD()
        {
            if (CEODashboard.Instance.pnlContainer.Controls.Contains(ucHOD.Instance))
            {
                ucHOD.Instance.BringToFront();
            }
            else
            {
                CEODashboard.Instance.pnlContainer.Controls.Add(ucHOD.Instance);
                ucHOD.Instance.Dock = DockStyle.Fill;
                ucHOD.Instance.BringToFront();
            }
        }
    }
}
