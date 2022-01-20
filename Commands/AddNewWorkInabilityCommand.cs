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
    public class AddNewWorkInabilityCommand : CommandBase
    {
        public Patient Patient { get; set; }
        public Ambulance Ambulance { get; set; }
        public Doctor Doctor { get; set; }
        public DbContextViewModel Context { get; set; }
        public WorkInabilitiesListView View { get; set; }
        public override void Execute(object? parameter)
        {
            WorkInabilityView wiv = new WorkInabilityView();
            if (Patient != null)
            {
                wiv.DataContext = new WorkInabilityViewModel(Patient, Doctor, Context, wiv);
            }
            wiv.Show();
            View.Close();
        }
    }
}
