using HealthCareSystem.ViewModels;
using HealthCareSystem.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.Commands
{
    public class ShowOrderCommand : CommandBase
    {
        public override void Execute(object? parameter)
        {
            AddOrderView plw = new AddOrderView();
            plw.DataContext = new AddOrderViewModel();
            plw.Show();
        }
    }
}
