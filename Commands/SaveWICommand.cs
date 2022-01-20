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
    public class SaveWICommand : CommandBase
    {
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public DbContextViewModel Context { get; set; }
        public Window View { get; set; }
        public WorkInability WorkInability { get; set; }
        public WorkInabilityViewModel Model { get; set; }
        public bool IsNew { get; set; }

        public override void Execute(object? parameter)
        {
            if (IsNew)
            {
                int res = DateTime.Compare(Model.StartDate, DateTime.Today); //ltz/0
                int res2 = DateTime.Compare(Model.ActualDate, DateTime.Today); //0
                int res3 = DateTime.Compare(Model.EndDate, Model.StartDate); //gtz/0

                if (Model.Diagnosis != null && res <= 0 && res2 <= 0 && res3 >= 0 )
                {
                    int id = Context.Context.WorkInabilities.Count() + 1;
                    var wi = new WorkInability(id, Patient, Model.Place, Model.Diagnosis, Model.ActualDate, Model.StartDate, Model.EndDate, false);
                    Context.AddNewWorkInability(wi);
                }
                else
                {
                    var result = MessageBox.Show("Niektoré hodnoty boli nevyplnené alebo boli vyplnené nesprávne!", "Configuration", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                var wi = Context.Context.WorkInabilities.Where(w => w.ID == WorkInability.ID).Single();
                var wi2 = new WorkInability(0, Patient, Model.Place, Model.Diagnosis, Model.ActualDate, Model.StartDate, Model.EndDate, false);
                wi.To = wi2.To;
                wi.Place = wi2.Place;
                int res3 = DateTime.Compare(wi.To, Model.StartDate);
                if (res3 >= 0 && wi.Place != null)
                {
                    Context.UpdateWorkInability(wi);
                }
                else
                {
                    var result = MessageBox.Show("Niektoré hodnoty boli nevyplnené alebo boli vyplnené nesprávne!", "Configuration", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
            View.Close();
        }
    }
}
