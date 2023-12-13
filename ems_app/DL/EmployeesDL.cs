using ems_app.BL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ems_app.DL
{
    public class EmployeesDL
    {
        private static List<Employees> emp_list = new List<Employees>();
        internal static List<Employees> Emp_list { get => emp_list; set => emp_list = value; }

        public static void DeleteEmpData(int id)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("UPDATE Employee SET status = 'Inactive' where id = @id", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete Operation Successfull");
        }
        public static void AddUserinDB(Employees data)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into Employee values (@Name, @Department_id, @Salary, @Attendance, @Rating, @Created,@Updated,@Status)", con);
            cmd.Parameters.AddWithValue("@Name", data.Name);
            cmd.Parameters.AddWithValue("@Department_id", data.Department_Id);
            cmd.Parameters.AddWithValue("@Salary", data.Salary);
            cmd.Parameters.AddWithValue("@Attendance", data.Attendance);
            cmd.Parameters.AddWithValue("@Rating", data.Rating);
            cmd.Parameters.AddWithValue("@Created", DateTime.Now);
            cmd.Parameters.AddWithValue("@Updated", DateTime.Now);
            cmd.Parameters.AddWithValue("@Status", "Active");
            cmd.ExecuteNonQuery();
            //LoadEmployeeFromDB();
            MessageBox.Show("Created account successfully");

        }
        public static void UpdateEmpinDB(Employees data)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("UPDATE Employee SET name = @name,department_id = @Department_id,salary = @Salary,attendance = @Attendance,rating = @Rating,updated_at = @updated WHERE id = @id", con);
            cmd.Parameters.AddWithValue("@id", data.Id);
            cmd.Parameters.AddWithValue("@name", data.Name);
            cmd.Parameters.AddWithValue("@Department_id", data.Department_Id);
            cmd.Parameters.AddWithValue("@Salary", data.Salary);
            cmd.Parameters.AddWithValue("@Attendance", data.Attendance);
            cmd.Parameters.AddWithValue("@Rating", data.Rating);
            cmd.Parameters.AddWithValue("@updated", DateTime.Now);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Updated");
        }
        public static void LoadUserFromDB()
        {
            Emp_list.Clear();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Employee where status = 'Active'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["id"]);
                string name = reader["name"] as string;
                int dept = Convert.ToInt32(reader["department_id"]);
                int salary = Convert.ToInt32(reader["salary"]);
                int attendance = Convert.ToInt32(reader["attendance"]);
                int rating = Convert.ToInt32(reader["rating"]);

                Employees data = new Employees(id, name, dept, salary, attendance, rating);
                Emp_list.Add(data);
            }
            reader.Close();
        }

    }
}
