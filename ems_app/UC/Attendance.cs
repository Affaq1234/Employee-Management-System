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
using ems_app.Helping;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ems_app.UC
{
    public partial class Attendance : KryptonForm
    {
        int indexRow, id;
        DateTime attendance_date;
        string att_date_string;
        bool flag = false;
        int att_id;
        public Attendance()
        {
            InitializeComponent();
            
            DepartmentDL.LoadDeptFromDB();
            foreach (BL.Department data in DepartmentDL.dept_list)
            {
                cbdepartment.Items.Add(data.Name);
            }
            cbdepartment.Text = DepartmentDL.dept_list.First().Name;

            try
            {
                foreach (BL.Department dept in DepartmentDL.dept_list)
                {
                    if (dept.Name == cbdepartment.Text)
                    {
                        var con = Configuration.getInstance().getConnection();
                        SqlCommand cmd = new SqlCommand("SELECT e.id,e.name as [Employee Name] FROM Employee e where department_id = @id AND status = 'Active'", con);
                        cmd.Parameters.AddWithValue("@id", dept.Id);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DGV1.DataSource = dt;
                    }
                }
            }
            catch (SqlException ex)
            {
                // Handle or log the exception
                LogTable.LogExceptionToDatabase(ex.Message, ex.StackTrace, "This exception is called in the initialization of attendance form");
                MessageBox.Show($"SQL Exception: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Handle or log other exceptions
                LogTable.LogExceptionToDatabase(ex.Message, ex.StackTrace, "This exception is called in the initialization of attendance form");
                MessageBox.Show($"Exception: {ex.Message}");
            }            
        }
        public int AddDateandGetId(DateTime date)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO Attendance (attendance_date) OUTPUT INSERTED.id VALUES (@AttDate)", con);
            cmd.Parameters.AddWithValue("@AttDate", att_date_string);
            int id = (int)cmd.ExecuteScalar();
            return id;
        }
        public bool IsMarked(string date)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT * from Attendance where attendance_date = @date", con);
            cmd.Parameters.AddWithValue("@date", date);
            object result = cmd.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                return true;
            }
            return false;
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
            att_date_string = parsedDate.ToString("yyyy-MM-dd");
            attendance_date= DateTime.ParseExact(att_date_string, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            if (IsMarked(att_date_string))
            {
                MessageBox.Show("Attendance is Already Marked on that day");
                flag = true;
            }
            flag = false;
        }
        
        private void DGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = 0;
                indexRow = e.RowIndex;
                DataGridViewRow row = DGV1.Rows[indexRow];
                id = int.Parse(row.Cells[2].Value.ToString());
                if (!IsAttendanceRegistered(attendance_date, id))
                {
                    if (flag == false)
                    {
                        att_id = AddDateandGetId(attendance_date);
                        flag = true;
                    }
                    

                    if (DGV1.Columns["Present"].Index == e.ColumnIndex)
                    {
                        {
                            row.Cells[0].Style.BackColor = System.Drawing.Color.Red;
                            var con = Configuration.getInstance().getConnection();
                            SqlCommand cmd = new SqlCommand("Insert into AttendanceDetails values (@EmpId,@AttId,@stat)", con);

                            cmd.Parameters.AddWithValue("@AttId", att_id);
                            cmd.Parameters.AddWithValue("@EmpId", id);
                            cmd.Parameters.AddWithValue("@stat", "Present");

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Successfully Marked");
                        }
                    }
                    else if (DGV1.Columns["Absent"].Index == e.ColumnIndex)
                    {
                        var con = Configuration.getInstance().getConnection();
                        SqlCommand cmd = new SqlCommand("Insert into AttendanceDetails values (@EmpId,@AttId,@stat)", con);

                        cmd.Parameters.AddWithValue("@AttId", att_id);
                        cmd.Parameters.AddWithValue("@EmpId", id);
                        cmd.Parameters.AddWithValue("@stat", "Absent");

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully Marked");
                    }
                }
                else
                {
                    flag = false;   
                }
                
            }
            catch (SqlException ex)
            {
                // Handle or log the exception
                LogTable.LogExceptionToDatabase(ex.Message, ex.StackTrace, "This is called in DGV1_CellContentClick Fuction");
                MessageBox.Show($"SQL Exception: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Handle or log other exceptions
                LogTable.LogExceptionToDatabase(ex.Message, ex.StackTrace, "This is called in DGV1_CellContentClick Fuction");
                MessageBox.Show($"Exception: {ex.Message}");
            }
        }

        private void cbdepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (BL.Department dept in DepartmentDL.dept_list)
            {
                if (dept.Name == cbdepartment.Text)
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("SELECT e.id,e.name as [Employee Name] FROM Employee e where department_id = @id ", con);
                    cmd.Parameters.AddWithValue("@id", dept.Id);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    DGV1.DataSource = dt;
                }
            }
        }

        static bool IsAttendanceRegistered(DateTime attendanceDate, int employeeId)
        {
            bool result = false;
            String ConnectionStr = @"Data Source=(local);Initial Catalog=EMS2;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(ConnectionStr))
            {
                connection.Open();

                // Check if there is an entry for the given date and employee ID in the Attendancedetail table
                string query = "SELECT 1 FROM AttendanceDetails WHERE attendance_id IN (SELECT id FROM Attendance WHERE attendance_date = @AttendanceDate) AND Employee_Id = @EmployeeID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AttendanceDate", attendanceDate);
                    command.Parameters.AddWithValue("@EmployeeID", employeeId);

                    // ExecuteScalar returns the first column of the first row, or null if no result is returned
                    object resultObject = command.ExecuteScalar();

                    if (resultObject != null && resultObject != DBNull.Value)
                    {
                        result = true; // Attendance is registered
                    }
                }
            }

            return result;
        }
    }
}
