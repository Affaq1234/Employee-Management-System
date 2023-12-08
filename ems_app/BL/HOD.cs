using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ems_app.BL
{
    public class HOD
    {
        private int id;
        private string name;
        private string email;
        private string password;
        private int age;
        private int department;
        private string gender;
        public HOD(string name, string email, string password, int age, int department, string gender)
        {
            this.name = name;
            this.email = email;
            this.password = password;
            this.age = age;
            this.department = department;
            this.gender = gender;
        }
        public HOD(int id, string name, string email, string password, int age, int department,string gender)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
            this.age = age;
            this.department = department;
            this.gender = gender;
        }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public int Age { get => age; set => age = value; }  
        public int Department { get => department; set => department = value; }
        public string Gender { get => gender; set => gender = value; }
        
    }
}
