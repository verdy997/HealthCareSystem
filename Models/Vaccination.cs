using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.Model
{
    public class Vaccination
    {
        public int ID { get; set; }
        public string TypeOfVaccination { get; set; }
        public Patient Patient { get; set; }
        public DateTime Date { get; set; }

        public Vaccination(string type, Patient patient, DateTime date)
        {
            TypeOfVaccination = type;
            Patient = patient;
            Date = date;
        }

        public Vaccination()
        {

        }
    }
}
