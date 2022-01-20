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
    public class ShowPrescriptionCommand : CommandBase
    {
        public Prescription Prescription { get; set; }
        public Patient Patient { get; set; }
        public Ambulance Ambulance { get; set; }
        public Doctor Doctor { get; set; }
        public DbContextViewModel Context { get; set; }
        public PrescriptionsListView View { get; set; }
        public override void Execute(object? parameter)
        {
            PrescriptionView plw = new PrescriptionView();
            if (Prescription != null)
            {
                plw.DataContext = new PrescriptionViewModel(Patient, Prescription, plw, Context);
            }
            else
            {
                plw.DataContext = new PrescriptionViewModel();
            }
            plw.Show();
            View.Close();
        }
    }
}
