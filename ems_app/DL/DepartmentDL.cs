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
                SqlCommand cmd = new SqlCommand("Insert into Department values (@Name, @created, @update, @status)", con);
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
                MessageBox.Show("User Already Exists");
            }
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
        public static void LoadUserFromDB()
        {
            departmentList.Clear();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Department", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["id"]);
                string name = reader["name"] as string;
                Department data = new Department(id, name);
                departmentList.Add(data);
            }
        }
    }
}
