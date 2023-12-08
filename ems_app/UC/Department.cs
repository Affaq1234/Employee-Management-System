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
using ems_app.UC;
using ems_app.BL;
using ems_app.DL;

namespace ems_app.Forms
{
    public partial class Department : Form
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
            paneldept.Controls.Add(childform);
            paneldept.Tag = childform;
            childform.BringToFront();
            childform.Show();

        }
        public Department()
        {
            InitializeComponent();
            //openChildForm(new HOD_panel1());
            ShowMain();
            if (DGV1.Rows.Count > 0)
            {
                // Get the first row
                DataGridViewRow firstRow = DGV1.Rows[0];

                if (firstRow.Cells[0].Value != null)
                {
                    openChildForm(new Dept_panel1(ReturnRowObject(firstRow), DGV1.RowCount - 1));
                }
                
            }
        }
        public void ShowMain()
        {
            dataTable.Clear();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select TOP 1000 id, name, created_at, updated_at from Departments", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Fill(dataTable);
            DGV1.DataSource = dt;
            DepartmentDL.LoadDeptFromDB();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Dept_panel2());
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if( DGV1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DGV1.SelectedRows[0];
                
                openChildForm(new Dept_panel2(ReturnRowObject(selectedRow)));
            }
            else
            {
                DataGridViewRow firstRow = DGV1.Rows[0];
                openChildForm(new Dept_panel2(ReturnRowObject(firstRow)));
            }
            
        }

        private BL.Department ReturnRowObject(DataGridViewRow r)
        {
            int Id = int.Parse(r.Cells[0].Value.ToString());
            String Name = r.Cells[1].Value.ToString();
            
            
            BL.Department dept_data = new BL.Department(Id, Name);
            return dept_data;
        }
        private void refreshbtn_Click(object sender, EventArgs e)
        {
            //openChildForm(new HOD_panel1());
            ShowMain();
            if (DGV1.Rows.Count > 0)
            {
                // Get the first row
                DataGridViewRow firstRow = DGV1.Rows[0];


                openChildForm(new Dept_panel1(ReturnRowObject(firstRow), DGV1.RowCount-1));
            }
        }
        int indexRow;
        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                indexRow = e.RowIndex;
                DataGridViewRow row = DGV1.Rows[indexRow];
                

                openChildForm(new Dept_panel1(ReturnRowObject(row), DGV1.RowCount-1));
            }
            catch
            {
                MessageBox.Show("Invalid Click :)");
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (DGV1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DGV1.SelectedRows[0];

                DL.DepartmentDL.DeleteDeptData(int.Parse(selectedRow.Cells[0].Value.ToString()));
            }
            else
            {
                DataGridViewRow firstRow = DGV1.Rows[0];
                DL.DepartmentDL.DeleteDeptData(int.Parse(firstRow.Cells[0].Value.ToString()));
            }
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
                DGV1.DataSource = filteredTable;
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
    }
}
