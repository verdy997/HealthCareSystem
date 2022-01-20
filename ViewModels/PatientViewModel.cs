using HealthCareSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.ViewModels
{
    public class PatientViewModel : ViewModelBase
    {
        private readonly Patient _patient;
        public string Name => _patient.Name;
        public string Surname => _patient.Surname;
        public long IdentificationNumber => _patient.IdentificationNumber;
        public string Street => _patient.Street;
        public string City => _patient.City;
        public int Postcode => _patient.Postcode;
        public string Email => _patient.Email;
        public IEnumerable<Examination> Examinations => _patient.Examinations;

        public PatientViewModel(Patient patient)
        {
            _patient = patient;
        }
    }
}
