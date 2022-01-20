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
    public class EndWICommand : CommandBase
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
            var wi = Context.Context.WorkInabilities.Where(w => w.ID == WorkInability.ID).Single();
            int res = DateTime.Compare(wi.To, DateTime.Today);
            if (IsNew || res > 0)
            {
                var result = MessageBox.Show("Novú PN nemožno ukončiť!", "Configuration", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                wi.Ended = true;
                Context.UpdateWorkInability(wi);
            }
            View.Close();
        }
    }
}
