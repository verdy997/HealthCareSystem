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
    public class SaveVaccinationCommand : CommandBase
    {
        public Patient Patient { get; set; }
        public DateTime Date { get; set; }
        public DbContextViewModel Context { get; set; }
        public VaccinationViewModel Model { get; set; }
        public VaccinationView View { get; set; }

        public override void Execute(object? parameter)
        {
            if (Date > DateTime.Now || Model.Disease == null || Patient == null)
            {
                var result = MessageBox.Show("Chyba! Niektoré údaje neboli vyplnené alebo boli vyplnené zle!", "Configuration", MessageBoxButton.OK, MessageBoxImage.Error);
            } 
            else
            {
                Vaccination vac = new Vaccination(Model.Disease, Patient, Date);
                Context.AddNewVaccination(vac);
            }
            View.Close();
        }
    }
}
