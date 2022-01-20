using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.Model
{
    public class WorkInability
    {
        public int ID { get; set; }
        public Patient Patient { get; set; }
        public string Place { get; set; }
        public string Diagnosis { get; set; }
        public DateTime DateOfPublic { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public bool Ended { get; set; }

        public WorkInability(int id, Patient patient, string place, string diagnosis, DateTime dateOfPublic, DateTime from, DateTime to, bool ended)
        {
            ID = id;
            Patient = patient;
            Place = place;
            Diagnosis = diagnosis;
            DateOfPublic = dateOfPublic;
            From = from;
            To = to;
            Ended = ended;
        }

        public WorkInability()
        {

        }
    }
}
