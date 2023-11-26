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
    public class HOD_DL
    {
        private static List<HOD> Hod_list = new List<HOD>();
        internal static List<HOD> HOD_list { get => Hod_list; set => Hod_list = value; }

        public static void AddUserinDB(HOD data)
        {
            if (NewUserData(data.Email, data.Password))
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Insert into HOD values (@Name, @Email, @Password, @Age, @Gender, @Department,@Updated,@Created,@Status)", con);
                cmd.Parameters.AddWithValue("@Name", data.Name);
                cmd.Parameters.AddWithValue("@Email", data.Email);
                cmd.Parameters.AddWithValue("@Password", data.Password);
                cmd.Parameters.AddWithValue("@Age", data.Age);
                cmd.Parameters.AddWithValue("@Gender", data.Gender);
                cmd.Parameters.AddWithValue("@Department", data.Department);
                cmd.Parameters.AddWithValue("@Updated", DateTime.Now);
                cmd.Parameters.AddWithValue("@Created", DateTime.Now);
                cmd.Parameters.AddWithValue("@Status", "Active");
                cmd.ExecuteNonQuery();
                //LoadEmployeeFromDB();
                MessageBox.Show("Created account successfully");
            }
            else
            {
                MessageBox.Show("User Already Exists");
            }
        }
        public static bool NewUserData(string username, string password)
        {
            foreach (HOD data in HOD_list)
            {
                if (data.Name== username && data.Password== password)
                {
                    return false;
                }
            }
            return true;

        }
        public static void LoadUserFromDB()
        {
            HOD_list.Clear();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from HOD", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["id"]);
                int age = Convert.ToInt32(reader["age"]);
                string name = reader["name"] as string;
                string email = reader["email"] as string;
                string password = reader["password"] as string;
                string gender = reader["gender"] as string;
                string dept = reader["department"] as string;
                HOD data = new HOD(id,name,email,password,age,dept,gender);
                HOD_list.Add(data);
            }
        }
    }
}
