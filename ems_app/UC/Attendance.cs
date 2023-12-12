using ComponentFactory.Krypton.Toolkit;
using ems_app.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ems_app.UC
{
    public partial class Attendance : KryptonForm
    {
        public Attendance()
        {
            InitializeComponent();
            
            DepartmentDL.LoadDeptFromDB();
            foreach (BL.Department data in DepartmentDL.dept_list)
            {
                cbdepartment.Items.Add(data.Name);
            }
            cbdepartment.Text = DepartmentDL.dept_list.First().Name;


            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT e.name as [Employee Name] FROM Employees e where department_id = @id ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGV1.DataSource = dt;
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            
        }

        private void kryptonDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionStart;
            DateTime parsedDate = DateTime.ParseExact(selectedDate.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            datetxt.Text = parsedDate.ToString("yyyy-MM-dd");
        }
        int indexRow, id;
        private void DGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = 0;
                indexRow = e.RowIndex;
                DataGridViewRow row = DGV1.Rows[indexRow];
                id = int.Parse(row.Cells[4].Value.ToString());

                if (DGV.Columns["Present"].Index == e.ColumnIndex)
                {
                    row.Cells[0].Style.BackColor = System.Drawing.Color.Red;
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("Insert into StudentAttendance values (@AttId,@StudId,@stat)", con);

                    cmd.Parameters.AddWithValue("@AttId", idx);
                    cmd.Parameters.AddWithValue("@StudId", id);
                    cmd.Parameters.AddWithValue("@stat", 1);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Marked");
                }
                else if (DGV.Columns["Absent"].Index == e.ColumnIndex)
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("Insert into StudentAttendance values (@AttId,@StudId,@stat)", con);

                    cmd.Parameters.AddWithValue("@AttId", idx);
                    cmd.Parameters.AddWithValue("@StudId", id);
                    cmd.Parameters.AddWithValue("@stat", 2);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Marked");
                }
                else if (DGV.Columns["Leave"].Index == e.ColumnIndex)
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("Insert into StudentAttendance values (@AttId,@StudId,@stat)", con);

                    cmd.Parameters.AddWithValue("@AttId", idx);
                    cmd.Parameters.AddWithValue("@StudId", id);
                    cmd.Parameters.AddWithValue("@stat", 3);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Marked");
                }
                else if (DGV.Columns["Late"].Index == e.ColumnIndex)
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("Insert into StudentAttendance values (@AttId,@StudId,@stat)", con);

                    cmd.Parameters.AddWithValue("@AttId", idx);
                    cmd.Parameters.AddWithValue("@StudId", id);
                    cmd.Parameters.AddWithValue("@stat", 4);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Marked");
                }
            }
            catch
            {
                MessageBox.Show("Attendance is already marked for This Student");
            }
        }
    }
}
