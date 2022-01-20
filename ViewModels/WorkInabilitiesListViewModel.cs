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
    public class WorkInabilitiesListViewModel : ViewModelBase
    {
        private readonly ObservableCollection<WorkInability> _workInabilities;
        private readonly Patient _patient;
        public AddNewWorkInabilityCommand AddNewWI { get; }
        public ShowWorkInabilityCommand ShowWI { get; }
        public ObservableCollection<WorkInability> WorkInabilities => _workInabilities; //ak bude treba daj na obsColl...

        private WorkInability _workInability;
        public WorkInability SelectedWI
        {
            get { return _workInability; }
            set
            {
                _workInability = value;
                ShowWI.WorkInability = SelectedWI;
            }
        }

        public WorkInabilitiesListViewModel(Patient patient, Ambulance ambulance, Doctor doctor, DbContextViewModel context, WorkInabilitiesListView view)
        {
            _workInabilities = new ObservableCollection<WorkInability>();
            _patient = patient;
            AddNewWI = new AddNewWorkInabilityCommand();
            ShowWI = new ShowWorkInabilityCommand();
            AddNewWI.Patient = patient;
            ShowWI.Patient = patient;
            AddNewWI.Ambulance = ambulance;
            ShowWI.Ambulance = ambulance;
            AddNewWI.Doctor = doctor;
            ShowWI.Doctor = doctor;
            AddNewWI.Context = context;
            ShowWI.Context = context;
            AddNewWI.View = view;
            ShowWI.View = view;

            var wis = context.Context.WorkInabilities.Where(p => p.Patient == _patient).ToList();

            foreach (var item in wis)
            {
                _patient.WorkInabilities.Add(item);
                _workInabilities.Add(item);
            }
        }
    }
}
