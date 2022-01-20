using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.Model
{
    public class Ambulance
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Patient> Archive { get; set; }
        public List<Order> Orders { get; set; }
        public Doctor Doctor { get; set; }

        [NotMapped]
        public List<Patient> Patients { get; set; }
        


        public Ambulance(int id, string name, string address, Doctor doctor)
        {
            ID = id;
            Name = name;
            Address = address;
            Patients = new List<Patient>();
            Doctor = doctor;
            Orders = new List<Order>();
        }

        public Ambulance()
        {
        }


    }
}
