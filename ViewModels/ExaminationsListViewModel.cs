using HealthCareSystem.Commands;
using HealthCareSystem.Model;
using HealthCareSystem.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HealthCareSystem.ViewModels
{
    public class ExaminationsListViewModel : ViewModelBase
    {
        private readonly ObservableCollection<Examination> _examinations;
        private readonly Patient _patient;
        public AddExaminationCommand AddExamination { get; }
        public AddExaminationCommand ShowExamination { get; }
        public ObservableCollection<Examination> Examinations => _examinations; //ak bude treba daj na obsColl...

        private Examination _examination;
        public Examination SelectedExamination
        {
            get { return _examination; }
            set
            {
                _examination = value;
                ShowExamination.Examination = _examination;
            }
        }

        public ExaminationsListViewModel(Patient patient, Ambulance ambulance, Doctor doctor, DbContextViewModel context, ExaminationsListView view)
        {
            _examinations = new ObservableCollection<Examination>();
            _patient = patient;
            AddExamination = new AddExaminationCommand();
            ShowExamination = new AddExaminationCommand();
            AddExamination.Patient = patient;
            ShowExamination.Patient = patient;
            AddExamination.Doctor = doctor;
            ShowExamination.Doctor = doctor;
            AddExamination.Ambulance = ambulance;
            ShowExamination.Ambulance = ambulance;
            AddExamination.Context = context;
            ShowExamination.Context = context;
            AddExamination.View = view;
            ShowExamination.View = view;
            AddExamination.IsNew = true;
            ShowExamination.IsNew = false;

            var ex = context.Context.Examinations.Where(x => x.Patient == patient).ToList();

            foreach (var item in ex)
            {
                _patient.Examinations.Add(item);
                _examinations.Add(item);
            }
        }
    }
}
