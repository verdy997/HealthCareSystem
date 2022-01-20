using HealthCareSystem.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HealthCareSystem.ViewModels
{
    public class AddOrderViewModel : ViewModelBase
    {
        public ICommand Save { get; }

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

        public AddOrderViewModel()
        {
            
        }
    }
}
