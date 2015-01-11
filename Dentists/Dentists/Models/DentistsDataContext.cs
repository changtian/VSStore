using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentists.Models
{
    public class DentistsDataContext : DbContext
    {
        public DbSet<Patient.Patient> Patients { get; set; }
    }
}
