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
    public class PrescriptionViewModel : ViewModelBase
    {
        public Patient Patient { get; set; }
        public Prescription Prescription { get; set; }
        private string _doctorID;
        public string DoctorID
        {
            get
            {
                return _doctorID;
            }
            set
            {
                _doctorID = value;
                OnPropertyChanged(nameof(DoctorID));
            }
        }

        private string _insuranceID;
        public string InsuranceID
        {
            get
            {
                return _insuranceID;
            }
            set
            {
                _insuranceID = value;
                OnPropertyChanged(nameof(InsuranceID));
            }
        }

        private string _fullName;
        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                _fullName = value;
                OnPropertyChanged(nameof(FullName));
            }
        }

        private string _identificationNumber;
        public string IdentificationNumber
        {
            get
            {
                return _identificationNumber;
            }
            set
            {
                _identificationNumber = value;
                OnPropertyChanged(nameof(IdentificationNumber));
            }
        }

        private string _address;
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                OnPropertyChanged(nameof(Address));
            }
        }

        private DateTime _date;
        public DateTime Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
                OnPropertyChanged(nameof(Date));
            }
        }

        private string _recept;
        public string Recept
        {
            get
            {
                return _recept;
            }
            set
            {
                _recept = value;
                OnPropertyChanged(nameof(Recept));
            }
        }
        public SavePrescriptionCommand Save { get; }
        public CancelCommand Cancel { get; }

        public PrescriptionViewModel()
        {
            Save = new SavePrescriptionCommand();
            Cancel = new CancelCommand();
        }

        public PrescriptionViewModel(Patient patient, Doctor doctor, DbContextViewModel context, PrescriptionView view)
        {
            Patient = patient;
            FullName = $"{Patient.Surname} {Patient.Name}";
            IdentificationNumber = Patient.IdentificationNumber.ToString();
            InsuranceID = Patient.CodeInsurance.ToString();
            Address = $"{Patient.Street} {Patient.City}";
            Date = DateTime.Today;
            Save = new SavePrescriptionCommand();
            Save.Context = context;
            Save.View = view;
            Save.Model = this;
            Save.Patient = patient;
            Save.Doctor = doctor;
            Save.Date = Date;
            Save.IsNew = true;
            Cancel = new CancelCommand();
            Cancel.View = view;
        }

        public PrescriptionViewModel(Patient patient, Prescription prescription, PrescriptionView view, DbContextViewModel context)
        {
            Patient = patient;
            Prescription = prescription;
            FullName = $"{Patient.Surname} {Patient.Name}";
            IdentificationNumber = Patient.IdentificationNumber.ToString();
            InsuranceID = Patient.CodeInsurance.ToString();
            Address = $"{Patient.Street}, {Patient.City}";
            Date = prescription.Date.Date;
            Recept = $"{prescription.Drug}";
            DoctorID = prescription.Doctor.ID.ToString();

            Save = new SavePrescriptionCommand();
            Save.Context = context;
            Save.View = view;
            Save.Model = this;
            Save.Patient = patient;
            Save.Doctor = prescription.Doctor;
            Save.Date = Date;
            Save.IsNew = false;
            Save.Prescription = prescription;
            Cancel = new CancelCommand();
            Cancel.View = view;
        }
    }
}
