using System;
using System.Collections.Generic;
using DevExpress.Mvvm;
using Dentists.Models.Patient;

namespace Dentists.View.Patient
{
    public class AllPatientViewModel : ViewModelBase
    {
        List<Dentists.Models.Patient.Patient> AllPatients { get; set; }
        private DataContext.DentistEntities dbContext;

        public AllPatientViewModel()
        {
            dbContext = new DataContext.DentistEntities();
            if (AllPatients == null) AllPatients = new List<Models.Patient.Patient>();
            
        }
    }
}