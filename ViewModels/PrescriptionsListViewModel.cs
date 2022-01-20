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
    public class PrescriptionsListViewModel : ViewModelBase
    {
        private readonly ObservableCollection<Prescription> _prescriptions;
        private readonly Patient _patient;
        public AddPrescriptionCommand AddNewPrescription { get; }
        public ShowPrescriptionCommand ShowPrescription { get; }
        public ObservableCollection<Prescription> Prescriptions => _prescriptions; //ak bude treba daj na obsColl...

        private Prescription _prescription;
        public Prescription SelectedPrescription
        {
            get { return _prescription; }
            set
            {
                _prescription = value;
                ShowPrescription.Prescription = _prescription;
            }
        }

        public PrescriptionsListViewModel(Patient patient, Ambulance ambulance, Doctor doctor, DbContextViewModel context, PrescriptionsListView view)
        {
            _prescriptions = new ObservableCollection<Prescription>();
            _patient = patient;
            AddNewPrescription = new AddPrescriptionCommand();
            ShowPrescription = new ShowPrescriptionCommand();
            AddNewPrescription.Patient = patient;
            ShowPrescription.Patient = patient;
            AddNewPrescription.Ambulance = ambulance;
            ShowPrescription.Ambulance = ambulance;
            AddNewPrescription.Doctor = doctor;
            ShowPrescription.Doctor = doctor;
            AddNewPrescription.Context = context;
            ShowPrescription.Context = context;
            AddNewPrescription.View = view;
            ShowPrescription.View = view;


            var pres = context.Context.Prescriptions.Where(p => p.Patient == _patient).ToList();


            foreach (var item in pres)
            {
                _patient.Prescriptions.Add(item);
                _prescriptions.Add(item);
            }
        }
    }
}
