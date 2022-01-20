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
    public class ShowPrescriptionsCommand : CommandBase
    {
        public Patient Patient { get; set; }
        public Ambulance Ambulance { get; set; }
        public Doctor Doctor { get; set; }
        public DbContextViewModel Context { get; set; }
        public override void Execute(object? parameter)
        {
            PrescriptionsListView plw = new PrescriptionsListView();
            if (Patient != null)
            {
                plw.DataContext = new PrescriptionsListViewModel(Patient, Ambulance, Doctor, Context, plw);
            }
            plw.Show();
        }
    }
}
