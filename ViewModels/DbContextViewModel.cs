using HealthCareSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HealthCareSystem.ViewModels
{
    public class DbContextViewModel : ViewModelBase
    {
        private readonly HCDB context;

        public HCDB Context { get { return context; } }

        public DbContextViewModel()
        {
            context = new HCDB();
        }

        public void AddNewPatient(Patient patient)
        {
            if (context.Patients.Where(x => x.IdentificationNumber == patient.IdentificationNumber).Any())
            {
                var patient2 = context.Patients.Where(x => x.IdentificationNumber == patient.IdentificationNumber).Single();
                patient2.Name = patient.Name;
                patient2.Surname = patient.Surname;
                patient2.IdentificationNumber = patient.IdentificationNumber;
                patient2.Street = patient.Street;
                patient2.City = patient.City;
                patient2.PhoneNumber = patient.PhoneNumber;
                patient2.Postcode = patient.Postcode;
                patient2.Height = patient.Height;
                patient2.Weight = patient.Weight;
                patient2.Allergies = patient.Allergies;
                patient2.Gender = patient.Gender;
                patient2.Email = patient.Email;
                patient2.Employer = patient.Employer;
                patient2.EndDate = patient.EndDate;
                patient2.Ambulance = patient.Ambulance;
                patient2.CodeInsurance = patient.CodeInsurance;
                UpdatePatient(patient2);
            } 
            else
            {
                context.Patients.Add(patient);
                var result = MessageBox.Show("Pacient bol pridaný", "Configuration", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            context.SaveChanges();
        }

        public void UpdatePatient(Patient patient)
        {
            context.Patients.Update(patient);
            var result = MessageBox.Show("Pacientová karta bola aktualizovaná", "Configuration", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public void AddNewDoctor(Doctor doctor)
        {
            var d = doctor;

            context.Doctors.Add(d);
            context.SaveChanges();
        }
        public void AddNewAmbulance(Ambulance ambulance)
        {
            var a = new Ambulance
            {
                ID = ambulance.ID,
                Name = ambulance.Name,
                Address = ambulance.Address,
                Doctor = ambulance.Doctor
            };

            context.Ambulances.Add(a);
            context.SaveChanges();
        }

        public void AddNewExamination(Examination examination)
        {
            examination.Date = DateTime.Now;
            context.Examinations.Add(examination);
            context.SaveChanges();
            var result = MessageBox.Show("Vyšetrenie bolo pridané", "Configuration", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public void AddNewPrescription(Prescription prescription)
        {
            context.Prescriptions.Add(prescription);
            context.SaveChanges();
            var result = MessageBox.Show("Predpis bol pridanú", "Configuration", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public void UpdatePrescription(Prescription prescription)
        {
            context.Prescriptions.Update(prescription);
            context.SaveChanges();
            var result = MessageBox.Show("Predpis bol upravený", "Configuration", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public void AddNewVaccination(Vaccination vaccination)
        {
            context.Vaccinations.Add(vaccination);
            context.SaveChanges();
            var result = MessageBox.Show("Očkovanie bolo pridané", "Configuration", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public void AddNewWorkInability(WorkInability workInability)
        {
            context.WorkInabilities.Add(workInability);
            context.SaveChanges();
            var result = MessageBox.Show("PN bola pridaná", "Configuration", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public void UpdateWorkInability(WorkInability workInability)
        {
            context.WorkInabilities.Update(workInability);
            context.SaveChanges();
            var result = MessageBox.Show("PN bola aktualizovaná", "Configuration", MessageBoxButton.OK, MessageBoxImage.Information);
        }

    }
}
