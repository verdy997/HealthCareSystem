using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.Model
{
    public class Examination
    {
        public int ID { get; set; }
        public Ambulance Ambulance { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public string Reason { get; set; }
        public string Includes { get; set; }
        public string Anamnesis { get; set; }
        public DateTime Date { get; set; }

        public Examination(int id, Ambulance ambulance, Doctor doctor, Patient patient, string reason, string includes, string anamnesis)
        {
            ID = id;
            Ambulance = ambulance;
            Doctor = doctor;
            Patient = patient;
            Reason = reason;
            Includes = includes;
            Anamnesis = anamnesis;
        }

        public Examination()
        {

        }
    }
}
