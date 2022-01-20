using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.Model
{
    public class Drug
    {
        public string RegistrationNumber { get; set; }

        public Drug(string code)
        {
            RegistrationNumber = code;
        }

        public Drug()
        {

        }
    }
}
