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
    public class PatientCardViewModel : ViewModelBase
    {

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        private string _surname;
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
                OnPropertyChanged(nameof(Surname));
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

        private string _gender;
        public string Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
                OnPropertyChanged(nameof(Gender));
            }
        }

        private string _street;
        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                _street = value;
                OnPropertyChanged(nameof(Street));
            }
        }

        private string _city;
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
                OnPropertyChanged(nameof(City));
            }
        }

        private string _postCode;
        public string PostCode
        {
            get
            {
                return _postCode;
            }
            set
            {
                _postCode = value;
                OnPropertyChanged(nameof(PostCode));
            }
        }

        private string _phoneNumber;
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                _phoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        private string _email;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        private string _insurance;
        public string Insurance
        {
            get
            {
                return _insurance;
            }
            set
            {
                _insurance = value;
                OnPropertyChanged(nameof(Insurance));
            }
        }

        private string _height;
        public string Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
                OnPropertyChanged(nameof(Height));
            }
        }

        private string _weight;
        public string Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                _weight = value;
                OnPropertyChanged(nameof(Weight));
            }
        }

        private string _employer;
        public string Employer
        {
            get
            {
                return _employer;
            }
            set
            {
                _employer = value;
                OnPropertyChanged(nameof(Employer));
            }
        }

        private string _allergies;
        public string Allergies
        {
            get
            {
                return _allergies;
            }
            set
            {
                _allergies = value;
                OnPropertyChanged(nameof(Allergies));
            }
        }

        public ShowExaminationsCommand ShowExaminations { get; }
        public ICommand ShowOrder { get; }
        public ShowPrescriptionsCommand ShowPrescriptions { get; }
        public ShowVaccinationsCommand ShowVaccinations { get; }
        public ShowWorkInabilitiesCommand ShowWorkInabilities { get; }
        public DbContextViewModel Context { get; set; }
        public SavePatientCardCommand Save { get; }
        public ArchiveCommand Archive { get; }

        public PatientCardViewModel(DbContextViewModel context, PatientCardView pcw, Ambulance ambulance)
        {
            Context = context;
            Save = new SavePatientCardCommand();
            Save.Context = Context;
            Save.View = pcw;
            Save.Ambulance = ambulance;
            Save.Model = this;
        }

        public PatientCardViewModel()
        {
        }

        public PatientCardViewModel(DbContextViewModel context, PatientCardView pcw, Patient patient, Ambulance ambulance, Doctor doctor)
        {
            ShowExaminations = new ShowExaminationsCommand();
            ShowExaminations.Patient = patient;
            ShowExaminations.Ambulance = ambulance;
            ShowExaminations.Doctor = doctor;
            ShowExaminations.Context = context;
            ShowOrder = new ShowOrderCommand();
            ShowPrescriptions = new ShowPrescriptionsCommand();
            ShowPrescriptions.Patient = patient;
            ShowPrescriptions.Ambulance = ambulance;
            ShowPrescriptions.Doctor = doctor;
            ShowPrescriptions.Context = context;
            ShowVaccinations = new ShowVaccinationsCommand();
            ShowVaccinations.Patient = patient;
            ShowVaccinations.Context = context;
            ShowWorkInabilities = new ShowWorkInabilitiesCommand();
            ShowWorkInabilities.Patient = patient;
            ShowWorkInabilities.Ambulance = ambulance;
            ShowWorkInabilities.Doctor = doctor;
            ShowWorkInabilities.Context = context;
            Save = new SavePatientCardCommand();
            Save.Context = context;
            Save.View = pcw;
            Save.Ambulance = ambulance;
            Save.Model = this;
            Archive = new ArchiveCommand();
            Archive.Patient = patient;
            Archive.Context = context;
            Archive.View = pcw;
            _name = patient.Name;
            _surname = patient.Surname;
            _identificationNumber = patient.IdentificationNumber.ToString();
            _gender = patient.Gender;
            _street = patient.Street;
            _city = patient.City;
            _postCode = patient.Postcode.ToString();
            _phoneNumber = patient.PhoneNumber.ToString();
            _email = patient.Email;
            _insurance = patient.CodeInsurance.ToString();
            _height = patient.Height.ToString();
            _weight = patient.Weight.ToString(); ;
            _employer = patient.Employer;
            _allergies = patient.Allergies;
        }

        public PatientCardViewModel(DbContextViewModel context, PatientCardView pcw, Patient patient, Ambulance ambulance, Doctor doctor, bool archive)
        {
            ShowExaminations = new ShowExaminationsCommand();
            ShowExaminations.Patient = patient;
            ShowExaminations.Ambulance = ambulance;
            ShowExaminations.Doctor = doctor;
            ShowExaminations.Context = context;
            ShowOrder = new ShowOrderCommand();
            ShowPrescriptions = new ShowPrescriptionsCommand();
            ShowPrescriptions.Patient = patient;
            ShowPrescriptions.Ambulance = ambulance;
            ShowPrescriptions.Doctor = doctor;
            ShowPrescriptions.Context = context;
            ShowVaccinations = new ShowVaccinationsCommand();
            ShowVaccinations.Patient = patient;
            ShowVaccinations.Context = context;
            ShowWorkInabilities = new ShowWorkInabilitiesCommand();
            ShowWorkInabilities.Patient = patient;
            ShowWorkInabilities.Ambulance = ambulance;
            ShowWorkInabilities.Doctor = doctor;
            ShowWorkInabilities.Context = context;
            Archive = new ArchiveCommand();
            Archive.Patient = patient;
            Archive.Context = context;
            Archive.View = pcw;
            _name = patient.Name;
            _surname = patient.Surname;
            _identificationNumber = patient.IdentificationNumber.ToString();
            _gender = patient.Gender;
            _street = patient.Street;
            _city = patient.City;
            _postCode = patient.Postcode.ToString();
            _phoneNumber = patient.PhoneNumber.ToString();
            _email = patient.Email;
            _insurance = patient.CodeInsurance.ToString();
            _height = patient.Height.ToString();
            _weight = patient.Weight.ToString(); ;
            _employer = patient.Employer;
            _allergies = patient.Allergies;
        }

    }
}
