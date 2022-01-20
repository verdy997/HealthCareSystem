using HealthCareSystem.Model;
using HealthCareSystem.ViewModels;
using HealthCareSystem.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HealthCareSystem.Commands
{
    public class ShowPatientCardCommand : CommandBase
    {
        public Patient Patient { get; set; }
        public Ambulance Ambulance { get; set; }
        public Doctor Doctor { get; set; }
        public DbContextViewModel Context { get; set; }
        public Window View { get; set; }


        public override void Execute(object? parameter)
        {
            View.Close();
            PatientCardView plw = new PatientCardView();
            if (Patient != null && Patient.EndDate == null)
            {
                plw.DataContext = new PatientCardViewModel(Context, plw, Patient, Ambulance, Doctor);
            }
            else if (Patient.EndDate != null)
            {
                bool archive = true;
                plw.DataContext = new PatientCardViewModel(Context, plw, Patient, Ambulance, Doctor, archive);
            }
            else
            {
                plw.DataContext = new PatientCardViewModel();
            }
            plw.Show();
        }
    }
}
