using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.Model
{
    public class Doctor
    {
        public int ID { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public  string Surname { get; set; }

        public Doctor(int id, string password, string name, string surname)
        {
            ID = id;
            Password = password;
            Name = name;
            Surname = surname;
        }

        public Doctor()
        {

        }
    }
}
