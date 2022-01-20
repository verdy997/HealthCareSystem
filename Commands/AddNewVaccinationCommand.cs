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
    public class AddNewVaccinationCommand : CommandBase
    {
        public Patient Patient { get; set; }
        public DbContextViewModel Context { get; set; }
        public VaccinationsListView View { get; set; }
        public override void Execute(object? parameter)
        {
            if (Patient.EndDate == null)
            {
                VaccinationView vw = new VaccinationView();
                if (Patient != null)
                {
                    vw.DataContext = new VaccinationViewModel(Patient, Context, vw);
                    vw.Show();
                }
                vw.Show();
            } else
            {
                MessageBox.Show("Pacient je v Archíve!", "Save error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            View.Close();
        }
    }
}
