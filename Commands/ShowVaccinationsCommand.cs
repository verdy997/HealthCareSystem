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
    public class ShowVaccinationsCommand : CommandBase
    {
        public Patient Patient { get; set; }
        public DbContextViewModel Context { get; set; }
        public override void Execute(object? parameter)
        {
            VaccinationsListView vlw = new VaccinationsListView();
            if (Patient != null)
            {
                vlw.DataContext = new VaccinationsListViewModel(Patient, Context, vlw);
            }
            vlw.Show();
        }
    }
}
