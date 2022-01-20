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
    public class ShowExaminationsCommand : CommandBase
    {
        public Patient Patient { get; set; }
        public Ambulance Ambulance { get; set; }
        public Doctor Doctor { get; set; }
        public DbContextViewModel Context { get; set; }
        public override void Execute(object? parameter)
        {
            /*ExaminationsListView plw = new ExaminationsListView();
            plw.DataContext = new ExaminationsListViewModel();
            plw.Show();*/

            ExaminationsListView elw = new ExaminationsListView();
            if (Patient != null)
            {
                elw.DataContext = new ExaminationsListViewModel(Patient, Ambulance, Doctor, Context, elw);
            }
            elw.Show();
        }
    }
}
