using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.Model
{
    public class Patient
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public long IdentificationNumber { get; set; }
        public string Gender { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public int Postcode { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
        public int CodeInsurance { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string Employer { get; set; }
        public string Allergies { get; set; }
        public DateTime? EndDate { get; set; }
        public Ambulance  Ambulance { get; set; }
        public List<Prescription> Prescriptions { get; set; }
        public List<Examination> Examinations { get; set; }
        public List<Vaccination> Vaccinations { get; set; }
        public List<WorkInability> WorkInabilities { get; set; }

        public Patient(string name, string surname, long identification, string gender, string street, string city, int postcode, 
            long phone, string email, int code, int height, int weight, string employer, string allergies, Ambulance ambulance)
        {
            Name = name;
            Surname = surname;
            IdentificationNumber = identification;
            Gender = gender;
            Street = street;
            City = city;
            Postcode = postcode;
            PhoneNumber = phone;
            Email = email;
            CodeInsurance = code;
            Height = height;
            Weight = weight;
            Employer = employer;
            Allergies = allergies;
            Ambulance = ambulance;
            Prescriptions = new List<Prescription>();
            Examinations = new List<Examination>();
            Vaccinations = new List<Vaccination>();
            WorkInabilities = new List<WorkInability>();
        }

        public Patient()
        {

        }

    }
}
