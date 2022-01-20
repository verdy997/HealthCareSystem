using HealthCareSystem.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HealthCareSystem.ViewModels
{
    public class WaitingRoomViewModel : ViewModelBase
    {
        private readonly ObservableCollection<Patient> _patients;
        public ICommand AddNewOrder { get; }
        public ICommand ShowPatientCard { get; }
        public ObservableCollection<Patient> Patients => _patients; //ak bude treba daj na obsColl...

        public WaitingRoomViewModel()
        {
            _patients = new ObservableCollection<Patient>();
            
        }
    }
}
