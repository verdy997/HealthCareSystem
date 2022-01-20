using HealthCareSystem.Model;
using HealthCareSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HealthCareSystem.Commands
{
    public class SavePatientCardCommand : CommandBase
    {
        public DbContextViewModel Context { get; set; }
        public PatientCardViewModel Model { get; set; }
        public PatientCardView View { get; set; }
        public Ambulance Ambulance  { get; set; }
        public override void Execute(object? parameter)
        {
            
            if (long.TryParse(Model.IdentificationNumber, out long res) && int.TryParse(Model.Height, out int res2) &&
                int.TryParse(Model.Weight, out int res3) && int.TryParse(Model.PostCode, out int res4)
                && long.TryParse(Model.PhoneNumber, out long res5) && int.TryParse(Model.Insurance, out int res6))
            {
                if (Model.Name != null && Model.Surname != null && Model.Gender != null && Model.Street != null &&  
                   Model.City != null && Model.Email != null && Model.Employer != null && 
                   Model.Allergies != null && Ambulance != null)
                {
                    var patient = new Patient(Model.Name, Model.Surname, long.Parse(Model.IdentificationNumber), Model.Gender, Model.Street,
                        Model.City, int.Parse(Model.PostCode), long.Parse(Model.PhoneNumber), Model.Email, int.Parse(Model.Insurance),
                        int.Parse(Model.Height), int.Parse(Model.Weight), Model.Employer, Model.Allergies, Ambulance);
                    Context.AddNewPatient(patient);
                } else
                {
                    var result = MessageBox.Show("Chyba! Niektoré údaje neboli vyplnené!", "Configuration", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            } else
            {
                var result = MessageBox.Show("Chyba! Niektoré údaje neboli vyplnené!", "Configuration", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            View.Close();
        }
    }
}
