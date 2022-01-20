using HealthCareSystem.ViewModels;
using HealthCareSystem.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.Commands
{
    public class WaitingRoomCommand : CommandBase
    {
        public override void Execute(object? parameter)
        {
            WaitingRoomView plw = new WaitingRoomView();
            plw.DataContext = new WaitingRoomViewModel();
            plw.Show();
        }
    }
}
