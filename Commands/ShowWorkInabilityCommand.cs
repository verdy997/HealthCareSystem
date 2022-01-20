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
    public class ShowWorkInabilityCommand : CommandBase
    {
        public Patient Patient { get; set; }
        public Ambulance Ambulance { get; set; }
        public Doctor Doctor { get; set; }
        public DbContextViewModel Context { get; set; }
        public WorkInabilitiesListView View { get; set; }
        public WorkInability WorkInability { get; set; }
        public override void Execute(object? parameter)
        {
            if (Patient != null && WorkInability != null)
            {
                bool isNew = false;
                if (!WorkInability.Ended)
                {
                    WorkInabilityView plw = new WorkInabilityView();
                    plw.DataContext = new WorkInabilityViewModel(Patient, WorkInability, Context, plw, isNew);
                    plw.Show();
                }
                else
                {
                    WorkInabilityFinalView plw = new WorkInabilityFinalView();
                    plw.DataContext = new WorkInabilityViewModel(Patient, WorkInability, Context, plw, isNew);
                    plw.Show();
                }
            }
            View.Close();
        }
    }
}
