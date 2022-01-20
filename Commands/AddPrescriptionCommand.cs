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
    public class AddPrescriptionCommand : CommandBase
    {
        public Patient Patient { get; set; }
        public Ambulance Ambulance { get; set; }
        public Doctor Doctor { get; set; }
        public DbContextViewModel Context { get; set; }
        public PrescriptionsListView View { get; set; }
        public override void Execute(object? parameter)
        {
            if (Patient.EndDate == null)
            {
                PrescriptionView pw = new PrescriptionView();
                if (Patient != null)
                {
                    pw.DataContext = new PrescriptionViewModel(Patient, Doctor, Context, pw);
                }
                else
                {
                    pw.DataContext = new PrescriptionViewModel();
                }
                pw.Show();
            }
            else
            {
                var result = MessageBox.Show("Pacient je v Archíve!", "Configuration", MessageBoxButton.OK, MessageBoxImage.Stop);
            }
            
            View.Close();

        }
    }
}
