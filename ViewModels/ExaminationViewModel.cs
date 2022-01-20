using HealthCareSystem.Commands;
using HealthCareSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HealthCareSystem.ViewModels
{
    public class ExaminationViewModel : ViewModelBase
    {
        public Patient Patient { get; set; }
        public Examination Examination { get; set; }
        
        private string _ambulanceDoctor;
        public string AmbulanceDoctor
        {
            get 
            { 
                return _ambulanceDoctor; 
            }
            set 
            { 
                _ambulanceDoctor = value;
                OnPropertyChanged(nameof(AmbulanceDoctor));
            }
        }

        private string _ambulanceName;
        public string AmbulanceName
        {
            get
            {
                return _ambulanceName;
            }
            set
            {
                _ambulanceName = value;
                OnPropertyChanged(nameof(AmbulanceName));
            }
        }

        private string _ambulanceAddress;
        public string AmbulanceAddress
        {
            get
            {
                return _ambulanceAddress;
            }
            set
            {
                _ambulanceAddress = value;
                OnPropertyChanged(nameof(AmbulanceAddress));
            }
        }

        private string _patientFullName;
        public string PatientFullName
        {
            get
            {
                return _patientFullName;
            }
            set
            {
                _patientFullName = value;
                OnPropertyChanged(nameof(PatientFullName));
            }
        }

        private string _patientID;
        public string PatientID
        {
            get
            {
                return _patientID;
            }
            set
            {
                _patientID = value;
                OnPropertyChanged(nameof(PatientID));
            }
        }

        private string _patientInsurance;
        public string PatientInsurance
        {
            get
            {
                return _patientInsurance;
            }
            set
            {
                _patientInsurance = value;
                OnPropertyChanged(nameof(PatientInsurance));
            }
        }

        private DateTime _dateOfExamination;
        public DateTime DateOfExamination
        {
            get
            {
                return _dateOfExamination;
            }
            set
            {
                _dateOfExamination = value;
                OnPropertyChanged(nameof(DateOfExamination));
            }
        }

        private string _reason;
        public string Reason
        {
            get
            {
                return _reason;
            }
            set
            {
                _reason = value;
                OnPropertyChanged(nameof(Reason));
            }
        }

        private string _include;
        public string Include
        {
            get
            {
                return _include;
            }
            set
            {
                _include = value;
                OnPropertyChanged(nameof(Include));
            }
        }

        private string _anamnesis;
        public string Anamnesis
        {
            get
            {
                return _anamnesis;
            }
            set
            {
                _anamnesis = value;
                OnPropertyChanged(nameof(Anamnesis));
            }
        }

        public SaveExaminationCommand SaveExamination { get; }
        public ICommand AddPrescription { get; }
        public ICommand AddDiagnosis { get; }
        public ICommand AddWorkInability { get; }

        public ExaminationViewModel(Patient patient, Doctor doctor, Ambulance ambulance, DbContextViewModel context, ExaminationView view, bool isNew)
        {
            SaveExamination = new SaveExaminationCommand();
            SaveExamination.View = view;
            SaveExamination.Context = context;
            SaveExamination.Model = this;
            SaveExamination.Ambulance = ambulance;
            SaveExamination.Doctor = doctor;
            SaveExamination.Patient = patient;
            SaveExamination.IsNew = isNew;
            AddPrescription = new AddPrescriptionCommand();
            AddWorkInability = new AddWorkInabilityCommand();
            DateOfExamination = DateTime.Today;
            AmbulanceAddress = ambulance.Name;
            AmbulanceDoctor = $"Mudr. {doctor.Name} {doctor.Surname}";
            Patient = patient;
            PatientFullName = $"{Patient.Name} {Patient.Surname}";
            PatientID = Patient.IdentificationNumber.ToString();
            PatientInsurance = Patient.CodeInsurance.ToString();

        }

        public ExaminationViewModel(Patient patient, Examination examination, Doctor doctor, Ambulance ambulance, DbContextViewModel context, ExaminationView view, bool isNew)
        {
            SaveExamination = new SaveExaminationCommand();
            SaveExamination.View = view;
            SaveExamination.Context = context;
            SaveExamination.Model = this;
            SaveExamination.Ambulance = ambulance;
            SaveExamination.Doctor = doctor;
            SaveExamination.Patient = patient;
            SaveExamination.IsNew = isNew;
            AddPrescription = new AddPrescriptionCommand();
            AddWorkInability = new AddWorkInabilityCommand();
            Patient = patient;
            Examination = examination;
            DateOfExamination = examination.Date;
            AmbulanceAddress = ambulance.Name;
            AmbulanceDoctor = $"Mudr. {doctor.Name} {doctor.Surname}";
            PatientFullName = $"{Patient.Name} {Patient.Surname}";
            PatientID = Patient.IdentificationNumber.ToString();
            PatientInsurance = Patient.CodeInsurance.ToString();
            Reason = examination.Reason;
            Include = examination.Includes;
            Anamnesis = examination.Anamnesis;
        }
    }
}
