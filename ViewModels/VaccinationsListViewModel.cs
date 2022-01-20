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
    public class VaccinationsListViewModel : ViewModelBase
    {
        private readonly ObservableCollection<Vaccination> _vaccinations;
        private readonly Patient _patient;
        public AddNewVaccinationCommand AddNewVaccination { get; }
        public ObservableCollection<Vaccination> Vaccinations => _vaccinations; //ak bude treba daj na obsColl...

        public VaccinationsListViewModel(Patient patient, DbContextViewModel context, VaccinationsListView view)
        {
            _vaccinations = new ObservableCollection<Vaccination>();
            _patient = patient;
            AddNewVaccination = new AddNewVaccinationCommand();
            AddNewVaccination.Patient = patient;
            AddNewVaccination.Context = context;
            AddNewVaccination.View = view;

            var vacs = context.Context.Vaccinations.Where(v => v.Patient == patient);

            foreach (var item in vacs)
            {
                _patient.Vaccinations.Add(item);
                _vaccinations.Add(item);
            }
        }
    }
}
