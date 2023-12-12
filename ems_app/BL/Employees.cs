using ems_app.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ems_app.BL
{
    public class Employees
    {
        private int id;
        private string name;
        private int department_id;
        private int salary;
        private int attendance;
        private int rating;

        public Employees(string name, int department_id, int salary, int attendance, int rating)
        {
            this.name = name;
            this.department_id = department_id;
            this.salary = salary;
            this.attendance = attendance;
            this.rating = rating;
        }
        public Employees(int id, string name, int department_id, int salary, int attendance, int rating)
        {
            this.id = id;
            this.name = name;
            this.department_id = department_id;
            this.salary = salary;
            this.attendance = attendance;
            this.rating = rating;
        }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Department_Id { get => department_id; set => department_id = value; }
        public int Salary { get => salary; set => salary = value; }
        public int Attendance { get => attendance; set => attendance = value; }
        public int Rating { get => rating; set => rating = value; }
    }
}
