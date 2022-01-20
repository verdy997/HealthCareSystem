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
    public class ArchiveCommand : CommandBase
    {
        public Patient Patient { get; set; }
        public DbContextViewModel Context { get; set; }
        public Window View { get; set; }
        public override void Execute(object? parameter)
        {
            if (MessageBox.Show("Pozor! Naozaj chcete pacienta archívovať?",
                    "Archívovať",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var patient = Context.Context.Patients.Where(p => p.IdentificationNumber == Patient.IdentificationNumber).Single();
                if (patient.EndDate != null)
                {
                    MessageBox.Show("Pacient už je archívovaný!", "Archive error", MessageBoxButton.OK, MessageBoxImage.Error);
                } else
                {
                    var wis = Context.Context.WorkInabilities.Where(w => w.Patient == Patient).ToList();
                    foreach (var item in wis)
                    {
                        if (!item.Ended)
                        {
                            var result = DateTime.Compare(DateTime.Today, item.To);
                            if (result < 0)
                            {
                                item.To = DateTime.Today;
                            }
                            item.Ended = true;
                            Context.UpdateWorkInability(item);
                        }
                    }

                    patient.EndDate = DateTime.Today;
                    Context.AddNewPatient(patient);
                    View.Close();
                }
            }
            
        }
    }
}
