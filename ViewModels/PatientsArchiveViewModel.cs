using HealthCareSystem.Commands;
using HealthCareSystem.Model;
using HealthCareSystem.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.ViewModels
{
    public class PatientsArchiveViewModel
    {
        private readonly ObservableCollection<Patient> _patients;
        public ShowPatientCardCommand ShowPatientCard { get; set; }
        public ObservableCollection<Patient> Patients => _patients; //ak bude treba daj na obsColl...
        public DbContextViewModel Context { get; set; }

        private Patient _patient;
        public Patient SelectedPatient
        {
            get { return _patient; }
            set
            {
                _patient = value;
                ShowPatientCard.Patient = _patient;
            }
        }

        public PatientsArchiveViewModel(Ambulance ambulance, Doctor doctor, DbContextViewModel context, PatientsArchiveView view)
        {
            Context = context;
            _patients = new ObservableCollection<Patient>();
            var ptns = Context.Context.Patients.Where(p => p.Ambulance == ambulance).ToList();
            var archives = ptns.Where(x => x.EndDate != null).ToList();
            foreach (var item in archives)
            {
                _patients.Add(item);
            }

            ShowPatientCard = new ShowPatientCardCommand();
            ShowPatientCard.Ambulance = ambulance;
            ShowPatientCard.Doctor = doctor;
            ShowPatientCard.Context = Context;
            ShowPatientCard.View = view;
        }
    }
}
