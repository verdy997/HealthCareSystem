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
    public class AddExaminationCommand : CommandBase
    {
        public Patient Patient { get; set; }
        public Examination Examination { get; set; }
        public Doctor Doctor { get; set; }
        public Ambulance Ambulance { get; set; }
        public DbContextViewModel Context { get; set; }
        public ExaminationsListView View { get; set; }
        public bool IsNew { get; set; }
        public override void Execute(object? parameter)
        {
            ExaminationView ew = new ExaminationView();
            if (Examination != null)
            {
                ew.DataContext = new ExaminationViewModel(Patient, Examination, Doctor, Ambulance, Context, ew, IsNew);
                ew.Show();

            } else
            {
                if (Patient.EndDate == null)
                {
                    ew.DataContext = new ExaminationViewModel(Patient, Doctor, Ambulance, Context, ew, IsNew);
                    ew.Show();
                }
                else
                {
                    var result = MessageBox.Show("Pacient je v Archíve!", "Configuration", MessageBoxButton.OK, MessageBoxImage.Stop);
                }

            }
            View.Close();
        }
    }
}
