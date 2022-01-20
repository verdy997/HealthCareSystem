using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.Model
{
    public class Order
    {
        public int ID { get; set; }
        public Ambulance Ambulance { get; set; }
        public Patient Patient { get; set; }
        public DateTime Date { get; set; }

        //public Order(int id, Ambulance ambulance, Patient patient, DateTime date)
        //{
        //    ID = id;
        //    Ambulance = ambulance;
        //    Patient = patient;
        //    Date = date;
        //}
    }
}
