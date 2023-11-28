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

namespace ems_app.Forms
{
    public partial class HOD : Form
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
            panelhod.Controls.Add(childform);
            panelhod.Tag = childform;
            childform.BringToFront();
            childform.Show();

        }
        public HOD()
        {
            InitializeComponent();
            //openChildForm(new HOD_panel1());
            ShowMain();
            if (DGV.Rows.Count > 0)
            {
                // Get the first row
                DataGridViewRow firstRow = DGV.Rows[0];

                
                openChildForm(new HOD_panel1(ReturnRowObject(firstRow)));
            }
        }
        public void ShowMain()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select TOP 1000 id, name, email, password,age,gender,department from HOD", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGV.DataSource = dt;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            openChildForm(new HOD_panel2());
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if( DGV.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DGV.SelectedRows[0];
                
                openChildForm(new HOD_panel2(ReturnRowObject(selectedRow)));
            }
            else
            {
                DataGridViewRow firstRow = DGV.Rows[0];
                openChildForm(new HOD_panel2(ReturnRowObject(firstRow)));
            }
            
        }

        private BL.HOD ReturnRowObject(DataGridViewRow r)
        {
            int Id = int.Parse(r.Cells[0].Value.ToString());
            String Name = r.Cells[1].Value.ToString();
            String Email = r.Cells[2].Value.ToString();
            String Password = r.Cells[3].Value.ToString();
            int Age = int.Parse(r.Cells[4].Value.ToString());
            String Gender = r.Cells[5].Value.ToString();
            String Department = r.Cells[6].Value.ToString();
            BL.HOD hoddata = new BL.HOD(Id, Name, Email, Password, Age, Department, Gender);
            return hoddata;
        }
        private void refreshbtn_Click(object sender, EventArgs e)
        {
            //openChildForm(new HOD_panel1());
            ShowMain();
            if (DGV.Rows.Count > 0)
            {
                // Get the first row
                DataGridViewRow firstRow = DGV.Rows[0];


                openChildForm(new HOD_panel1(ReturnRowObject(firstRow)));
            }
        }
        int indexRow;
        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                indexRow = e.RowIndex;
                DataGridViewRow row = DGV.Rows[indexRow];
                

                openChildForm(new HOD_panel1(ReturnRowObject(row)));
            }
            catch
            {
                MessageBox.Show("Invalid Click :)");
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (DGV.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DGV.SelectedRows[0];

                DL.HOD_DL.DeleteHodData(int.Parse(selectedRow.Cells[0].Value.ToString()));
            }
            else
            {
                DataGridViewRow firstRow = DGV.Rows[0];
                DL.HOD_DL.DeleteHodData(int.Parse(firstRow.Cells[0].Value.ToString()));
            }
        }
    }
}
