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
        public string Name { get; set; }
        public string CreditID { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string AddressID { get; set; }
        public string Disease { get; set; }

        public string CellPhoneNumber { get; set; }

        public string HousePhoneNumber { get; set; }

        public string Diagnosis { get; set; }
        public DateTime DiagnosisDate { get; set; }

        public string DoctorID { get; set; }
    }
}
