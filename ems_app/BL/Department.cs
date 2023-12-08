using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ems_app.BL
{
    public class Department
    {
        private int id;
        private string name;

        public Department(string name) {
            this.name = name;
        }
        public Department(int id, string name)
        {
            Name = name;
            Id = id;
        }

        public String Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
    }
    
}
