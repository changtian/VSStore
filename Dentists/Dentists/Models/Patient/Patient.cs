using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentists.Models.Patient
{
    public class Patient
    {
        public string PatientID { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public Address Address { get; set; }
        public string Disease { get; set; } 
    }
}
