using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ems_app.BL;

namespace ems_app.DL
{
    class DepartmentDL
    {
        private static List<Department> departmentList= new List<Department>();
        internal static List<Department> dept_list{ get => departmentList; set => departmentList  = value; }

        public static void AddDeptinDB(Department data)
        {
            if (NewData(data.Name))
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Insert into Departments values (@Name, @created, @update, @status)", con);
                cmd.Parameters.AddWithValue("@Name", data.Name);
                cmd.Parameters.AddWithValue("@created", DateTime.Now);
                cmd.Parameters.AddWithValue("@update", DateTime.Now);
                cmd.Parameters.AddWithValue("@status", "Active");
                cmd.ExecuteNonQuery();
                //LoadEmployeeFromDB();
                MessageBox.Show("Department Created successfully");
            }
            else
            {
                MessageBox.Show("Department Already Exists");
            }
        }
        public static void DeleteDeptData(int id)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("UPDATE Departments SET status = 'Inactive' where id = @id", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete Operation Successfull");
        }
        public static void UpdateDept(Department data)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("UPDATE Departments SET name = @name,updated_at = @updated WHERE id = @id", con);
            cmd.Parameters.AddWithValue("@id", data.Id);
            cmd.Parameters.AddWithValue("@name", data.Name);
            cmd.Parameters.AddWithValue("@updated", DateTime.Now);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Updated");
        }
        public static bool NewData(string name)
        {
            foreach (Department data in departmentList)
            {
                if (data.Name== name)
                {
                    return false;
                }
            }
            return true;

        }
        public static void LoadDeptFromDB()
        {
            departmentList.Clear();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Departments where status = 'Active' ", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["id"]);
                string name = reader["name"] as string;
                Department data = new Department(id, name);
                departmentList.Add(data);
            }
            reader.Close();
        }
    }
}
