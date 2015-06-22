using Dentists.Models;
using Dentists.Models.Patient;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Dentists.DataContext
{
    public class DentistEntities:DbContext
    {
        public DentistEntities():base("DentistDataBase")
        { 
        }
        public DbSet<Patient> Patients { get; set; }

        public DbSet<Address> Addresses { get; set; }
    }
}
