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
    public class AddNewPatientCommand : CommandBase
    {
        public Ambulance Ambulance { get; set; }
        public DbContextViewModel Context { get; set; }
        public PatientsListView View { get; set; }
        public override void Execute(object? parameter)
        {
            View.Close();
            PatientCardView plw = new PatientCardView();
            plw.DataContext = new PatientCardViewModel(Context, plw, Ambulance);
            plw.Show();
        }
    }
}
