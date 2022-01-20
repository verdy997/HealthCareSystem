using HealthCareSystem.Commands;
using HealthCareSystem.Model;
using HealthCareSystem.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HealthCareSystem.ViewModels
{
    public class VaccinationViewModel : ViewModelBase
    {
        public SaveVaccinationCommand Save { get; }
        public Patient Patient { get; }

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

        private string _disease;

        public string Disease
        {
            get 
            {
                return _disease; 
            }
            set 
            { 
                _disease = value; 
                OnPropertyChanged(nameof(Date)); 
            }
        }


        public VaccinationViewModel(Patient patient, DbContextViewModel context, VaccinationView view)
        {
            Patient = patient;
            Date = DateTime.Now;
            Save = new SaveVaccinationCommand();
            Save.Patient = patient;
            Save.Context = context;
            Save.Date = Date;
            Save.Model = this;
            Save.View = view;

        }
    }
}
