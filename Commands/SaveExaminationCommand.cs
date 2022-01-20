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
    public class SaveExaminationCommand : CommandBase
    {
        public ExaminationView View { get; set; }
        public DbContextViewModel Context { get; set; }
        public ExaminationViewModel Model { get; set; }
        public Ambulance Ambulance { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public bool IsNew { get; set; }

        public override void Execute(object? parameter)
        {
            if (IsNew)
            {
                int id = Context.Context.Examinations.Count();
                var exa = new Examination(id+1, Ambulance, Doctor, Patient, Model.Reason, Model.Include, Model.Anamnesis);
                if (Ambulance != null && Doctor != null && Patient != null && Model.Reason != null && Model.Include != null && Model.Anamnesis != null)
                {
                    Context.AddNewExamination(exa);
                } else
                {
                    var result = MessageBox.Show("Chyba! Niektoré údaje neboli vyplnené!", "Configuration", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            } else
            {
                var result = MessageBox.Show("Vyšetrenie nie je možné upravovať!", "Configuration", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            
            View.Close();
        }
    }
}
