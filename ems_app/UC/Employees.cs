using ems_app.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ems_app.UC
{
    public partial class Employees : Form
    {
        private DataTable dataTable = new DataTable();
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
            panelhod.Controls.Add(childform);
            panelhod.Tag = childform;
            childform.BringToFront();
            childform.Show();

        }
        public Employees()
        {
            InitializeComponent();
            ShowMain();
            if (DGV.Rows.Count > 0)
            {
                // Get the first row
                DataGridViewRow firstRow = DGV.Rows[0];

                if (firstRow.Cells[0].Value != null)
                {
                    openChildForm(new Emp_panel1(ReturnRowObject(firstRow)));
                }
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            openChildForm(new Emp_panel2());
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (DGV.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DGV.SelectedRows[0];

                openChildForm(new Emp_panel2(ReturnRowObject(selectedRow)));
            }
            else
            {
                DataGridViewRow firstRow = DGV.Rows[0];
                openChildForm(new Emp_panel2(ReturnRowObject(firstRow)));
            }
        }
        private BL.Employees ReturnRowObject(DataGridViewRow r)
        {
            int Id = int.Parse(r.Cells[0].Value.ToString());
            String Name = r.Cells[1].Value.ToString();
            String Department = r.Cells[2].Value.ToString();
            int Salary = int.Parse(r.Cells[3].Value.ToString());
            int Attendance = int.Parse(r.Cells[4].Value.ToString());
            int Rating = int.Parse(r.Cells[5].Value.ToString());


            foreach (BL.Department dept in DepartmentDL.dept_list)
            {
                if (dept.Name == Department)
                {
                    int dept_id = dept.Id;
                    BL.Employees emp = new BL.Employees(Id, Name, dept_id, Salary, Attendance, Rating);
                    //HOD_DL.AddUserinDB(hodUser);
                    return emp;
                }
            }
            return null;
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (DGV.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DGV.SelectedRows[0];

                DL.EmployeesDL.DeleteEmpData(int.Parse(selectedRow.Cells[0].Value.ToString()));
            }
            else
            {
                DataGridViewRow firstRow = DGV.Rows[0];
                DL.EmployeesDL.DeleteEmpData(int.Parse(firstRow.Cells[0].Value.ToString()));
            }
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            ShowMain();
            if (DGV.Rows.Count > 0)
            {
                // Get the first row
                DataGridViewRow firstRow = DGV.Rows[0];


                openChildForm(new Emp_panel1(ReturnRowObject(firstRow)));
            }
        }
        public void ShowMain()
        {
            dataTable.Clear();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT e.id, e.name, d.name as [Department Name], e.salary, e.attendance, e.rating,  FROM Employees e JOIN Departments d ON e.department_id = d.id AND h.status = 'Active'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Fill(dataTable);
            DGV.DataSource = dt;
        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            // Get the search text from the TextBox
            string searchText = searchtxt.Text.Trim();

            // Validate if the entered text contains only letters
            if (!string.IsNullOrEmpty(searchText) && searchText.All(char.IsLetter))
            {
                // Use linear search to find matching rows
                DataRow[] matchingRows = LinearSearch(dataTable, "name", searchText);

                // Create a new DataTable with the filtered rows
                DataTable filteredTable = matchingRows.Length > 0 ? matchingRows.CopyToDataTable() : dataTable.Clone();

                // Set the filtered DataTable as the DataSource for the DataGridView
                DGV.DataSource = filteredTable;
            }
            else
            {
                // Display a message or perform some action for invalid input
                MessageBox.Show("Please enter a valid string (letters only).");
            }
        }

        // Linear search implementation
        private DataRow[] LinearSearch(DataTable table, string columnName, string searchValue)
        {
            DataRow[] matchingRows = table.Select($"{columnName} LIKE '%{searchValue}%'");
            return matchingRows;
        }
        int indexRow;
        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                indexRow = e.RowIndex;
                DataGridViewRow row = DGV.Rows[indexRow];


                openChildForm(new Emp_panel1(ReturnRowObject(row)));
            }
            catch
            {
                MessageBox.Show("Invalid Click :)");
            }
        }
    }
}
