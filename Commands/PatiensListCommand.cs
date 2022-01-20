using HealthCareSystem.Model;
using HealthCareSystem.ViewModels;
using HealthCareSystem.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.Commands
{
    public class PatiensListCommand : CommandBase
    {
        public Ambulance Ambulance { get; set; }
        public Doctor Doctor { get; set; }
        public DbContextViewModel Context { get; set; }
        public override void Execute(object? parameter)
        {
            PatientsListView plw = new PatientsListView();
            plw.DataContext = new PatientListViewModel(Ambulance, Doctor, Context, plw);
            plw.Show();
        }
    }
}
