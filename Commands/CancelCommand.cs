using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.Commands
{
    public class CancelCommand : CommandBase
    {
        public PrescriptionView View { get; set; }
        public override void Execute(object? parameter)
        {
            View.Close();
        }
    }
}
