using HealthCareSystem.Commands;
using HealthCareSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace HealthCareSystem.ViewModels
{
    public class WorkInabilityViewModel : ViewModelBase
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

        private string _place;
        public string Place
        {
            get
            {
                return _place;
            }
            set
            {
                _place = value;
                OnPropertyChanged(nameof(Place));
            }
        }

        private string _diagnosis;
        public string Diagnosis
        {
            get
            {
                return _diagnosis;
            }
            set
            {
                _diagnosis = value;
                OnPropertyChanged(nameof(Diagnosis));
            }
        }

        private DateTime _actualDate;
        public DateTime ActualDate
        {
            get
            {
                return _actualDate;
            }
            set
            {
                _actualDate = value;
                OnPropertyChanged(nameof(ActualDate));
            }
        }

        private DateTime _startDate;
        public DateTime StartDate
        {
            get
            {
                return _startDate;
            }
            set
            {
                _startDate = value;
                OnPropertyChanged(nameof(StartDate));
            }
        }

        private DateTime _endDate;
        public DateTime EndDate
        {
            get
            {
                return _endDate;
            }
            set
            {
                _endDate = value;
                OnPropertyChanged(nameof(EndDate));
            }
        }

        public SaveWICommand Save { get; }
        public EndWICommand End { get; }

        public WorkInabilityViewModel()
        {
            Save = new SaveWICommand();
        }

        public WorkInabilityViewModel(Patient patient, Doctor doctor, DbContextViewModel context, WorkInabilityView view)
        {
            _name = patient.Name;
            _surname = patient.Surname;
            _address = $"{patient.Street}, {patient.City}";
            _place = $"{patient.Street}, {patient.City}";
            _employer = patient.Employer;
            _actualDate = DateTime.Today;
            _startDate = DateTime.Today;
            _endDate = DateTime.Today;
            Save = new SaveWICommand();
            Save.Patient = patient;
            Save.Doctor = doctor;
            Save.Context = context;
            Save.View = view;
            Save.Model = this;
            Save.IsNew = true;
            End = new EndWICommand();
            End.IsNew = true;

        }

        public WorkInabilityViewModel(Patient patient, WorkInability wi, DbContextViewModel context, Window view, bool isNew)
        {
            _name = patient.Name;
            _surname = patient.Surname;
            _address = $"{patient.Street}, {patient.City}";
            _place = $"{patient.Street}, {patient.City}";
            _employer = patient.Employer;
            _diagnosis = wi.Diagnosis;
            _actualDate = wi.DateOfPublic;
            _startDate = wi.From;
            _endDate = wi.To;
            Save = new SaveWICommand();
            Save.Patient = patient;
            Save.WorkInability = wi;
            Save.Context = context;
            Save.View = view;
            Save.Model = this;
            Save.IsNew = isNew;
            End = new EndWICommand();
            End.Patient = patient;
            End.WorkInability = wi;
            End.Context = context;
            End.View = view;
            End.Model = this;
            End.IsNew = isNew;
        }
    }
}
