using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.Model
{
    public class Prescription
    {
        public int ID { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public DateTime Date { get; set; }
        public string Drug { get; set; }

        public Prescription(int id, Doctor doctor, Patient patient, DateTime date, string drug)
        {
            ID = id;
            Doctor = doctor;
            Patient = patient;
            Date = date;
            Drug = drug;
        }

        public Prescription()
        {

        }

    }
}
