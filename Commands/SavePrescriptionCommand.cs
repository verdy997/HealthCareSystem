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
    public class SavePrescriptionCommand : CommandBase
    {
        public PrescriptionViewModel Model { get; set; }
        public DbContextViewModel Context { get; set; }
        public PrescriptionView View { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime Date { get; set; }
        public bool IsNew { get; set; }
        public Prescription Prescription { get; set; }
        public override void Execute(object? parameter)
        {
            if (IsNew)
            {
                if (Doctor != null && Patient != null && Model.Recept != null)
                {
                    int id = Context.Context.Prescriptions.Count() +1;
                    var pres = new Prescription(id, Doctor, Patient, Date, Model.Recept);
                    Context.AddNewPrescription(pres);
                } else
                {
                    var result = MessageBox.Show("Chyba! Niektoré údaje neboli vyplnené!", "Configuration", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (!IsNew)
            {
                if (Patient.EndDate == null)
                {
                    if (Model.Recept != null)
                    {
                        Prescription.Date = Model.Date;
                        Prescription.Drug = Model.Recept;
                        Context.UpdatePrescription(Prescription);
                    }
                    else
                    {
                        var result = MessageBox.Show("Chyba! Niektoré údaje neboli vyplnené!", "Configuration", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                } else
                {
                    var result = MessageBox.Show("Pacient je už v Archíve!", "Configuration", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                
            }

            View.Close();
        }
    }
}
